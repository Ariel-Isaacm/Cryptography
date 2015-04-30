using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptography
{
    class Program
    {
        static void Main(string[] args)
        {
            //constructor que acepta la frase a cifrar y el valor de p
            Cesar cesar = new Cesar("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG", 3);
            
            cesar.encode();
            cesar.decode("WKH TXLFN EURZQ IRA MXPSV RYHU WKH ODCB GRJ");
            Console.WriteLine("Algoritmo cesar");
            Console.WriteLine("Palabra cifrada");
            Console.WriteLine(cesar.getencodedPhrase());
            Console.WriteLine("Palabra decifrada");
            Console.WriteLine(cesar.getdecodedPhrase());

            Console.WriteLine("Sustitución");
            Sustitucion sus = new Sustitucion("ynficwlbkuomxsevzpdrjgthaq", "hola");
            Console.WriteLine(sus.translate());
            Console.ReadKey();
        }


    }
}
