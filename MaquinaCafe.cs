using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteira
{
    public class MaquinaCafe
    {
        public float acucarDisponivel = 500;

        public void FazerCafe(float acucar)
        {
            if (acucar <= acucarDisponivel)
            {
                BarraFazendo("Preparando o cafe", 7, 500);
                Console.WriteLine($"");
        
                acucarDisponivel -= acucar;
                Console.WriteLine($"Aqui esta seu cafe com acucar ({acucar}g)");
            }
        }
        public void FazerCafe()
        {
            BarraFazendo("Preparando o cafe", 7, 500);
            Console.WriteLine($"");
            Console.WriteLine($"Aqui esta seu cafe sem acucar");
        }

        public void BarraFazendo(string txt, int ponto, int tempo)
        {
            Console.Write(txt);
            for (int i = 0; i < ponto; i++)
            {
                Console.Write($".");
                Thread.Sleep(tempo);
                
            }

        }
    }
}