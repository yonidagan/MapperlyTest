
namespace MapperlyTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassMapper mapper = new ClassMapper();

            ClassA a = new ClassA() { Name="ClassA", Value="Some Value", Ignored="abc"};

            
            // b.Ignored should be null here, but it's not.
            ClassB b = mapper.ToClassB(a);

            ClassC c = new ClassC() { Name = "ClassC", Value = "Some Value 2", Ignored = "abc" };
            
            // d.Ignored should be null here, and it is, as expected
            ClassD d = mapper.ToClassD(c);
        }
    }
}
