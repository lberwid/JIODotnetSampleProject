using System;

namespace TestDotNetProject.InterfaceTest
{
    public class ClassImplementingInterface : Interface

    {
        public void Print()
        {
            Console.WriteLine("siema");
        }

        public string GetA()
        {
            return "A";
        }

        public int ConvertToInt(string a)
        {
            return Convert.ToInt32(a);
        }
    }
}