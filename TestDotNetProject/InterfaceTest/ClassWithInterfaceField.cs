namespace TestDotNetProject.InterfaceTest
{
    public class ClassWithInterfaceField
    {
        public Interface InterfaceProperty { get; set; }
        public readonly Interface InterfaceField;

        public ClassWithInterfaceField()
        {
        }

        public ClassWithInterfaceField(Interface i)
        {
            InterfaceProperty = i;
            InterfaceField = i;
        }

        public void CallField()
        {
            InterfaceField.Print();
        }

        public void CallProperty()
        {
            InterfaceProperty.Print();
        }
    }
}