using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestDotNetProject
{
    public class InstanceClass
    {
        private int _a;
        private readonly string _s;
        private readonly Type _t;

        public void SetX(int a)
        {
            _a = a;
        }
		
		public void SayHiToJavonetWrapperGenerator() {
			Console.WriteLine("Hi! Thank you for using using our wrapper :)");
		}

        public void EnumTestParam(TestEnum sw)
        {
            Console.WriteLine(sw.ToString());
        }

        public TestEnum ReturnEnumFromInt(int en)
        {
            return (TestEnum)en;
        }

        public TestEnum ReturnEnumFromString(string en)
        {
            return (TestEnum) Enum.Parse(typeof(TestEnum), en);
        }

        public void DoNothing()
        {
            return;
        }

        public static void StaticSetX(int a)
        {
            return;
        }

        public static void StaticDoNothing()
        {
            return;
        }

        public InstanceClass(int a, string s, Type t)
        {
            this._a = a;
            this._s = s;
            this._t = t;
        }

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

        public int NonStaticAdd2()
        {
            return this._a + 1;
        }

        public string NonStaticAppendAaa()
        {
            return this._s + "AAA";
        }

        public Type NonStaticMyGetType()
        {
            return this._t;
        }
    }
}
