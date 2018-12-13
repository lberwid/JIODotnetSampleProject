using System;

namespace TestDotNetProject
{
    public class ConstructorClass
    {
        private readonly int _a;
        private readonly string _b;
        private readonly Type _t;

        public ConstructorClass()
        {
            
        }

        public ConstructorClass(int a)
        {
            _a = a;
        }
        
        public ConstructorClass(int a, string b)
        {
            _a = a;
            _b = b;
        }

        public ConstructorClass(int a, string b, Type t)
        {
            _a = a;
            _b = b;
            _t = t;
        }
    }
}
