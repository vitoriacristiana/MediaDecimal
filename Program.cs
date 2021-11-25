using System;

namespace MediaDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
           int  qtd , c ;
            double n , n1 , soma  =  0 , med , maior , menor ;

            Console.Beep ();
            Console.Clear();
            
            Console.Write ("Quantidade de números:");
            qtd  = int.Parse (Console.ReadLine ());

            Console.Write ($"Número # 1:");
            n1  = double.Parse ( Console.ReadLine ());

            maior  =  n1;
            menor  =  n1;
            c =2;

            while( c <= qtd )
            {
                Console.Write ($" Número # {c}:");
                n  = double.Parse ( Console.ReadLine());
                
                if (n  >  maior)
                {
                    maior  =  n;
                }
                else  if ( n < menor )
                {
                    menor  =  n;
                }
                soma  =  soma + n;
                c ++;
            }
            soma  = soma  + n1;
            med  =  soma  / qtd;
            Console.WriteLine ($" Soma: {soma}");
            Console.WriteLine ($" Média: {med:N2}");
            Console.Write ($" Maior:");
            Console.ForegroundColor  =  ConsoleColor.DarkGreen ;
            Console.WriteLine ($"{maior:N2}");
            Console.ResetColor();
            Console.Write ($"Menor:");
            Console.ForegroundColor  =  ConsoleColor.DarkRed;
            Console.WriteLine ($"{menor:N2}" );
            Console.ResetColor ();
        }
    }
} 