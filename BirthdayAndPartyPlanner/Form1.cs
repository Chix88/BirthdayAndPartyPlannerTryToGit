using System;
using System.Windows.Forms;

namespace BirthdayAndPartyPlanner
{
    public partial class Form1 : Form
    {
        BirthdayParty birthdayParty;
        DinnerParty dinnerParty;

        public Form1()
        {
            InitializeComponent();
            birthdayParty = new BirthdayParty((int)numericUpDown1.Value, checkBox1.Checked, textBox3.Text);
            dinnerParty = new DinnerParty((int)numericUpDown2.Value, fancyDecCheckBox.Checked, healthyFoodCheckBox.Checked);
        }



        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown2.Value;
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            textBox1.Text = dinnerParty.Cost.ToString();
        }

        private void FancyDecCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            dinnerParty.FancyDecoration = fancyDecCheckBox.Checked;
            DisplayDinnerPartyCost();
        }

        private void HealthyFoodCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = healthyFoodCheckBox.Checked;
            DisplayDinnerPartyCost();
        }

        private void NumericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numericUpDown1.Value;
            textBox2.Text = birthdayParty.Cost().ToString();
        }

        private void CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            birthdayParty.FancyDecoration = checkBox1.Checked;
            textBox2.Text = birthdayParty.Cost().ToString();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = textBox3.Text;
            textBox2.Text = birthdayParty.Cost().ToString();
            if (birthdayParty.IsCakeWritingTooLong)
            {
                label6.Text = "TOO LONG";
            }
            else
                label6.Text = "";
        }
    }
}
