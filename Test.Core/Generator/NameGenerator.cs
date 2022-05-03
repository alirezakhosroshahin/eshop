using System;

namespace Test.Core.Generator
{
    public class NameGenerator
    {
        public static string GenerateUnicCode()
        {
            return  Guid.NewGuid().ToString().Replace("_", "");
        }
    }
}