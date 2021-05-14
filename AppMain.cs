namespace Bumsoo.Forms
{
    
    public partial class CouncelingClient : Form
    {
        

        public CouncelingClient()
        {
            InitializeComponent();
            timer1.Start();
            



            //if (Login == false)
            //{
            //    SigninPage sip = new SigninPage();
            //    sip.Show();
            //    sip.ShowDialog(this);
                
                

            //}
            
        }

        private void CouncelingClient_Load(object sender, EventArgs e)
        {
            SigninPage sip = new SigninPage();

            DialogResult result = sip.ShowDialog();

            if (result == DialogResult.OK)
            {
                
            }
            else
            {
                MessageBox.Show("로그인에 ");
            }
            
        




        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Timer_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.Timer.Text = dateTime.ToString();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (this.homeToolStrip.Click())
            {

            }


        }
    }
}
