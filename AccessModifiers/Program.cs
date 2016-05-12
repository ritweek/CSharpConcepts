using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass objDerivedClass = new DerivedClass();
            BaseClass objClass = new BaseClass();

            //We can not create DerivedClass object as new BaseClass
            BaseClass objBaseClass = new DerivedClass();

            ChildClass objChildClass = new ChildClass();

           
            //Base Class
            objClass.PublicBase();
            objClass.VertualBase();
            objClass.InternalBase();
            objClass.ProtectedInternalBase();

            //Derived Class
            objDerivedClass.PublicBase();
            objDerivedClass.InternalBase();
            objDerivedClass.ProtectedInternalBase();
            objDerivedClass.VertualBase();

            //Base Class an object of Derived Class
            objBaseClass.PublicBase(); 
            objBaseClass.VertualBase(); 
            objBaseClass.InternalBase(); 
            objBaseClass.ProtectedInternalBase();

            //Child Class 
            objChildClass.PublicBase();
            objChildClass.InternalBase();
            objChildClass.ProtectedInternalBase();
            objChildClass.VertualBase();





        }
    }
}
