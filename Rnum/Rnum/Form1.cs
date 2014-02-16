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
    public partial class rNumForm : Form
    {
        public rNumForm()
        {
            InitializeComponent();
        }

        public static string romanValue {get; set;}
        public static string arabicValue { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
             romanValue = input.Text;
             arabicValue = output.Text;
            
        }

    }
}
