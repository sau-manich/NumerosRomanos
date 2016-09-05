using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numerosNATURALESaROMANOS
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            String[]faciles={"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};
            String[]medianos={ "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"};
            Console.WriteLine("");
            Console.WriteLine("     INGRESE LOS VALORES QUE DECEE CONVERTIR DEL 1 AL 99");
            Console.WriteLine("");
            
            N = Convert.ToInt32(Console.ReadLine());
            int F;
            int M;
            F = N % 10;
            M =(N / 10) % 10;
            if(N<=99){           
                       Console.WriteLine(medianos[M]+faciles[F]);  
                      }
            else{  
                 if(N<=9)
                {  
                 Console.WriteLine(faciles[F]);            
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("   EL NUMERO NO ES BALIDO");         
                }            
                }
            Console.ReadKey();
        }  
    }  
}  
        