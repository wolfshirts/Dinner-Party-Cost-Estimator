using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinner_Party_Cost_Estimator
{
    public partial class Form1 : Form
    {
        private DinnerParty dinnerParty;
        BirthdayParty birthdayParty; //don't actually need private things are private by default.

        public Form1()
        {
            InitializeComponent();

            dinnerParty = new DinnerParty((int)numberOfPeopleControl.Value, 
                healthyCheckBox.Checked, fancyDecorationCheckBox.Checked);


            UpdateCost();

            birthdayParty = new BirthdayParty((int)birthdayPeopleControl.Value, birthdayFancyDecorationControl.Checked,
                cakeWritingTextBox.Text);

            DisplayBirthdayPartyCost();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numberOfPeopleControl.Value;
            UpdateCost();
        }

        private void healthyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = healthyCheckBox.Checked;
            UpdateCost();
        }

        private void fancyDecorationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = fancyDecorationCheckBox.Checked;
            UpdateCost();
        }

        private void UpdateCost()
        {
            costLabel.Text = dinnerParty.Cost.ToString("c");
        }

        private void DisplayBirthdayPartyCost()
        {
            tooLongLabel.Visible = birthdayParty.CakeWritingTooLong;
            birthdayCostLabel.Text = birthdayParty.Cost.ToString("c");
        }

        private void birthdayPeopleControl_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)birthdayPeopleControl.Value;
            DisplayBirthdayPartyCost();
        }

        private void birthdayFancyDecorationControl_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = birthdayFancyDecorationControl.Checked;
            DisplayBirthdayPartyCost();
        }

        private void cakeWritingTextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = cakeWritingTextBox.Text;
            DisplayBirthdayPartyCost();
        }
    }
}
