using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_empresa.Entities
{
    // Funcionário terceirizado é um funcionário também
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }


        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;  // 1.1 = 110%
        }

    }
}
