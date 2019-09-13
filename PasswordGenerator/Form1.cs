using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        private double VersionNumber = 0.5;
        private bool isPasswordLengthOk = true,
                     isPasswordNumberOk = true,
                     isCustomCharSetDefined = true;

        private char[] charSet;

        private readonly Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            Text = $@"Password Generator Beta v{VersionNumber}";
        }

        private void rdbtnDefault_CheckedChanged(object sender, EventArgs e)
        {
            lblEnterCharacters.Enabled = false;
            txtboxCustomCharSet.Enabled = false;
            isCustomCharSetDefined = true;

            UpdateGenerateButton();
        }

        private void rdbtnCustom_CheckedChanged(object sender, EventArgs e)
        {
            lblEnterCharacters.Enabled = true;
            txtboxCustomCharSet.Enabled = true;

            isCustomCharSetDefined = txtboxCustomCharSet.Text.Length > 0;

            UpdateGenerateButton();
        }
        private void txtboxCustomCharSet_TextChanged(object sender, EventArgs e)
        {
            isCustomCharSetDefined = txtboxCustomCharSet.Text.Length > 0;
            UpdateGenerateButton();
        }
        private void TxtboxCustomCharSet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!lblEnterCharacters.Enabled || !txtboxCustomCharSet.Enabled) return;
            isCustomCharSetDefined = txtboxCustomCharSet.Text.Length > 0;
            UpdateGenerateButton();
        }

        private void passwordLengthObj_ValueChanged(object sender, EventArgs e)
        {
            isPasswordLengthOk = (int) passwordLengthObj.Value > 0 && (int) passwordLengthObj.Value <= 256;
            UpdateGenerateButton();
        }
        private void PasswordLengthObj_KeyPress(object sender, KeyPressEventArgs e)
        {
            isPasswordLengthOk = (int) passwordLengthObj.Value > 0 && (int) passwordLengthObj.Value <= 256;
            UpdateGenerateButton();
        }
        
        private void passwordNumObj_ValueChanged(object sender, EventArgs e)
        {
            isPasswordNumberOk = (int) passwordNumObj.Value > 0 && (int) passwordNumObj.Value < short.MaxValue;
            UpdateGenerateButton();
        }
        private void PasswordNumObj_KeyPress(object sender, KeyPressEventArgs e)
        {
            isPasswordNumberOk = (int) passwordNumObj.Value > 0 && (int) passwordNumObj.Value < short.MaxValue;
            UpdateGenerateButton();
        }

        private void UpdateGenerateButton()
        {
            btnGenerate.Enabled = isPasswordLengthOk && isPasswordNumberOk && isCustomCharSetDefined;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Initialize Based Variables
            int charLength = (int)passwordLengthObj.Value,
                amountOfPasswordsToGenerate = (int)passwordNumObj.Value;

            // Initialize Char Set
            if (rdbtnDefault.Checked)
            {
                charSet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890,./;'[]\\-=()<>?:\"{}|_+`~".ToCharArray();
            }
            else if (rdbtnCustom.Checked)
            {
                charSet = RemoveDuplicates(txtboxCustomCharSet.Text).ToCharArray();
            }

            txtboxPasswordList.Text = string.Empty;
            txtboxPasswordList.AppendText("===Start of Password List===" + Environment.NewLine + Environment.NewLine);

            for (ushort i = 0; i < (ushort)amountOfPasswordsToGenerate; i++)
            {
                string password = GenPassword(charLength);
                txtboxPasswordList.AppendText($"Password {i + 1}: {password}" + Environment.NewLine + Environment.NewLine);
            }

            txtboxPasswordList.AppendText(Environment.NewLine + "=== End of Password List ===");
        }

        private string GenPassword(int passwordLength)
        {
            string password = "";
            for (ushort i = 0; i < passwordLength; i++)
                password += charSet[rnd.Next(0, charSet.Length)];
            return password;
        }

        private string RemoveDuplicates(string str)
        {
            string result = string.Empty;
            HashSet<char> charBag = new HashSet<char>();

            for (ushort i = 0; i < str.Length; i++)
                if (charBag.Add(str[i]))
                    result += str[i];

            return result;
        }
    }
}
