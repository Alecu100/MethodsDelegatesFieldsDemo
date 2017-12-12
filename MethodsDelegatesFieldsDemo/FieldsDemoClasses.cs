using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDelegatesFieldsDemo
{
    public class BaseClassField
    {
        public string DuplicateField = "BaseClassField";
    }

    public class DerivedClassField : BaseClassField
    {
        public string DuplicateField = "DerivedClassField";
    }
}
