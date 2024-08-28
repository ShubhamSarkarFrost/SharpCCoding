using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputedPropertiesC
{
    internal class ComputedClass
    {
        // Fields
        private int field1;
        private int field2;

        // Constructor
        public ComputedClass(int value1, int value2)
        {
            field1 = value1;
            field2 = value2;
        }

        // Computed property
        public int ComputedProperty
        {
            get
            {
                // Calculate and return a value based on other fields or properties
                return field1 + field2;
            }
        }
    }
}
