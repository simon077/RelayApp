using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelayApp
{
    public partial class frmDriver : Form
    {
        int numberOfDrivers, driverNumber = 1, driverAge, youngestDriverAge = 200, oldestDriverAge = 16, yearsFromClaim, driverClaims, totalClaims, claimsWithin1Year = 0, claimsWithin2And5Years = 0;
        double premium, premiumBaseline = 500;
        Boolean premiumValid = true;
        string declineMessage, youngestDriverName, oldestDriverName;
        DateTime dtStartDate;
        DateTime today = DateTime.Today;
        Driver[] drivers;


        public frmDriver(NumericUpDown nudNumberOfDrivers, DateTimePicker dtpStartDate)
        {
            this.numberOfDrivers = (int)nudNumberOfDrivers.Value;
            this.dtStartDate = dtpStartDate.Value;
            drivers = new Driver[numberOfDrivers];

            InitializeComponent();

            // Set a max date for date of birth and claim dates relative to the current date
            dtpDateOfBirth.MaxDate = today.AddYears(-17);
            dtpClaim1.MaxDate = today;
            dtpClaim2.MaxDate = today;
            dtpClaim3.MaxDate = today;
            dtpClaim4.MaxDate = today;
            dtpClaim5.MaxDate = today;

            // Enable and show btnNext Driver if necessary
            if(numberOfDrivers > 1)
            {
                btnNextDriver.Enabled = true;
                btnNextDriver.Visible = true;
            }

            // Prevents a next button from showing if there is only 1 driver
            if (driverNumber == numberOfDrivers)
            {
                btnNextDriver.Enabled = false;
                btnNextDriver.Visible = false;
            }

            for(int a = 0; a<numberOfDrivers; a++)
            {
                drivers[a] = new Driver();
            }
    
        }
        
        private void btnPreviousDriver_Click(object sender, EventArgs e)
        {
            lblDriverNumber.Text = "Driver " + (driverNumber - 1);
            if(driverNumber == 2)
            {
                drivers[1].FirstName = tbFirstName.Text;
                drivers[1].Surname = tbSurname.Text;
                drivers[1].Occupation = cbOccupation.Text;
                drivers[1].DateOfBirth = dtpDateOfBirth.Value;
                drivers[1].NumberOfClaims = cbNumberOfClaims.Text;
                drivers[1].Claim1Date = dtpClaim1.Value;
                drivers[1].Claim2Date = dtpClaim2.Value;
                drivers[1].Claim3Date = dtpClaim3.Value;
                drivers[1].Claim4Date = dtpClaim4.Value;
                drivers[1].Claim5Date = dtpClaim5.Value;
                tbFirstName.Text = drivers[0].FirstName;
                tbSurname.Text = drivers[0].Surname;
                cbOccupation.Text = drivers[0].Occupation;
                dtpDateOfBirth.Value = drivers[0].DateOfBirth;
                cbNumberOfClaims.Text = drivers[0].NumberOfClaims;
                dtpClaim1.Value = drivers[0].Claim1Date;
                dtpClaim2.Value = drivers[0].Claim2Date;
                dtpClaim3.Value = drivers[0].Claim3Date;
                dtpClaim4.Value = drivers[0].Claim4Date;
                dtpClaim5.Value = drivers[0].Claim5Date;

                btnPreviousDriver.Enabled = false;
                btnPreviousDriver.Visible = false;
            }
            else if (driverNumber == 3)
            {
                drivers[2].FirstName = tbFirstName.Text;
                drivers[2].Surname = tbSurname.Text;
                drivers[2].Occupation = cbOccupation.Text;
                drivers[2].DateOfBirth = dtpDateOfBirth.Value;
                drivers[2].NumberOfClaims = cbNumberOfClaims.Text;
                drivers[2].Claim1Date = dtpClaim1.Value;
                drivers[2].Claim2Date = dtpClaim2.Value;
                drivers[2].Claim3Date = dtpClaim3.Value;
                drivers[2].Claim4Date = dtpClaim4.Value;
                drivers[2].Claim5Date = dtpClaim5.Value;
                tbFirstName.Text = drivers[1].FirstName;
                tbSurname.Text = drivers[1].Surname;
                cbOccupation.Text = drivers[1].Occupation;
                dtpDateOfBirth.Value = drivers[1].DateOfBirth;
                cbNumberOfClaims.Text = drivers[1].NumberOfClaims;
                dtpClaim1.Value = drivers[1].Claim1Date;
                dtpClaim2.Value = drivers[1].Claim2Date;
                dtpClaim3.Value = drivers[1].Claim3Date;
                dtpClaim4.Value = drivers[1].Claim4Date;
                dtpClaim5.Value = drivers[1].Claim5Date;
            }
            else if (driverNumber == 4)
            {
                drivers[3].FirstName = tbFirstName.Text;
                drivers[3].Surname = tbSurname.Text;
                drivers[3].Occupation = cbOccupation.Text;
                drivers[3].DateOfBirth = dtpDateOfBirth.Value;
                drivers[3].NumberOfClaims = cbNumberOfClaims.Text;
                drivers[3].Claim1Date = dtpClaim1.Value;
                drivers[3].Claim2Date = dtpClaim2.Value;
                drivers[3].Claim3Date = dtpClaim3.Value;
                drivers[3].Claim4Date = dtpClaim4.Value;
                drivers[3].Claim5Date = dtpClaim5.Value;
                tbFirstName.Text = drivers[2].FirstName;
                tbSurname.Text = drivers[2].Surname;
                cbOccupation.Text = drivers[2].Occupation;
                dtpDateOfBirth.Value = drivers[2].DateOfBirth;
                cbNumberOfClaims.Text = drivers[2].NumberOfClaims;
                dtpClaim1.Value = drivers[2].Claim1Date;
                dtpClaim2.Value = drivers[2].Claim2Date;
                dtpClaim3.Value = drivers[2].Claim3Date;
                dtpClaim4.Value = drivers[2].Claim4Date;
                dtpClaim5.Value = drivers[2].Claim5Date;
            }
            else 
            {
                drivers[4].FirstName = tbFirstName.Text;
                drivers[4].Surname = tbSurname.Text;
                drivers[4].Occupation = cbOccupation.Text;
                drivers[4].DateOfBirth = dtpDateOfBirth.Value;
                drivers[4].NumberOfClaims = cbNumberOfClaims.Text;
                drivers[4].Claim1Date = dtpClaim1.Value;
                drivers[4].Claim2Date = dtpClaim2.Value;
                drivers[4].Claim3Date = dtpClaim3.Value;
                drivers[4].Claim4Date = dtpClaim4.Value;
                drivers[4].Claim5Date = dtpClaim5.Value;
                tbFirstName.Text = drivers[3].FirstName;
                tbSurname.Text = drivers[3].Surname;
                cbOccupation.Text = drivers[3].Occupation;
                dtpDateOfBirth.Value = drivers[3].DateOfBirth;
                cbNumberOfClaims.Text = drivers[3].NumberOfClaims;
                dtpClaim1.Value = drivers[3].Claim1Date;
                dtpClaim2.Value = drivers[3].Claim2Date;
                dtpClaim3.Value = drivers[3].Claim3Date;
                dtpClaim4.Value = drivers[3].Claim4Date;
                dtpClaim5.Value = drivers[3].Claim5Date;
            }
            btnNextDriver.Enabled = true;
            btnNextDriver.Visible = true;
            driverNumber--;
        }

        private void btnNextDriver_Click(object sender, EventArgs e)
        {

            lblDriverNumber.Text = "Driver " + (driverNumber + 1);
            if (driverNumber == 1)
            {

                drivers[0].FirstName = tbFirstName.Text;
                drivers[0].Surname = tbSurname.Text;
                drivers[0].Occupation = cbOccupation.Text;
                drivers[0].DateOfBirth = dtpDateOfBirth.Value;
                drivers[0].NumberOfClaims = cbNumberOfClaims.Text;
                drivers[0].Claim1Date = dtpClaim1.Value;
                drivers[0].Claim2Date = dtpClaim2.Value;
                drivers[0].Claim3Date = dtpClaim3.Value;
                drivers[0].Claim4Date = dtpClaim4.Value;
                drivers[0].Claim5Date = dtpClaim5.Value;
                tbFirstName.Text = drivers[1].FirstName;
                tbSurname.Text = drivers[1].Surname;
                cbOccupation.Text = drivers[1].Occupation;
                dtpDateOfBirth.Value = drivers[1].DateOfBirth;
                cbNumberOfClaims.Text = drivers[1].NumberOfClaims;
                dtpClaim1.Value = drivers[1].Claim1Date;
                dtpClaim2.Value = drivers[1].Claim2Date;
                dtpClaim3.Value = drivers[1].Claim3Date;
                dtpClaim4.Value = drivers[1].Claim4Date;
                dtpClaim5.Value = drivers[1].Claim5Date;

                btnPreviousDriver.Enabled = true;
                btnPreviousDriver.Visible = true;

                if (driverNumber == (numberOfDrivers - 1))
                {
                    btnNextDriver.Enabled = false;
                    btnNextDriver.Visible = false;
                }
            }
            else if (driverNumber == 2)
            {
                drivers[1].FirstName = tbFirstName.Text;
                drivers[1].Surname = tbSurname.Text;
                drivers[1].Occupation = cbOccupation.Text;
                drivers[1].DateOfBirth = dtpDateOfBirth.Value;
                drivers[1].NumberOfClaims = cbNumberOfClaims.Text;
                drivers[1].Claim1Date = dtpClaim1.Value;
                drivers[1].Claim2Date = dtpClaim2.Value;
                drivers[1].Claim3Date = dtpClaim3.Value;
                drivers[1].Claim4Date = dtpClaim4.Value;
                drivers[1].Claim5Date = dtpClaim5.Value;
                tbFirstName.Text = drivers[2].FirstName;
                tbSurname.Text = drivers[2].Surname;
                cbOccupation.Text = drivers[2].Occupation;
                dtpDateOfBirth.Value = drivers[2].DateOfBirth;
                cbNumberOfClaims.Text = drivers[2].NumberOfClaims;
                dtpClaim1.Value = drivers[2].Claim1Date;
                dtpClaim2.Value = drivers[2].Claim2Date;
                dtpClaim3.Value = drivers[2].Claim3Date;
                dtpClaim4.Value = drivers[2].Claim4Date;
                dtpClaim5.Value = drivers[2].Claim5Date;

                if (driverNumber == (numberOfDrivers - 1))
                {
                    btnNextDriver.Enabled = false;
                    btnNextDriver.Visible = false;
                }

            }
            else if (driverNumber == 3)
            {
                drivers[2].FirstName = tbFirstName.Text;
                drivers[2].Surname = tbSurname.Text;
                drivers[2].Occupation = cbOccupation.Text;
                drivers[2].DateOfBirth = dtpDateOfBirth.Value;
                drivers[2].NumberOfClaims = cbNumberOfClaims.Text;
                drivers[2].Claim1Date = dtpClaim1.Value;
                drivers[2].Claim2Date = dtpClaim2.Value;
                drivers[2].Claim3Date = dtpClaim3.Value;
                drivers[2].Claim4Date = dtpClaim4.Value;
                drivers[2].Claim5Date = dtpClaim5.Value;
                tbFirstName.Text = drivers[3].FirstName;
                tbSurname.Text = drivers[3].Surname;
                cbOccupation.Text = drivers[3].Occupation;
                dtpDateOfBirth.Value = drivers[3].DateOfBirth;
                cbNumberOfClaims.Text = drivers[3].NumberOfClaims;
                dtpClaim1.Value = drivers[3].Claim1Date;
                dtpClaim2.Value = drivers[3].Claim2Date;
                dtpClaim3.Value = drivers[3].Claim3Date;
                dtpClaim4.Value = drivers[3].Claim4Date;
                dtpClaim5.Value = drivers[3].Claim5Date;

                if (driverNumber == (numberOfDrivers - 1))
                {
                    btnNextDriver.Enabled = false;
                    btnNextDriver.Visible = false;
                }
            }
            else
            {
                drivers[3].FirstName = tbFirstName.Text;
                drivers[3].Surname = tbSurname.Text;
                drivers[3].Occupation = cbOccupation.Text;
                drivers[3].DateOfBirth = dtpDateOfBirth.Value;
                drivers[3].NumberOfClaims = cbNumberOfClaims.Text;
                drivers[3].Claim1Date = dtpClaim1.Value;
                drivers[3].Claim2Date = dtpClaim2.Value;
                drivers[3].Claim3Date = dtpClaim3.Value;
                drivers[3].Claim4Date = dtpClaim4.Value;
                drivers[3].Claim5Date = dtpClaim5.Value;
                tbFirstName.Text = drivers[4].FirstName;
                tbSurname.Text = drivers[4].Surname;
                cbOccupation.Text = drivers[4].Occupation;
                dtpDateOfBirth.Value = drivers[4].DateOfBirth;
                cbNumberOfClaims.Text = drivers[4].NumberOfClaims;
                dtpClaim1.Value = drivers[4].Claim1Date;
                dtpClaim2.Value = drivers[4].Claim2Date;
                dtpClaim3.Value = drivers[4].Claim3Date;
                dtpClaim4.Value = drivers[4].Claim4Date;
                dtpClaim5.Value = drivers[4].Claim5Date;

                btnNextDriver.Enabled = false;
                btnNextDriver.Visible = false;
            }
            driverNumber++;
        }

        private void cbNumberOfClaims_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbNumberOfClaims.Text == "0")
            {
                dtpClaim1.Visible = false;
                dtpClaim1.Value = dtpClaim1.MinDate;
                lblClaim1.Visible = false;
                dtpClaim2.Visible = false;
                dtpClaim2.Value = dtpClaim2.MinDate;
                lblClaim2.Visible = false;
                dtpClaim3.Visible = false;
                dtpClaim3.Value = dtpClaim3.MinDate;
                lblClaim3.Visible = false;
                dtpClaim4.Visible = false;
                dtpClaim4.Value = dtpClaim4.MinDate;
                lblClaim4.Visible = false;
                dtpClaim5.Visible = false;
                dtpClaim5.Value = dtpClaim5.MinDate;
                lblClaim5.Visible = false;
            }
            else if (cbNumberOfClaims.Text == "1")
            {
                dtpClaim1.Visible = true;
                lblClaim1.Visible = true;
                dtpClaim2.Visible = false;
                dtpClaim2.Value = dtpClaim2.MinDate;
                lblClaim2.Visible = false;
                dtpClaim3.Visible = false;
                dtpClaim3.Value = dtpClaim3.MinDate;
                lblClaim3.Visible = false;
                dtpClaim4.Visible = false;
                dtpClaim4.Value = dtpClaim4.MinDate;
                lblClaim4.Visible = false;
                dtpClaim5.Visible = false;
                dtpClaim5.Value = dtpClaim5.MinDate;
                lblClaim5.Visible = false;
            }
            else if (cbNumberOfClaims.Text == "2")
            {
                dtpClaim1.Visible = true;
                lblClaim1.Visible = true;
                dtpClaim2.Visible = true;
                lblClaim2.Visible = true;
                dtpClaim3.Visible = false;
                dtpClaim3.Value = dtpClaim3.MinDate;
                lblClaim3.Visible = false;
                dtpClaim4.Visible = false;
                dtpClaim4.Value = dtpClaim4.MinDate;
                lblClaim4.Visible = false;
                dtpClaim5.Visible = false;
                dtpClaim5.Value = dtpClaim5.MinDate;
                lblClaim5.Visible = false;
            }
            else if (cbNumberOfClaims.Text == "3")
            {
                dtpClaim1.Visible = true;
                lblClaim1.Visible = true;
                dtpClaim2.Visible = true;
                lblClaim2.Visible = true;
                dtpClaim3.Visible = true;
                lblClaim3.Visible = true;
                dtpClaim4.Visible = false;
                dtpClaim4.Value = dtpClaim4.MinDate;
                lblClaim4.Visible = false;
                dtpClaim5.Visible = false;
                dtpClaim5.Value = dtpClaim5.MinDate;
                lblClaim5.Visible = false;
            }
            else if (cbNumberOfClaims.Text == "4")
            {
                dtpClaim1.Visible = true;
                lblClaim1.Visible = true;
                dtpClaim2.Visible = true;
                lblClaim2.Visible = true;
                dtpClaim3.Visible = true;
                lblClaim3.Visible = true;
                dtpClaim4.Visible = true;
                lblClaim4.Visible = true;
                dtpClaim5.Visible = false;
                dtpClaim5.Value = dtpClaim5.MinDate;
                lblClaim5.Visible = false;
            }
            else
            {
                dtpClaim1.Visible = true;
                lblClaim1.Visible = true;
                dtpClaim2.Visible = true;
                lblClaim2.Visible = true;
                dtpClaim3.Visible = true;
                lblClaim3.Visible = true;
                dtpClaim4.Visible = true;
                lblClaim4.Visible = true;
                dtpClaim5.Visible = true;
                lblClaim5.Visible = true;
            }
        }

        private void tbFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tbSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void btnPremium_Click(object sender, EventArgs e)
        {
            premium = premiumBaseline;

            // Save variables on the current form
            drivers[driverNumber - 1].FirstName = tbFirstName.Text;
            drivers[driverNumber - 1].Surname = tbSurname.Text;
            drivers[driverNumber - 1].Occupation = cbOccupation.Text;
            drivers[driverNumber - 1].DateOfBirth = dtpDateOfBirth.Value;
            drivers[driverNumber - 1].NumberOfClaims = cbNumberOfClaims.Text;
            drivers[driverNumber - 1].Claim1Date = dtpClaim1.Value;
            drivers[driverNumber - 1].Claim2Date = dtpClaim2.Value;
            drivers[driverNumber - 1].Claim3Date = dtpClaim3.Value;
            drivers[driverNumber - 1].Claim4Date = dtpClaim4.Value;
            drivers[driverNumber - 1].Claim5Date = dtpClaim5.Value;


            for (int a = 0; a < numberOfDrivers; a++ )
            {
                if(drivers[a].FirstName == "" || drivers[a].Surname == "" || drivers[a].Occupation == "" || drivers[a].DateOfBirth == dtpDateOfBirth.MinDate)
                {
                    MessageBox.Show("Please complete the form by filling in all of the values");
                    return;
                }

                
            }



            for (int a = 0; a < numberOfDrivers; a++)
            {
                if (drivers[a].Occupation == "Chauffeur")
                {
                    premium = premium * 1.1;
                    a = numberOfDrivers;
                }
            }
            
            //Driver age is to be calculated from the start date of the policy
            for (int a = 0; a < numberOfDrivers; a++)
            {
                driverAge = dtStartDate.Year - drivers[a].DateOfBirth.Year;
                if (drivers[a].DateOfBirth > dtStartDate) 
                {
                    driverAge--;
                }

                //Setting youngestDriverAge and youngestDriverName to the youngest person
                if (youngestDriverAge > driverAge) 
                {
                    youngestDriverAge = driverAge;
                    youngestDriverName = drivers[a].FirstName + " " + drivers[a].Surname;
                }

                //Setting oldestDriverAge and oldestDriverName to the oldest person
                if(oldestDriverAge < driverAge)
                {
                    oldestDriverAge = driverAge;
                    oldestDriverName = drivers[a].FirstName + " " + drivers[a].Surname;
                }
                

            }
            if (youngestDriverAge >= 21 && youngestDriverAge <= 25)
            {
                premium = premium * 1.2;
            }
            else if (youngestDriverAge >= 26 && youngestDriverAge <= 75)
            {
                premium = premium * 0.9;
            }

            // Calculate the number of claims made within 1 year and made within 2-5 years of the Start Date 
            // As the default value for dates of claims is outside the effected range of values, any unmodified fields will not effect the calculation
            for (int a = 0; a < numberOfDrivers; a++)
            {
                yearsFromClaim = dtStartDate.Year - drivers[a].Claim1Date.Year;
                if (drivers[a].Claim1Date < dtStartDate.AddYears(-yearsFromClaim))
                {
                    yearsFromClaim++;
                }
                if (yearsFromClaim <= 1)
                {
                    claimsWithin1Year++;
                }
                else if (yearsFromClaim >= 2 && yearsFromClaim <= 5)
                {
                    claimsWithin2And5Years++;
                }

                yearsFromClaim = dtStartDate.Year - drivers[a].Claim2Date.Year;
                if (drivers[a].Claim2Date < dtStartDate.AddYears(-yearsFromClaim))
                {
                    yearsFromClaim++;
                }
                if (yearsFromClaim <= 1)
                {
                    claimsWithin1Year++;
                }
                else if (yearsFromClaim >= 2 && yearsFromClaim <= 5)
                {
                    claimsWithin2And5Years++;
                }

                yearsFromClaim = dtStartDate.Year - drivers[a].Claim3Date.Year;
                if (drivers[a].Claim3Date < dtStartDate.AddYears(-yearsFromClaim))
                {
                    yearsFromClaim++;
                }
                if (yearsFromClaim <= 1)
                {
                    claimsWithin1Year++;
                }
                else if (yearsFromClaim >= 2 && yearsFromClaim <= 5)
                {
                    claimsWithin2And5Years++;
                }

                yearsFromClaim = dtStartDate.Year - drivers[a].Claim4Date.Year;
                if (drivers[a].Claim4Date < dtStartDate.AddYears(-yearsFromClaim))
                {
                    yearsFromClaim++;
                }
                if (yearsFromClaim <= 1)
                {
                    claimsWithin1Year++;
                }
                else if (yearsFromClaim >= 2 && yearsFromClaim <= 5)
                {
                    claimsWithin2And5Years++;
                }

                yearsFromClaim = dtStartDate.Year - drivers[a].Claim5Date.Year;
                if (drivers[a].Claim5Date < dtStartDate.AddYears(-yearsFromClaim))
                {
                    yearsFromClaim++;
                }
                if (yearsFromClaim <= 1)
                {
                    claimsWithin1Year++;
                }
                else if (yearsFromClaim >= 2 && yearsFromClaim <= 5)
                {
                    claimsWithin2And5Years++;
                }
            }
            premium = premium * (1.0 + 0.2 * claimsWithin1Year + 0.1 * claimsWithin2And5Years);

            if(dtStartDate < today)
            {
                premiumValid = false;
                declineMessage = "Start Date of Policy ";
            }
            else if(youngestDriverAge < 21)
            {
                premiumValid = false;
                if (declineMessage != "")
                {
                    declineMessage += "\nAge of Youngest Driver - " + youngestDriverName + ", " + youngestDriverAge;
                }
                else
                {
                    declineMessage = "Age of Youngest Driver - " + youngestDriverName + ", " + youngestDriverAge;
                }
            }
            else if(oldestDriverAge > 75)
            {
                premiumValid = false;
                if(declineMessage != "")
                {
                    declineMessage += "\nAge of Oldest Driver - " + oldestDriverName + ", " + oldestDriverAge;
                }
                else
                {
                    declineMessage += "Age of Oldest Driver - " + oldestDriverName + ", " + oldestDriverAge;
                }
            }
            for(int a = 0; a < numberOfDrivers; a++)
            {
                if(int.Parse(drivers[a].NumberOfClaims) > 2)
                {
                    premiumValid = false;
                    if (declineMessage != "")
                    {
                        declineMessage += "\nDriver has more than 2 claims - " + drivers[a].FirstName + " " + drivers[a].Surname;
                    }
                    else
                    {
                        declineMessage = "Driver has more than 2 claims - " + drivers[a].FirstName + " " + drivers[a].Surname;
                    }
                }

                totalClaims = totalClaims + int.Parse(drivers[a].NumberOfClaims);
            }
            if (totalClaims > 3)
            {
                premiumValid = false;
                if (declineMessage != "")
                {
                    declineMessage += "\nPolicy has more than 3 claims";
                }
                else
                {
                    declineMessage = "Policy has more than 3 claims";
                }
            }

            if(premiumValid == false)
            {
                MessageBox.Show("You do not qualify for an insurance premium with this company\n" + declineMessage, "Request denied");
                Application.Restart();
            }
            else
            {
                MessageBox.Show("You have qualified for an insurance premium with our company.\nOur rate is £" + premium, "Good News!");
            }
            

            MessageBox.Show("Premium Valid: " + premiumValid + "\nPremium: " + premium + "\nYoungest Driver Name/Age: " + youngestDriverName + ", " + youngestDriverAge + "\nOldest Driver Name/Age: " + oldestDriverName + ", " + oldestDriverAge + "\nClaims within 2-5 years: " + claimsWithin2And5Years + "\nClaims within 1 Year: " + claimsWithin1Year);
  
            DialogResult result1 = MessageBox.Show("Would you like to exit the application?", "", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}

