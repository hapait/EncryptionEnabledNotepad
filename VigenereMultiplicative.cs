using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionEnabledNotepad
{
    class VigenereMultiplicative
    {
        int[] password = new int[]{2,4,7};
        int[] decryptPassword = new int[] {7,10,2 };
        int[] message = new int[] { 7,3,6,4,3,5,3,12};
        int mod = 13;

        public string Encrypt() {

            int m = message.Length;
            int n = password.Length;
            string EncMessage = "";

            for (int i = 0; i < m; i++)
            {
                int p = password[i % n];
                int c = (message[i] * p) % mod;
                EncMessage += c.ToString() + ",";
            }


            return EncMessage;
        }

        public string Decrypt(int[] cryptMessage) {

            int m = cryptMessage.Length;
            int n = decryptPassword.Length;
            string decryptMessage = "";



            for (int i = 0; i < m; i++)
            {
                int p = decryptPassword[i % n];
                int c = (cryptMessage[i] * p) % mod;
                decryptMessage += c.ToString() + ",";
            }

            return decryptMessage;
        }

        int[] STRING_TO_INTARRAY(string s) {

            int[] intMessage = new int[s.Length];
            char[] charMessage = s.ToCharArray();

            for (int i = 0; i < s.Length; i++)
            {
                
            }
            return intMessage;
        }
    }
}
