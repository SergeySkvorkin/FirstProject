using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Convertations
    {
        public int FromStringToInt32(string str)
        {
            int result;
            try
            {
                result = Convert.ToInt32(str);
            }
            catch (Exception)
            {

                return 0;
            }
            

            return result;
        }
    }
}
