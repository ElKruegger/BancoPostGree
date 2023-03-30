using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string aulaintro = "Introdução as Coleções";
            string aulamodelando = "Modelando a classe Aula";
            string aulasets = "Trabalhando com conjuntos";

            /*List<string> aulaAlura = new List<string>
            {
                aulaintro,
                aulamodelando,
                aulasets

            };
            NewMethod(aulaAlura);
            */

            List<string> aula = new List<string>();
            aula.Add(aulaintro);
            aula.Add(aulamodelando);
            aula.Add(aulasets);




            NewMethod(aula);


        }

        private static void NewMethod(List<string> aulaAlura)
        {
            foreach (string aula in aulaAlura)
            {
                Console.WriteLine(aula);
            }
            Console.ReadKey();
        }
    }
}
