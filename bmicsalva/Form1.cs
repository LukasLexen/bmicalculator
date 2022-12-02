using Calculations;
using System.Diagnostics;
using System.Security.AccessControl;

namespace bmicsalva
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }

        Calc calc = new Calc();
        public float height;
        public float weight;

        private void WeightTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
  
           
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            if (float.TryParse(HeightTextBox.Text, out height))
            {
                calc.height = height;
            }
            if (float.TryParse(WeightTextBox.Text, out weight))
            {
                calc.weight = weight;
            }
            

            BmiOutputBox.Text = calc.CalculateBmi().ToString();
        }

        private void BmiOutputBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void BmiCalculator_(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click_1(object sender, EventArgs e)
        {
        }
    }
}
