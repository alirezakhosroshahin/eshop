using System.Collections.Generic;
using Test.Core.DTOs.Order;
using Test.DataLayer.Entities.Order;

namespace Test.Core.Services.Interface
{
    public interface IOrderService
    {
        int AddOrder(string userName, int courseId);
        void UpdatePriceOrder(int orderId);
        List<Order> GetUserOrders(string userName);
        Order GetOrderForUserPanel(string userName, int orderId);
        Order GetOrderById(int orderId);
        bool IsUserInCourse(string userName, int courseId);
        
        bool FinalyOrder(string userName,int orderId);
        void UpdateOrder(Order order);
        DiscountUseType UseDiscount(int orderId, string code);
        void AddDiscount(Discount discount);
        List<Discount> GetAllDiscounts();
        Discount GetDiscountById(int discountId);
        void UpdateDiscount(Discount discount);
        bool IsExistCode(string code);
    }
}