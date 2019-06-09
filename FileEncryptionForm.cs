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
    public partial class FileEncryptionForm : Form
    {
        string Key = "abc";
        string userkey = "def";

        string message = "eshonjamil";

        string encryptedmessage = "";

        int domain = 199;

        public FileEncryptionForm()
        {
            InitializeComponent();
            
            //select files
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] files = ofd.FileNames;
            }

            //get user key

            //generate systemkey

            Key += userkey;
            
            char[] keychars = Key.ToCharArray();
            char[] messagechars = message.ToCharArray();
            
            /*
            int x = (int)keychars[1];
            int x = char.MinValue;
            button1.Text = x.ToString();
            x = int.MaxValue;
            button1.Text += x.ToString();
            */

            int i = 0;
            foreach (char m in messagechars)
            {
                int x = ((int)m * (int)keychars[2]) % domain;
                encryptedmessage += ((char)x).ToString();
                //encryptedmessage += "," + x.ToString();
                i++;
                if (i == keychars.Length)
                {
                    i = 0;
                }
            }

            button1.Text = encryptedmessage;

            /*

            string s = "";
            char[] encryptedchars = encryptedmessage.ToCharArray();
            i = 0;
            foreach (char e in encryptedchars)
            {
                int x = ((int)e * (int)keychars[i]) % domain;
                Console.WriteLine(i+" "+x);
                s += ((char)x).ToString();
                //s += ";" + x;
                i++;
                if (i == encryptedchars.Length)
                {
                    i = 0;
                }
            }
            button2.Text += "<>" + s;*/
        }
    }
}
