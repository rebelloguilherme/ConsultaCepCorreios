using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsultaCepCorreios
{
    using CEPService;
    class Program
    {
        static void Main(string[] args)
        {

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\guilh\source\repos\ConsultaCepCorreios\ConsultaCepCorreios\ceps.txt");
            Console.WriteLine("Digite qualquer tecla para a consulta iniciar... ");
            Console.WriteLine("");
            Console.ReadKey();
            Console.Clear();
            //var cep = Console.ReadLine();

            foreach (string line in lines)
            {
                try
                {
                    ProcessCep(line);
                }
                catch (System.Exception e)
                {
                    Console.WriteLine("Exception:{0} ", e);
                    Console.WriteLine("Fall in exception:{0} ", e.Message);
                }
                Console.WriteLine("\t" + line);
                ConsultaCEP(line);
                //if (!string.IsNullOrEmpty(line))
                //{
                //    ConsultaCEP(line);
                //}
            }
            Console.WriteLine("Pesquisa concluida pressione qualquer tecla para sair ");
            Console.WriteLine("");
            Console.ReadKey();

        }

        private static void ProcessCep(string line)
        {
            if (line == null)
            {
                throw new System.Exception();
            }

            if (line.Length < 8)
            {
                throw new System.Exception();
            }
            
        }

        //criar o método para consulta ao webService
        private static void ConsultaCEP(string cep)
        {
            using (var ws = new AtendeClienteClient())
            {
                var resposta = ws.consultaCEP(cep);
                Console.WriteLine(String.Format("Endereço : {0}", resposta.end));
                Console.WriteLine(String.Format("Bairro : {0}", resposta.bairro));
                Console.WriteLine(String.Format("Bairro : {0}", resposta.cidade));
                Console.WriteLine("");
            }
        }

    }
}
