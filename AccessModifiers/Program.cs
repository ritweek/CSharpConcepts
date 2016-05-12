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

            BaseClass objBaseClass = new DerivedClass();

            objClass.PublicBase();
            objClass.VertualBase();
            objClass.InternalBase();
            objClass.ProtectedInternalBase();
            

            objBaseClass.PublicBase();
            objBaseClass.VertualBase();
            objBaseClass.InternalBase();
            objBaseClass.ProtectedInternalBase();


            objDerivedClass.PublicBase();
            objDerivedClass.InternalBase();
            objDerivedClass.ProtectedInternalBase();
            objDerivedClass.VertualBase();

            
        }
    }
}
