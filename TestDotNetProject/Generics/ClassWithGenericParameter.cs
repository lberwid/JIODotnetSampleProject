using System;

namespace TestDotNetProject.Generics
{
    public class ClassWithGenericParameter<T> where T : class, new()
    {
        public Type GetGenericType()
        {
            return typeof(T);
        }

        public void MethodWithGenericParam(T arg)
        {
            var x = new T();
            x = arg;
        }

        public T MethodReturnsGeneric()
        {
            return new T();
        }

        public void ConvertKToT<K>(K arg)
        {
            var x = new T();
            x = (T) (object) arg;
        }
    }
}