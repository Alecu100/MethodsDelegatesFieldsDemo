using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDelegatesFieldsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClassField derivedClassFieldReference = new DerivedClassField();
            BaseClassField baseClassFieldReference = derivedClassFieldReference;

            Console.WriteLine("Field value from DerivedClassField reference on the same object: " +
                              derivedClassFieldReference.DuplicateField);
            Console.WriteLine("Field value from BaseClassField reference on the same object: " +
                              baseClassFieldReference.DuplicateField);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();




            DerivedClassMethod derivedClassMethodReference = new DerivedClassMethod();
            BaseClassMethod baseClassMethodReference = derivedClassMethodReference;

            derivedClassMethodReference.DuplicateMethod();
            baseClassMethodReference.DuplicateMethod();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();




            DerivedClassVirtualMethod1 derivedClassVirtualMethodReference1 = new DerivedClassVirtualMethod1();
            DerivedClassVirtualMethod2 derivedClassVirtualMethodReference2 = new DerivedClassVirtualMethod2();
            DerivedClassVirtualMethod3 derivedClassVirtualMethodReference3 = new DerivedClassVirtualMethod3();

            BaseClassVirtualMethod baseClassVirtualMethodReference1 = derivedClassVirtualMethodReference1;
            BaseClassVirtualMethod baseClassVirtualMethodReference2 = derivedClassVirtualMethodReference2;
            BaseClassVirtualMethod baseClassVirtualMethodReference3 = derivedClassVirtualMethodReference3;

            derivedClassVirtualMethodReference1.DuplicateMethod();
            derivedClassVirtualMethodReference2.DuplicateMethod();
            derivedClassVirtualMethodReference3.DuplicateMethod();

            baseClassVirtualMethodReference1.DuplicateMethod();
            baseClassVirtualMethodReference2.DuplicateMethod();
            baseClassVirtualMethodReference3.DuplicateMethod();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();




            InheritanceChainDemoClassLevel5 inheritanceChainDemoClassLevel5Reference =
                new InheritanceChainDemoClassLevel5();

            InheritanceChainDemoClassLevel4 inheritanceChainDemoClassLevel4Reference =
                inheritanceChainDemoClassLevel5Reference;

            InheritanceChainDemoClassLevel3 inheritanceChainDemoClassLevel3Reference =
                inheritanceChainDemoClassLevel5Reference;

            InheritanceChainDemoClassLevel2 inheritanceChainDemoClassLevel2Reference =
                inheritanceChainDemoClassLevel5Reference;

            InheritanceChainDemoClassLevel1 inheritanceChainDemoClassLevel1Reference =
                inheritanceChainDemoClassLevel5Reference;


            inheritanceChainDemoClassLevel1Reference.DuplicateMethod();
            inheritanceChainDemoClassLevel2Reference.DuplicateMethod();
            inheritanceChainDemoClassLevel3Reference.DuplicateMethod();
            inheritanceChainDemoClassLevel4Reference.DuplicateMethod();
            inheritanceChainDemoClassLevel5Reference.DuplicateMethod();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
