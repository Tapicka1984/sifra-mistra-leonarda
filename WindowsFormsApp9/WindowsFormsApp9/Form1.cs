using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           try
            {
                int čislo = (int)numericUpDown1.Value;
                string words = textBox2.Text;
                char[] words2 = words.ToCharArray();
                string pismena = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";
                char[] abeceda = pismena.ToCharArray();

                int length = words.Length;
                char[] finalnipodoba = new char[length];
                int x = 0;

                foreach (char i in words2)
                {
                    if((i >97)&&(i<122))
                    {
                        int Index = Array.IndexOf(abeceda, i);
                        finalnipodoba[x] = pismena[((Index + čislo) % pismena.Length)];
                    }
                    else
                    {
                        finalnipodoba[x] = i; 
                    }
                    x++;
                }
                string final = new string(finalnipodoba);
                MessageBox.Show("zašifrovaná zpráva je:" + final);
            }
            catch (Exception ex)
            {
                MessageBox.Show("problem");
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int čislo = (int)numericUpDown2.Value;
                string words = textBox1.Text;
                char[] words2 = words.ToCharArray();
                string pismena = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";
                char[] abeceda = pismena.ToCharArray();

                int length = words.Length;
                char[] finalnipodoba = new char[length];
                int x = 0;

                foreach (char i in words2)
                {
                    if ((i > 97) && (i < 122))
                    {
                        int Index = Array.IndexOf(abeceda, i);
                        int Index2 = Math.Abs(Index - čislo) % pismena.Length;
                        finalnipodoba[x] = pismena[Index2];
                    }
                    else
                    {
                        finalnipodoba[x] = i;
                    }
                    x++;
                }
                string final = new string(finalnipodoba);
                MessageBox.Show("zašifrovaná zpráva je:" + final);
            }
            catch (Exception ex)
            {
                MessageBox.Show("problem");
            }
        }
    }
}
