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
            Cesar cesar = new Cesar("", 9);
            String reverse = "UJCRE NAXV MWJ NAXV NVXLNK UURF HQYJAPXCYHAL BTAXFCNW ANCDYVXL XC NEXV XC NDWRCWXL BWXRCJLRWDVVXL MWJ NLANVVXL BJ NADCDO NQC WR MWJ";
            String straight = "";
            int x = 1;
            for (int i = reverse.Length; i > 0; i--)
            {

                straight += reverse[reverse.Length -x];
                x++;
            }
            cesar.decode(straight);
            Console.WriteLine(cesar.getdecodedPhrase());
            
            
            
            cesar.encode();
            cesar.decode("L JRW LW");
            Console.WriteLine("Algoritmo cesar");
            Console.WriteLine("Palabra cifrada");
            //HELLO EVERYBODY
            //H SLJABYL PU LUNSPZO
            
            Console.WriteLine("Palabra decifrada");
            Console.WriteLine(cesar.getdecodedPhrase());

            Console.WriteLine("Sustitución");
            Sustitucion sus = new Sustitucion("ynficwlbkuomxsevzpdrjgthaq", "hola");
            Console.WriteLine(sus.translate());
            Console.ReadKey();
        }


    }
}
