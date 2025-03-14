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
            try { 
            // Stores the user input
            string sUserInput = inptBox.Text;
            int iUserInput = Int32.Parse(sUserInput);
            for (int i = 0; i <= iUserInput; i++)
            {
                int generatedNumber = generateRandomNumber();
                logBox.Items.Add(generatedNumber.ToString());
            }
            }
            // If an error is encountered, the error is logged in the logbox
            catch (Exception err) {
                logBox.Items.Add(err);
            
            }




        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        // Function that Generates a random number
        int generateRandomNumber() {
            Random ran = new Random();
            // Generates a number between 0 and 20
            int numRandom = ran.Next(0, 20);
            // Returns the random number as a output for this funtion
            return numRandom;
        }
    }
}
