using System;

namespace TestDotNetProject
{
    public class GenericClass
    {
        public void MethodWithGenericParameter<T>(T arg1)
        {
            Console.WriteLine(arg1.ToString());
            return;
        }
        public K MethodGenericReturnAndArg<T, K>(T arg1)
        {
            Console.WriteLine(arg1.ToString());
            //Some operation  
            return default(K);
        }
        public K MethodGenericReturn<K >()
          where K : new()
        {
            return new K();
        }

    }
}