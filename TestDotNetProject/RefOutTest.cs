namespace TestDotNetProject
{
    public class RefOutTest
    {
        public void Add2(ref int val)
        {
            val += 2;
        }

        public bool TryCast(string s, out int i)
        {
            return int.TryParse(s, out i);
        }
    }
}