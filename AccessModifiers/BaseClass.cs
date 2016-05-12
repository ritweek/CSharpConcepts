using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class BaseClass
    {
        public string Name { get; set; }

        private string Address { get; set; }

        protected string Location { get; set; }

        internal string PhoneNumber { get; set; }

        protected internal string TelePhone { get; set; }

        public void PublicBase()
        {
            Console.WriteLine("Base Class Method public");
        }

        private void PrivateBase()
        {
            Console.WriteLine("Base Class Method private");
        }

        protected void ProtectedBase()
        {
            Console.WriteLine("Base Class Method protected");
        }

        internal void InternalBase()
        {
            Console.WriteLine("Base Class Method internal");
        }

        protected internal void ProtectedInternalBase()
        {
            Console.WriteLine("Base Class Method ProtectedInternal");
        }


        public virtual void VertualBase()
        {
            Console.WriteLine("Base Class Method Virtual");
        }
    }
}
