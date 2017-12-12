using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDelegatesFieldsDemo
{
    public class BaseClassVirtualMethod
    {
        public virtual void DuplicateMethod()
        {
            Console.WriteLine("Executing virtual method from BaseClassVirtualMethod on the same object");
        }
    }

    public class DerivedClassVirtualMethod1 : BaseClassVirtualMethod
    {
        public void DuplicateMethod()
        {
            Console.WriteLine("Executing nonvirtual method from DerivedClassVirtualMethod1 on the same object");
        }
    }

    public class DerivedClassVirtualMethod2 : BaseClassVirtualMethod
    {
        public virtual void DuplicateMethod()
        {
            Console.WriteLine("Executing virtual method from DerivedClassVirtualMethod2 on the same object");
        }
    }

    public class DerivedClassVirtualMethod3 : BaseClassVirtualMethod
    {
        public override void DuplicateMethod()
        {
            Console.WriteLine("Executing override method from DerivedClassVirtualMethod3 on the same object");
        }
    }
}
