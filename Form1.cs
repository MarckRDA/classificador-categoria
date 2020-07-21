using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassifierCategory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtLastBDay_Enter(object sender, EventArgs e)
        {
            if(txtYearBorn.Text.Trim().Length < 4)
            {
                MessageBox.Show("Warning!! The year of born must have 4 digits", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var yearBorn = Convert.ToInt32(txtYearBorn.Text);
            var yearLastBDay = Convert.ToInt32(txtLastBDay.Text);
            var age = yearLastBDay - yearBorn; 

            if(age >= 5 && age <= 7)
            {
                txtCategory.Text = "Infantil A";
            }
            else if(age >= 8 && age <= 10)
            {
                txtCategory.Text = "Infantil B";
            }
            else if(age >= 11 && age <= 13)
            {
                txtCategory.Text = "Juvenil A";
            }
            else if(age <= 14 && age <= 17)
            {
                txtCategory.Text = "Juvenil B";
            }
            else
            {
                txtCategory.Text = "Adulto";
            }
         
        }
    }
}
