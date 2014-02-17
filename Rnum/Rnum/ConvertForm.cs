using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RomanNumeralConverter;



namespace Rnum
{
    public partial class convertForm : Form
    {
        public convertForm()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            Converter thisconverter = new Converter();
            thisconverter.roman = romanInput.Text;
            thisconverter.CalculateValue();
            arabicOutput.Text = thisconverter.output;
        }

     }
}
