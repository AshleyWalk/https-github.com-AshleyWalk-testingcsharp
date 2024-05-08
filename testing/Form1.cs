namespace testing
{
    public partial class Form1 : Form
    {
        private string input_text;
        private string error_message = "there's an error, please input some text into the text block";

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_inputtextname(object sender, EventArgs e)
        {
            input_text = inputtextname.Text.ToString();

        }

        private void btn_getresult_Click(object sender, EventArgs e)
        {

            
            if (input_text != null)
            {
                MessageBox.Show("Hello, " + input_text);
            }
            else
            {
                MessageBox.Show(error_message);
            }

        }
    }
}