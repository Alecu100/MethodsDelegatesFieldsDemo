using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDelegatesFieldsDemo
{
    public class InheritanceChainDemoClassLevel1
    {
        public virtual void DuplicateMethod()
        {
            Console.WriteLine("Executing virtual method from InheritanceChainDemoClassLevel1 on the same object");
        }
    }

    public class InheritanceChainDemoClassLevel2 : InheritanceChainDemoClassLevel1
    {
        public override void DuplicateMethod()
        {
            Console.WriteLine("Executing virtual method from InheritanceChainDemoClassLevel2 on the same object");
        }
    }

    public class InheritanceChainDemoClassLevel3 : InheritanceChainDemoClassLevel2
    {
        public override void DuplicateMethod()
        {
            Console.WriteLine("Executing virtual method from InheritanceChainDemoClassLevel3 on the same object");
        }
    }

    public class InheritanceChainDemoClassLevel4 : InheritanceChainDemoClassLevel3
    {
        public virtual void DuplicateMethod()
        {
            Console.WriteLine("Executing virtual method from InheritanceChainDemoClassLevel4 on the same object");
        }
    }

    public class InheritanceChainDemoClassLevel5 : InheritanceChainDemoClassLevel4
    {
        public override void DuplicateMethod()
        {
            Console.WriteLine("Executing virtual method from InheritanceChainDemoClassLevel5 on the same object");
        }
    }
}
