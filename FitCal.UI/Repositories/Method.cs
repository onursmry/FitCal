using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FitCal.UI.Repositories
{
    public class Method
    {
        //Check for empty textboxes in groupbox
        public static bool CheckIfBlankField(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(item.Text))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //Clear all textboxes in groupbox
        public static void ClearAllTextBoxes(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
            }
        }

        //Refresh listbox with new data from database generic list
        public static void RefreshListBox<T>(ListBox listBox, List<T> list)
        {
            listBox.DataSource = null;
            listBox.DataSource = list;
        }

        //refresh datagridview with new data from database generic list
        public static void RefreshDataGridView<T>(DataGridView dataGridView, List<T> list)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = list;
        }

        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        public static System.Drawing.Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (var ms = new System.IO.MemoryStream(byteArrayIn))
            {
                return System.Drawing.Image.FromStream(ms);
            }
        }

        //check for UpperCase letter
        public static bool CheckForUpperCase(string sifre)
        {
            int count = 0;
            foreach (char item in sifre)
            {
                if (char.IsUpper(item))
                {
                    count++;
                }
            }
            
            //Count can be set to desired number
            if (count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //check for LowerCase letter
        public static bool CheckForLowerCase(string sifre)
        {
            int count = 0;
            foreach (char item in sifre)
            {
                if (char.IsLower(item))
                {
                    count++;
                }
            }

            //Count can be set to desired number
            if (count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //check for special character
        public static bool CheckForSpecialCharacter(string sifre)
        {
            string specialCharacters = "!@#$%^&*()_+{}|:<>?-=[];',./";
            int count = 0;
            foreach (char item in sifre)
            {
                if (specialCharacters.Contains(item))
                {
                    count++;
                }
            }

            //Count can be set to desired number
            if (count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //encrypt password
        public static string Encrypt(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

        //check for email format
        public static bool IsValidEmail(string email)
        {
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase);
            return emailRegex.IsMatch(email);
        }
    }
}