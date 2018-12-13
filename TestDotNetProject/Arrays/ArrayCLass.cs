using System.Linq;

namespace TestDotNetProject.Arrays
{
    public class ArrayClass
    {
        public int SumArray(int[] a)
        {
            return a.Sum();
        }

        public int[] Sequence(int n)
        {
            return Enumerable.Range(0, n).ToArray();
        }
        public int[][] a() { return null; }
        public int[,] b() { return null; }
        public int[,][] c() { return null; }
        public int[][,] d() { return null; }
    }
}