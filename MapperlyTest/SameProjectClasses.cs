using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperlyTest
{
    public class ClassC
    {
        public string Name { get; set; }
        public string Value { get; set; }

        [MapperIgnore]
        public string? Ignored { get; set; }
    }

    public class ClassD
    {
        public string Name { get; set; }
        public string Value { get; set; }

        [MapperIgnore]
        public string? Ignored { get; set; }
    }


}
