using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaCepCorreios
{
    class ProcessCep
    {
        static void Process(string cep)
        {
            if (cep == null)
            {
                throw new ArgumentNullException();
            }
        }
    }
}
