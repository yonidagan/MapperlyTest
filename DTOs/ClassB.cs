using Riok.Mapperly.Abstractions;

namespace MapperlyTest
{
    public class ClassB
    {
        public string Name { get; set; }
        public string Value { get; set; }

        [MapperIgnore]
        public string? Ignored { get; set; }
    }
}
