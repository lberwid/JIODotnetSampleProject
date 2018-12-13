using System;

namespace TestDotNetProject.Static
{
    public static class StaticClass
    {
        public static int Add2(int i)
        {
            return i + 1;
        }

        public static string AppendAaa(string a)
        {
            return a + "AAA";
        }

        public static Type MyGetType(object o)
        {
            return o.GetType();
        }
    }
}
