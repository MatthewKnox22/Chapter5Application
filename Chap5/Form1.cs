namespace Chap5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxDistance_TextChanged(object sender, EventArgs e)
        {
            string distance = textBoxDistance.Text;

        }

        private void textBoxTime_TextChanged(object sender, EventArgs e)
        {
            string time = textBoxTime.Text;

            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int miles = int.Parse(textBoxDistance.Text);
            int hours = int.Parse(textBoxTime.Text);
            int cycles = 1;
            
            while(cycles <= hours)
            {
                listBox1.Items.Add("After hour " + cycles + " the distance is " + (miles * cycles) + ".");
                cycles+=1;

            }


        }
    }
}