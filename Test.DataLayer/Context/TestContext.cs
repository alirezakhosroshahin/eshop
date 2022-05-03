using System.Linq;
using Microsoft.EntityFrameworkCore;
using Test.DataLayer.Entities.Course;
using Test.DataLayer.Entities.Order;
using Test.DataLayer.Entities.Permissions;
using Test.DataLayer.Entities.User;
using Test.DataLayer.Entities.Wallet;

namespace Test.DataLayer.Context
{
    public class TestContext : DbContext
    {
        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseEpisode> CourseEpisodes { get; set; }
        public virtual DbSet<CourseGroup> CourseGroups { get; set; }
        public virtual DbSet<CourseLevel> CourseLevels { get; set; }
        public virtual DbSet<CourseStatus> CourseStatuses { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<Wallet> Wallets { get; set; }
        public virtual DbSet<WalletType> WalletTypes { get; set; }
        public virtual DbSet<UserCourse> UserCourses { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<RolePermission> RolePermissions { get; set; }
        public virtual DbSet<UserDiscountCode> UserDiscountCodes { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);


            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasIndex(e => e.TeacherId, "IX_Courses_TeacherId");

                entity.Property(e => e.CourseDescription).IsRequired();

                entity.Property(e => e.CourseImageName).HasMaxLength(50);

                entity.Property(e => e.CourseTitle)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DemoFileName).HasMaxLength(100);

                entity.Property(e => e.Tags).HasMaxLength(600);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.CourseGroups)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_Courses_CourseGroups");

                entity.HasOne(d => d.CourseLevel)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.LevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Courses_CourseLevels");

                entity.HasOne(d => d.CourseStatus)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Courses_CourseStatuses");

                entity.HasOne(d => d.SubGroupNavigation)
                    .WithMany(p => p.CourseSubGroupNavigations)
                    .HasForeignKey(d => d.SubGroup)
                    .HasConstraintName("FK_Courses_CourseGroups1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<UserDiscountCode>(entity =>
            {
                entity.HasKey(e => e.UdId);

                entity.HasIndex(e => e.DiscountId, "IX_UserDiscountCodes_DiscountId");

                entity.HasIndex(e => e.UserId, "IX_UserDiscountCodes_UserId");

                entity.Property(e => e.UdId).HasColumnName("UD_Id");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.UserDiscountCodes)
                    .HasForeignKey(d => d.DiscountId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserDiscountCodes)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.Property(e => e.DiscountCode)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<CourseEpisode>(entity =>
            {
                entity.HasKey(e => e.EpisodeId);

                entity.HasIndex(e => e.CourseId, "IX_CourseEpisodes_CourseId");

                entity.Property(e => e.EpisodeTitle)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseEpisodes)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<CourseGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.Property(e => e.GroupTitle)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_CourseGroups_CourseGroups");
            });

            modelBuilder.Entity<CourseLevel>(entity =>
            {
                entity.HasKey(e => e.LevelId);

                entity.Property(e => e.LevelTitle)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<CourseStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.Property(e => e.StatusTitle)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<UserCourse>(entity =>
            {
                entity.HasKey(e => e.UcId);

                entity.HasIndex(e => e.CourseId, "IX_UserCourses_CourseId");

                entity.HasIndex(e => e.UserId, "IX_UserCourses_UserId");

                entity.Property(e => e.UcId).HasColumnName("UC_Id");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.UserCourses)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserCourses)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_Orders_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.HasIndex(e => e.CourseId, "IX_OrderDetails_CourseId");

                entity.HasIndex(e => e.OrderId, "IX_OrderDetails_OrderId");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.ToTable("Permission");

                entity.HasIndex(e => e.ParentId, "IX_Permission_ParentID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PermissionTitle)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleTitle)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<RolePermission>(entity =>
            {
                entity.HasKey(e => e.RpId);

                entity.ToTable("RolePermission");

                entity.HasIndex(e => e.PermissionId, "IX_RolePermission_PermissionId");

                entity.HasIndex(e => e.RoleId, "IX_RolePermission_RoleId");

                entity.Property(e => e.RpId).HasColumnName("RP_Id");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.RolePermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RolePermissions)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.ActiveCode).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UserAvatar).HasMaxLength(200);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => e.UrId);

                entity.HasIndex(e => e.RoleId, "IX_UserRoles_RoleId");

                entity.HasIndex(e => e.UserId, "IX_UserRoles_UserId");

                entity.Property(e => e.UrId).HasColumnName("UR_Id");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Wallet>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_Wallets_UserId");

                entity.HasIndex(e => e.WalletTypeTypeId, "IX_Wallets_WalletTypeTypeId");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Wallets)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.WalletTypeType)
                    .WithMany(p => p.Wallets)
                    .HasForeignKey(d => d.WalletTypeTypeId);
            });

            modelBuilder.Entity<WalletType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.Property(e => e.TypeId).ValueGeneratedNever();

                entity.Property(e => e.TypeTitle)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}