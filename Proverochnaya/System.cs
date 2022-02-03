using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proverochnaya
{
    class SystemE
    {
        public Dictionary<Employee, int> DestroyCount = new Dictionary<Employee, int>();
        public Employee FindDestroyer()
        {
            var max = 0;
            Employee emp1 = new Employee();
            foreach( var emp in DestroyCount.Keys)
            {
                if (max <= DestroyCount[emp])
                {
                    max = DestroyCount[emp];
                    emp1 = emp;
                }
            }
            return emp1;
        }
    }
}
