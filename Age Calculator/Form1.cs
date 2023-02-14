namespace Age_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtpCurrentDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if(dtpCurrentDate.Value<dtpDOB.Value)
                {
                    MessageBox.Show("Current Date Must be getter than Date of birth");
                }
                int Age = dtpCurrentDate.Value.Year - dtpDOB.Value.Year;
                if (dtpDOB.Value.AddYears(Age) > dtpCurrentDate.Value)
                    Age--;
                lblAge.Text = "Your Age :" + Age.ToString();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error Information");
            }

        }
    }
}