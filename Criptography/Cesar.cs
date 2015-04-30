using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptography
{
    class Cesar
    {
        String phrase;
        private int key;
        private int posicion;
        private String encodedPhrase;
        private String decodedPhrase;

        public Cesar(String phrase,int key)
        {
            this.phrase = phrase;
            this.key = key;
            encodedPhrase = null;
            posicion = 0;
        }
        public string getencodedPhrase()
        {
            return encodedPhrase;
        }
        public string getdecodedPhrase()
        {
            return decodedPhrase;
        }
      
      
        public void encode()
        {
            encodedPhrase = null;
            for (int i = 0; i < phrase.Length; i++)
            {
                //revisar espacios en blanco
                if (phrase[i]==' ')
                {
                    encodedPhrase += ' ';
                }
                else
                {
                        posicion = (int)phrase[i] + key;       
                        if (posicion > 90) posicion -= 26;
                        encodedPhrase += (char)posicion;                  
                }
            }
        }
        public void decode(string coded)
        {
            decodedPhrase = null;
            for (int i = 0; i < coded.Length; i++)
            {
                    if (coded[i] == ' ')
                    {
                        decodedPhrase += ' ';
                    }
                    else
                    {
                        posicion = (int)coded[i] - key;
                        if (posicion < 65) posicion += 26;
                        decodedPhrase += (char)posicion;
                    }
            }
        }
    }

}
