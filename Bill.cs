using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _213002_MidQ1
{
    public partial class Bill : Form
    {
        public Bill instance;
        public Bill()
        {
            InitializeComponent();
            instance = this;
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form1.price.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
