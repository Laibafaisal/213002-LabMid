using System.Security.Cryptography.X509Certificates;

namespace _213002_MidQ1
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public static decimal price;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                int p1 = int.Parse(label6.Text);
                decimal t1 = p1 * numericUpDown1.Value;
                price += t1;
            }
            if (checkBox2.Checked)
            {
                int p2 = int.Parse(label7.Text);
                decimal t2 = p2 * numericUpDown2.Value;
                price += t2;

            }
            if (checkBox3.Checked)
            {
                int p3 = int.Parse(label8.Text);
                decimal t3 = p3 * numericUpDown3.Value;
                price += t3;
                
            }
            if (checkBox4.Checked)
            {
                int p4 = int.Parse(label9.Text);
                decimal t4 = p4 * numericUpDown4.Value;
                price += t4;
                //price += int.Parse(label9.Text);
            }
            if (checkBox5.Checked)
            {
                int p5 = int.Parse(label10.Text);
                decimal t5 = p5 * numericUpDown5.Value;
                price += t5;
                //price += int.Parse(label10.Text);
            }

            if (checkBox6.Checked)
            {
                int p6 = int.Parse(label11.Text);
                decimal t6 = p6 * numericUpDown6.Value;
                price += t6;
                price += int.Parse(label11.Text);
            }
            if (checkBox7.Checked)
            {
                int p7 = int.Parse(label12.Text);
                decimal t7 = p7 * numericUpDown7.Value;
                price += t7;
                //price += int.Parse(label12.Text);
            }
            if (checkBox8.Checked)
            {
                int p8 = int.Parse(label13.Text);
                decimal t8 = p8 * numericUpDown8.Value;
                price += t8;
               // price += int.Parse(label13.Text);
            }
            if (checkBox9.Checked)
            {
                int p9 = int.Parse(label14.Text);
                decimal t9 = p9 * numericUpDown9.Value;
                price += t9;
                //price += int.Parse(label14.Text);
            }
            if (checkBox10.Checked)
            {
                int p10 = int.Parse(label15.Text);
                decimal t10 = p10 * numericUpDown10.Value;
                price += t10;
                //price += int.Parse(label15.Text);
            }

            if (checkBox11.Checked)
            {
                int p11 = int.Parse(label21.Text);
                decimal t11= p11 * numericUpDown11.Value;
                price += t11;
                //price += int.Parse(label21.Text);
            }
            if (checkBox12.Checked)
            {
                int p12 = int.Parse(label17.Text);
                decimal t12 = p12 * numericUpDown12.Value;
                price += t12;
                //price += int.Parse(label17.Text);
            }
            if (checkBox13.Checked)
            {
                int p13 = int.Parse(label18.Text);
                decimal t13 = p13 * numericUpDown13.Value;
                price += t13;
                //price += int.Parse(label18.Text);
            }
            if (checkBox14.Checked)
            {
                int p14 = int.Parse(label19.Text);
                decimal t14 = p14 * numericUpDown14.Value;
                price += t14;
                //price += int.Parse(label19.Text);
            }
            if (checkBox15.Checked)
            {
                int p15 = int.Parse(label20.Text);
                decimal t15 = p15 * numericUpDown15.Value;
                price += t15;
                //price += int.Parse(label20.Text);
            }
            Bill obj = new Bill();
            obj.Show();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            /*QuantityInput q = new QuantityInput();
            q.Show();*/
        }
    }
}