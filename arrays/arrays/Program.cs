using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TestaArrayInt();

            void TestaArrayInt()
            {
                
                int[] idades = new int[5];
                idades[0] = 12;
                idades[1] = 14;
                idades[2] = 16;
                idades[3] = 18;
                idades[4] = 20;


                Console.WriteLine($"Tamanho do Array igual á {idades.Length}");


                for (int i = 0; i < idades.Length; i++)
                {
                    int listidades = idades[i];
                    Console.WriteLine($"Indice {i} = {idades[i]} ");

                    if (listidades == idades[4])
                    {
                        Console.WriteLine("VocÊ chegou ao fim da lista! ");
                    }
                    int contador = 0;
                    int soma = idades.Sum();
                    contador = soma / 5;
                    

                    Console.WriteLine($"A soma de todas as notas é {contador} pontos ! ");

                    Console.ReadKey();
                }





            }


        }
    }
}
