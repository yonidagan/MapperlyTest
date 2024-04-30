using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperlyTest
{
    [Mapper(ThrowOnMappingNullMismatch = false, UseReferenceHandling = true)]
    public partial class ClassMapper
    {
        public partial ClassB ToClassB(ClassA classA);

        public partial ClassD ToClassD(ClassC classC);

    }
}
