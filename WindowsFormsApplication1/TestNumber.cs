using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class TestNumber
    {
        public Boolean testNum(int n)
        {
            Boolean valid = false;
            if (n >= 5 && n <= 20)
                valid = true;
            return valid;
        }
    }
}
