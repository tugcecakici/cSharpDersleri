using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo
{
    public partial class Form1 : Form
    {
        public Form1() //bu alana constructor deniyor. void falan yazmıyor.
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //button class'tır. yanındaki görselden de görülebilir.
            Button[,] buttons = new Button[8,8];
            int top=0;
            int left=0;

            for (int i = 0; i < buttons.GetUpperBound(0); i++) //0. satırın en üst değeri
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++) //i = 0'ken j= 0, sonra sıfırıncı satırın 1. sütunu gibi artarak bütün sütunları dolaşır.
                {
                    buttons[i,j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i,j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i,j].Top = top;
                    left +=50;

                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i,j].BackColor = Color.White;
                    }

                    this.Controls.Add(buttons[i,j]);
                }
                left = 0;
                top += 50; //döngü ilk satırı tamamladıktan sonra tekrar buraya girerek top 50 artacak, 2.döngü tamamlanınca top 100 artacak gibi.
               
            }
            //this.Controls.Add(button); //ekrana koy bunu demek
            //button.Width = 50; buton ölçüleri belirlenir.
            //button.Height = 50;
            
        }
    }
}
