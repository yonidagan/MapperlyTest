using Riok.Mapperly.Abstractions;

namespace MapperlyTest
{
    public class ClassA
    {
        public string Name { get; set; }
        public string Value { get; set; }

        [MapperIgnore]
        public string? Ignored { get; set; }
    }
}
