using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionEnabledNotepad
{
    class FileEncryption
    {
        /*
        //F:\pics\Docs\ju-map.jpg
        string path = @"F:\pics\Docs\ju-map.jpg";
        string newPath = @"F:\pics\Docs\encrypted.jpg";

        byte[] buffer = File.ReadAllBytes("F:\\pics\\Docs\\ju-map.jpg");
        File.WriteAllBytes(newPath, buffer);

        using (Stream file = File.OpenWrite(@"c:\path\to\your\file\here.txt")){
        file.Write(fileBytes, 0, fileBytes.Length);}
         */

        private string Key = "abcd";
        private int[] KeyInt;

        public FileEncryption()
        {
            
        }

        public string EncryptFiles(string[] files, string userkey)
        {
            //keygen

            GenerateKeys(userkey);

            //explore files
            foreach (string file in files)
            {
                byte[] byteFile = File.ReadAllBytes(file);
                //File.WriteAllBytes();
            }
            
            //encrypt
            
            return null;
            //return 
        }

        byte[] Encrypt(byte[] message)
        {
            
            return null;
        }

        void GenerateKeys(string userkey)
        {
            Key += userkey;
            KeyInt = new int[Key.Length];

            char[] keychar = Key.ToCharArray();
            foreach (char c in keychar)
            {
                int x = (int)c;

            }
        }

    }
}
