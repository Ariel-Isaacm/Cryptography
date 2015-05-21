using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptography
{
    class Vernam
    {
        String cifrado;
        String msj;
        ArrayList numeros;
        Random random;
        int randomNumber;
        String descifrado;
        public Vernam(String mensaje)
        {
            this.msj = mensaje;
            random = new Random(); 
        }
        public string cifrar()
        {
            
            numeros = new ArrayList();

            for (int i = 0; i < msj.Length; i++)
            {
              randomNumber = random.Next(0, 100);
              numeros.Add(randomNumber);
              cifrado += (char)((int)msj[i] + randomNumber);
            }
            return cifrado;
        }
        public string descifrar()
        {
            descifrado = null;
            for (int i = 0; i < cifrado.Length; i++)
            {
                descifrado+=(char)((int)cifrado[i]-(int)numeros[i]);
            }
            return descifrado;
        }
    }
}
