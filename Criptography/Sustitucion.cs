using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptography
{
    
    class Sustitucion
    {
        public String alphabet = "abcdefghijklmnñopqrstuvwxyz";
        private string key;
        private string message;
        public string ciphered;
        public Sustitucion(string key,string message)
        {
            this.key = key;
            this.message = message;
        }
        public string translate()
        {
            for (int i = 0; i < message.Length; i++)
            {
                ciphered += key[alphabet.LastIndexOf(message[i])];
            }
            return ciphered;
        }
    }
}
