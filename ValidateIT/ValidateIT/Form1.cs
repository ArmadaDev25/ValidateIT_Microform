using System.Runtime.Serialization;

namespace ValidateIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Stores the user input
                string sUserInput = inptBox.Text;
                // Code that Triggers the not a valid integer exception when a non integer is inputted
                // Triggers a FormatException
                // If the input is a valid integer, then the inputted value will be stored as an int
                int iUserInput = Int32.Parse(sUserInput);
                // Code that divides a number by the inputted integer
                // Triggers a DivideByZero exception if the number is 0
                int checkNum = 10 / iUserInput;
                // For loop that generates an amount of random numbers based on what the user inputs
                for (int i = 0; i < iUserInput; i++)
                {
                    // Stores the generated random number
                    int generatedNumber = generateRandomNumber();
                    // Checks to see if the number is greater than 10
                    if (generatedNumber < 10)
                    {
                        // Adds the generated number to the logbox, if the number is not greater than 10
                        logBox.Items.Add(generatedNumber.ToString());

                    }
                    // Spits out an error if the number is greater than 10
                    else
                    {
                        logBox.Items.Add("Error, Bad Data " + generatedNumber.ToString() + " is greater than 10");

                    }


                }
            }
            // If an error is encountered, the error is logged in the logbox
            // Handles the FormatException for impropper input
            catch (FormatException formatErr)
            {
                logBox.Items.Add("Data Input Invalid");
                logBox.Items.Add(formatErr);
            }
            // Handles the DivideByZero Exception
            catch (DivideByZeroException divideZeroErr)
            {
                logBox.Items.Add("Data Input Invalid");
                logBox.Items.Add(divideZeroErr);
            }
            // Handles all other exceptions
            catch (Exception err)
            {
                // Adds the logbox
                logBox.Items.Add(err);

            }
            




        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        // Function that Generates a random number
        int generateRandomNumber()
        {
            Random ran = new Random();
            // Generates a number between 0 and 20
            int numRandom = ran.Next(0, 20);
            // Returns the random number as a output for this funtion
            return numRandom;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
