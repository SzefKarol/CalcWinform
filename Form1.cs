namespace testcalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnBtnNumberClick(object sender, EventArgs e)
        {
            var clickedValue = (sender as Button).Text;
            tbScreen.Text += clickedValue;
           
        }

        private void OnBtnOperationClick(object sender, EventArgs e)
        {

        }

        private void OnBtnResultClick(object sender, EventArgs e)
        {

        }

        private void tbScreen_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void OnBtnClearClick(object sender, EventArgs e)
        {

        }
    }
}