using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Testing_Practicing
{
    class Manager : Employee
    {
        public void Management()
        {
            
        }

        public override void Validate()
        {
            base.Validate(); // override the code here because of the use of virtual keyword in mother class. Write our onw logic here
        }

        public void Validate(bool strict) // overloading (same function of parent class in different inputs)
        {

        }

        public void Validate(bool strict, int num1) // overloading (same function of parent class in different inputs)
        {

        }
    }
}
