using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class ChildClass : DerivedClass
    {
        public override void VertualBase()
        {
            
            Console.WriteLine("ChildClass Override");
        }
        //'ChildClass.PublicBase()' hides inherited member 'DerivedClass.PublicBase()'. Use the new keyword if hiding was intended.
        public void PublicBase()
        {
            Console.WriteLine("ChildClass Class Method public");
        }

        private void PrivateBase()
        {
            Console.WriteLine("ChildClass Class Method private");
        }

        //'ChildClass.ProtectedBase()' hides inherited member 'DerivedClass.ProtectedBase()'. Use the new keyword if hiding was intended.
        protected void ProtectedBase()
        {
            this.ProtectedBase();
            Console.WriteLine("ChildClass Class Method protected");
        }


        //'ChildClass.InternalBase()' hides inherited member 'DerivedClass.InternalBase()'. Use the new keyword if hiding was intended.
        internal void InternalBase()
        {
            Console.WriteLine("ChildClass Class Method internal");
        }

        //'ChildClass.ProtectedInternalBase()' hides inherited member 'DerivedClass.ProtectedInternalBase()'. Use the new keyword if hiding was intended.
        protected internal void ProtectedInternalBase()
        {
            Console.WriteLine("ChildClass Class Method ProtectedInternal");
        }

    }
}
