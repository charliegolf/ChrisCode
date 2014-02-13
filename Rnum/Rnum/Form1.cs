using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rnum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String roman = input.Text;
            int count = 0;
            char[] romanArray = roman.ToCharArray();
            string lastNumber = "";
            for (int i = 0; i < romanArray.Length; i++)
            {
                
                string number = Convert.ToString(romanArray[i]);
                if (number == "I")
                {
                    count += 1;
                    lastNumber = number;
                }

                if (number == "V" && lastNumber == "I")
                {
                    count += 5-2;
                }

                if (number == "V" && lastNumber != "I")
                {
                    count += 5;
                }
                if (number == "X" && lastNumber == "I")
                {
                    count += 10 - 2;
                }

                if (number == "X" && lastNumber != "I")
                {
                    count += 10;
                    lastNumber = number;
                }
                if (number == "L" && lastNumber == "X")
                {
                    count += 50 - 20;
                }

                if (number == "L" && lastNumber != "X")
                {
                    count += 50;
                }
                if (number == "C" && lastNumber == "X")
                {
                    count += 100 - 20;
                }

                if (number == "C" && lastNumber != "X")
                {
                    count += 100;
                    lastNumber = number;

                }
                if (number == "D" && lastNumber == "C")
                {
                    count += 500 - 200;
                }

                if (number == "D" && lastNumber != "C")
                {
                    count += 500;
                }
                if (number == "M" && lastNumber == "C")
                {
                    count += 1000 - 200;
                }

                if (number == "M" && lastNumber != "C")
                {
                    count += 1000;
                    lastNumber = number;
                }


                output.Text = Convert.ToString(count);
                

            }

            
         
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
