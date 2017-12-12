using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDelegatesFieldsDemo
{
    public class BaseClassMethod
    {
        public void DuplicateMethod()
        {
            Console.WriteLine("Executing method from BaseClassMethod on the same object");
        }
    }

    public class DerivedClassMethod : BaseClassMethod
    {
        public void DuplicateMethod()
        {
            Console.WriteLine("Executing method from DerivedClassMethod on the same object");
        }
    }
}
