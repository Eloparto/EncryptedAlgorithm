using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptedAlgorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txbText_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string text = txbText.Text.ToUpper();
            string encrypted = null;

            Random randomNumber = new Random();

            for (int i = 0; i < text.Length; i++)
            {
                 encrypted += randomNumber.Next(100,120).ToString();
                switch (text[i])
                {
                    case 'A':
                        encrypted+=121;
                        break;
                    case 'B':
                        encrypted += 122;
                        break;
                    case 'C':
                        encrypted += 123;
                        break;
                    case 'Ç':
                        encrypted += 124;
                        break;
                    case 'D':
                        encrypted += 125;
                        break;
                    case 'E':
                        encrypted += 126;
                        break;
                    case 'F':
                        encrypted += 127;
                        break;
                    case 'G':
                        encrypted += 128;
                        break;
                    case 'Ğ':
                        encrypted += 129;
                        break;
                    case 'H':
                        encrypted += 130;
                        break;
                    case 'İ':
                        encrypted += 131;
                        break;
                    case 'I':
                        encrypted += 132;
                        break;
                    case 'J':
                        encrypted += 133;
                        break;
                    case 'K':
                        encrypted += 134;
                        break;
                    case 'L':
                        encrypted += 135;
                        break;
                    case 'M':
                        encrypted += 136;
                        break;
                    case 'N':
                        encrypted += 137;
                        break;
                    case 'O':
                        encrypted += 138;
                        break;
                    case 'Ö':
                        encrypted += 139;
                        break;
                    case 'P':
                        encrypted += 140;
                        break;
                    case 'R':
                        encrypted += 141;
                        break;
                    case 'S':
                        encrypted += 142;
                        break;
                    case 'Ş':
                        encrypted += 143;
                        break;
                    case 'T':
                        encrypted += 144;
                        break;
                    case 'U':
                        encrypted += 145;
                        break;
                    case 'Ü':
                        encrypted += 146;
                        break;
                    case 'V':
                        encrypted += 147;
                        break;
                    case 'Y':
                        encrypted += 148;
                        break;
                    case 'Z':
                        encrypted += 149;
                        break;
                    case 'X':
                        encrypted += 150;
                        break;
                    case 'W':
                        encrypted += 151;
                        break;
                    default:
                        encrypted += 999;
                        break;
                }
            }

            txbEncrypted.Text = encrypted;
        }

        private void btnConvertText_Click(object sender, EventArgs e)
        {
            string encrypted = txbEncrypted.Text;
            string text = null;
            string temp = null;
            for (int i = 3; i < encrypted.Length; i+=3)
            {
                for (int j = i; j < encrypted.Length; j++)
                {
                    temp += encrypted[j];
                    if (temp.Length==3 || j<=3)
                    {
                        int x = Convert.ToInt32(temp);
                        switch (x)
                        {
                            case 121:
                                text += 'A';
                                break;
                            case 122:
                                text += 'B';
                                break;
                            case 123:
                                text += 'C';
                                break;
                            case 124:
                                text += 'Ç';
                                break;
                            case 125:
                                text += 'D';
                                break;
                            case 126:
                                text += 'E';
                                break;
                            case 127:
                                text += 'F';
                                break;
                            case 128:
                                text += 'G';
                                break;
                            case 129:
                                text += 'Ğ';
                                break;
                            case 130:
                                text += 'H';
                                break;
                            case 131:
                                text += 'İ';
                                break;
                            case 132:
                                text += 'I';
                                break;
                            case 133:
                                text += 'J';
                                break;
                            case 134:
                                text += 'K';
                                break;
                            case 135:
                                text += 'L';
                                break;
                            case 136:
                                text += 'M';
                                break;
                            case 137:
                                text += 'N';
                                break;
                            case 138:
                                text += 'O';
                                break;
                            case 139:
                                text += 'Ö';
                                break;
                            case 140:
                                text += 'P';
                                break;
                            case 141:
                                text += 'R';
                                break;
                            case 142:
                                text += 'S';
                                break;
                            case 143:
                                text += 'Ş';
                                break;
                            case 144:
                                text += 'T';
                                break;
                            case 145:
                                text += 'U';
                                break;
                            case 146:
                                text += 'Ü';
                                break;
                            case 147:
                                text += 'V';
                                break;
                            case 148:
                                text += 'Y';
                                break;
                            case 149:
                                text += 'Z';
                                break;
                            case 150:
                                text += 'X';
                                break;
                            case 151:
                                text += 'W';
                                break;
                            case 999:
                                text += " ";
                                break;
                            default:
                                break;
                        }
                    }
                }
                temp = null;
            }

            txbText.Text = text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txbText.Clear();
        }

        private void btnClearEncrypted_Click(object sender, EventArgs e)
        {
            txbEncrypted.Clear();
        }
    }
}
