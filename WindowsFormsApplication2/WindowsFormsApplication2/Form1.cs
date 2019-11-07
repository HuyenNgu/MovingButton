using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(txtWeight.Text);
            double height = Convert.ToDouble(txtHeight.Text);
            double BMI = weight / (height/100 * height/100);
            this.txtBMI.Text = BMI.ToString();
            
            if(BMI < 10 )
            {
                MessageBox.Show("Are you a Human?");
            }
            if(BMI < 18.5)
            {
                MessageBox.Show("You're thin");
            }
            if(18.5 < BMI && BMI < 24.9)
            {
                MessageBox.Show("You're normal");
            }
            if(25 <BMI && BMI< 29.9)
            {
                MessageBox.Show("Code này không có sai gì nha OWO");
            }
            if(30.0 < BMI && BMI < 34.9)
            {
                MessageBox.Show("You're fat");
            }
            if(35.0 < BMI && BMI < 39.9)
            {
                MessageBox.Show("You're VERY FAT");
            }
            if(BMI > 40 && BMI < 50)
            {
                MessageBox.Show("You're SO FUCKING FATTTT!!!!!");
            }
            if (BMI > 50 && BMI < 10000000)
            {
                MessageBox.Show("ngừng test đi dm");
            }
        }


  
        
        
    }
}
