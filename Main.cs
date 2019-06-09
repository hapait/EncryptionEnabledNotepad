using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionEnabledNotepad
{
    public partial class Main : Form
    {
        FileEncryption fileEncryptor = new FileEncryption();
        public Main()
        {
            InitializeComponent();

            //VigenereMultiplicative v = new VigenereMultiplicative();
            //string s = v.Encrypt();
            //TextBox_input.Text = s;
        }

        private void Button_PersonalEncryption_Click(object sender, EventArgs e)
        {

        }

        private void FileEncryptionButton_Click(object sender, EventArgs e)
        {

            //encryption();
            //fileread();
            
            //FileEncryptionForm f = new FileEncryptionForm();
            //f.Show();

            /*
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] path = ofd.FileNames;
                //Button_PersonalEncryption.Text = path[0];
            }*/
        }

        private void encryption()
        {
            string key = "abc";
            string password = "def";
            key += password;
            string message = "ejsahmoiln";

            int[] keynum = new int[key.Length];
            int[] messagenum = new int[message.Length];

            char[] keychar = key.ToCharArray();
            int i = 0;
            //Console.WriteLine("k    m    k+m ");
            Console.WriteLine(Byte.MaxValue +" "+ Byte.MinValue);
            foreach (char m in message)
            {
                int x = (int)m;
                try
                {
                    //Console.WriteLine(keychar[i] + "  " + x);
                    i++;
                    if (i == keychar.Length)
                    {
                        i = 0;
                    }
                }
                catch (Exception e)
                {

                }
                
            }
        }

        private void fileread()
        {
            string path = "F:\\pics\\ara-ne-olursun-call-me-please.png";
            string writePath = "F:\\pics\\test.png";
            byte[] bitefile = File.ReadAllBytes(path);
            string text = File.ReadAllText(path);

            File.WriteAllBytes("F:\\pics\\bytetest.png", bitefile);
            
            Console.WriteLine(bitefile.Length+" "+ text.Length);
        }
    }
}
