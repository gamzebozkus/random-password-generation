using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sifre_Olusturucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            Random rasgele = new Random();
            string hepsi = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-";
            string sadecekucuk = "abcdefghijklmnopqrstuvwxyz";
            string kucukvebuyuk = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string kucukbuyukrakam = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            int[] kackarakterli = new int[Convert.ToInt32(numericUpDown1.Value)];
            int bayrak = 0;
            if (numericUpDown1.Value > 0)
            {
                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    if (radioButton1.Checked)
                    { 
                        
                        kackarakterli[i] = sadecekucuk[rasgele.Next(0, sadecekucuk.Length)];
                        char karakter = Convert.ToChar(kackarakterli[i]);
                        textBox1.Text += karakter;
                        bayrak++;
                    }
                    else if (radioButton2.Checked)
                    {
                        kackarakterli[i] = kucukvebuyuk[rasgele.Next(0, kucukvebuyuk.Length)];
                        char karakter = Convert.ToChar(kackarakterli[i]);
                        textBox1.Text += karakter;
                        bayrak++;
                    }
                    else if (radioButton3.Checked)
                    {
                        kackarakterli[i] = kucukbuyukrakam[rasgele.Next(0, kucukbuyukrakam.Length)];
                        char karakter = Convert.ToChar(kackarakterli[i]);
                        textBox1.Text += karakter;
                        bayrak++;
                    }
                    else if(radioButton4.Checked)
                    {                   
                        kackarakterli[i] = hepsi[rasgele.Next(0, hepsi.Length)];
                        char karakter = Convert.ToChar(kackarakterli[i]);
                        textBox1.Text += karakter;
                        bayrak++;
                    }
                   
                }
            } 
            else
            {     
                string message = "Lütfen 0'dan farklı bir sayı seçiniz!";
                string title = "Uyarı!";
                MessageBox.Show(message, title, MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);    
            } 
            if (bayrak==0)
            {
                string message = "Lütfen Bir Seçenek İşaretleyin !";
                string title = "Uyarı!";
                MessageBox.Show(message, title, MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
            }
           
           
        }


private void checkBox4_CheckedChanged(object sender, EventArgs e)
{

}

private void checkBox3_CheckedChanged(object sender, EventArgs e)
{

}

private void checkBox1_CheckedChanged(object sender, EventArgs e)
{

}
    }
}
