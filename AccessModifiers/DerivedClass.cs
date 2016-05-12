using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class DerivedClass : BaseClass
    {
        public override void VertualBase()
        {
            Console.WriteLine("Derived Class Override");
        }

        //DerivedClass.PublicBase()' hides inherited member 'BaseClass.PublicBase()'. Use the new keyword if hiding was intended.
        public void PublicBase()
        {
            Console.WriteLine("Derived Class Method public");
        }

        private void PrivateBase()
        {
            Console.WriteLine("Derived Class Method private");
        }

        //'DerivedClass.ProtectedBase()' hides inherited member 'BaseClass.ProtectedBase()'. Use the new keyword if hiding was intended.
        protected void ProtectedBase()
        {
            this.ProtectedBase();
            Console.WriteLine("Derived Class Method protected");
        }


        //'DerivedClass.InternalBase()' hides inherited member 'BaseClass.InternalBase()'. Use the new keyword if hiding was intended.
        internal void InternalBase()
        {
            Console.WriteLine("Derived Class Method internal");
        }

        //'DerivedClass.ProtectedInternalBase()' hides inherited member 'BaseClass.ProtectedInternalBase()'. Use the new keyword if hiding was intended.
        protected internal void ProtectedInternalBase()
        {
            Console.WriteLine("Derived Class Method ProtectedInternal");
        }

    }
}
