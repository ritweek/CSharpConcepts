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

        public void PublicBase()
        {
            Console.WriteLine("Derived Class Method public");
        }

        private void PrivateBase()
        {
            Console.WriteLine("Derived Class Method private");
        }

        protected void ProtectedBase()
        {
            this.ProtectedBase();
            Console.WriteLine("Derived Class Method protected");
        }

        internal void InternalBase()
        {
            Console.WriteLine("Derived Class Method internal");
        }

        protected internal void ProtectedInternalBase()
        {
            Console.WriteLine("Derived Class Method ProtectedInternal");
        }

    }
}
