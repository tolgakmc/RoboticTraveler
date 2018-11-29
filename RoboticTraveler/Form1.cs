using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboticTraveler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var dataSource = new List<String>();
            dataSource.Add("N");
            dataSource.Add("E");
            dataSource.Add("S");
            dataSource.Add("W");
            FirstLocCmb.DataSource = dataSource;
            FirstLocCmb.DropDownStyle = ComboBoxStyle.DropDownList;

            var dataSource2 = new List<String>();
            dataSource2.Add("N");
            dataSource2.Add("E");
            dataSource2.Add("S");
            dataSource2.Add("W");
            SecondLocCmb.DataSource = dataSource2;
            SecondLocCmb.DropDownStyle = ComboBoxStyle.DropDownList; 
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (RightCornerXTxt.Text == "" || RightCornerYTxt.Text == "" || FirstLocXTxt.Text == "" || FirstLocYTxt.Text == "" || SecondLocXTxt.Text == "" || SecondLocYTxt.Text == "" || FirstLettersTxt.Text == "" || SecondLettersTxt.Text == "" )
            {
                MessageBox.Show("Lütfen tüm boşlukları doldurunuz!");
            }
            else
            { 
                int x = int.Parse(RightCornerXTxt.Text);
                int y = int.Parse(RightCornerYTxt.Text);

                int Robot1x = int.Parse(FirstLocXTxt.Text);
                int Robot1y = int.Parse(FirstLocYTxt.Text);
                String Robot1dir = FirstLocCmb.Text;
                String Robot1letters = FirstLettersTxt.Text;

                int Robot2x = int.Parse(SecondLocXTxt.Text);
                int Robot2y = int.Parse(SecondLocYTxt.Text);
                String Robot2dir = SecondLocCmb.Text;
                String Robot2letters = SecondLettersTxt.Text;

                Robot robot1 = new Robot(Robot1x, Robot1y, Robot1dir);
                robot1.Move(Robot1letters);
                int x1res, y1res;
                if(robot1.X > x)
                {
                    x1res = x;
                }
                else if(robot1.X >= 0)
                {
                    x1res = robot1.X;
                }
                else
                {
                    x1res = 0;
                }

                if (robot1.Y > y)
                {
                    y1res = y;
                }
                else if (robot1.Y >= 0)
                {
                    y1res = robot1.Y;
                }
                else
                {
                    y1res = 0;
                }
                MessageBox.Show("İlk Robotun Son Konumu: " + x1res + " " + y1res + " " + robot1.DIR);

                Robot robot2 = new Robot(Robot2x, Robot2y, Robot2dir);
                robot2.Move(Robot2letters);
                int x2res, y2res;
                if (robot2.X > x)
                {
                    x2res = x;
                }
                else if (robot2.X >= 0)
                {
                    x2res = robot2.X;
                }
                else
                {
                    x2res = 0;
                }

                if (robot2.Y > y)
                {
                    y2res = y;
                }
                else if (robot2.Y >= 0)
                {
                    y2res = robot2.Y;
                }
                else
                {
                    y2res = 0;
                }
                MessageBox.Show("İkinci Robotun Son Konumu: " + x2res + " " + y2res + " " + robot2.DIR);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void RightCornerXTxt_TextChanged(object sender, EventArgs e)
        {
            NumberControl(RightCornerXTxt);
        }

        private void RightCornerYTxt_TextChanged(object sender, EventArgs e)
        {
            NumberControl(RightCornerYTxt);
        }

        private void FirstLocXTxt_TextChanged(object sender, EventArgs e)
        {
            NumberControl(FirstLocXTxt);
        }

        private void FirstLocYTxt_TextChanged(object sender, EventArgs e)
        {
            NumberControl(FirstLocYTxt);
        }

        private void SecondLocXTxt_TextChanged(object sender, EventArgs e)
        {
            NumberControl(SecondLocXTxt);
        }

        private void SecondLocYTxt_TextChanged(object sender, EventArgs e)
        {
            NumberControl(SecondLocYTxt);
        }

        private void FirstLettersTxt_TextChanged(object sender, EventArgs e)
        {
            LetterControl(FirstLettersTxt);
        }

        private void SecondLettersTxt_TextChanged(object sender, EventArgs e)
        {
            LetterControl(SecondLettersTxt);
        }

        private void NumberControl(TextBox textbox)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textbox.Text, "[^0-9]"))
            {
                MessageBox.Show("Lütfen sadece sayı girişi yapınız!");
                textbox.Text = textbox.Text.Remove(textbox.Text.Length - 1);
            }
        }

        private void LetterControl(TextBox textbox)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textbox.Text, "[^(L|R|M|l|r|m)]"))
            {
                MessageBox.Show("Lütfen sadece 'L', 'R' veya 'M' harflerinden birini kullanın!");
                textbox.Text = textbox.Text.Remove(textbox.Text.Length - 1);
            }
        }
    }
}
