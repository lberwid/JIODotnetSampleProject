using System.Linq;

namespace TestDotNetProject.Arrays
{
    public class GenericArrayClass<T>
    {
        public int SumArray(int[] a)
        {
            return a.Sum();
        }

        public int[] Sequence(int n)
        {
            return Enumerable.Range(0, n).ToArray();
        }
        public T[][] a() { return null; }
        public T[,] b() { return null; }
        public T[,][] c() { return null; }
        public T[][,] d() { return null; }
    }
}