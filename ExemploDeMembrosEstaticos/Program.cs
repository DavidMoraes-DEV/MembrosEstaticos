using System;
using System.Globalization;

namespace ExemploDeMembrosEstaticos
{
    class Program
    {
        static double Pi = 3.14; //Membro estárico
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;


            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CI);
            double circ = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine();
            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CI));
            Console.WriteLine("Volume: " + volume.ToString("F2", CI));
            Console.WriteLine("Valor de Pi: " + Pi.ToString("F2", CI));
        }

        static double Circunferencia(double r) //Membro Estatico
        {
            return 2.0 * Pi * r;
        }

        static double Volume(double r)  //Membro Estatico
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}

/*Os membros estaticos são utilizados para serem usados apenas nessa classe e podem
 * ser chamados dentro de outros membros dessa classe se também forem estaticos como no exemplo acima.*/