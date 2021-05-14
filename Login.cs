namespace Bumsoo
{
    public partial class SigninPage : Form
    {
        public SigninPage()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string AdminId = UserId.Text;
            string AdminPw = UserPassword.Text;
            

            if (EmptyCheck() == true)
            {
                if (LoginCheck() == true)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Hide();
                }

            }
            
            
        }

        private bool EmptyCheck()
        {
            if (String.IsNullOrEmpty(UserId.Text))
            {
                MessageBox.Show();
                UserId.Focus();
                return false;
            }


            else if (String.IsNullOrEmpty(UserPassword.Text))
            {
                MessageBox.Show();
                UserPassword.Focus();
                return false;
            }


            //else if (String.IsNullOrEmpty(UserId.Text) && String.IsNullOrEmpty(UserPassword.Text))
            //{
            //    MessageBox.Show("사용자 정보를 입력 해주세요");
            //    UserId.Focus();
            //    UserPassword.Focus();

            //    return false;
            //}

            ///오류가 발생했던 이유는 return하는 값이 False뿐이어서 

            return true;


        }

        private void SigninPage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminRegistration adr = new AdminRegistration();
            adr.Show();

        }

        private bool LoginCheck()
        {
            bool Login = false;
            string AdminId = UserId.Text;
            string AdminPw = UserPassword.Text;

            string ConnectionSting = ;

            SqlConnection scn = new SqlConnection(ConnectionSting);
            scn.Open();

            string Query = $"SELECT Admin_Password FROM Admin WHERE Admin_Id='{AdminId}';";
            SqlCommand comm = new SqlCommand(Query, scn);
            string Password = (string)comm.ExecuteScalar();

            if (String.IsNullOrEmpty(Password))
            {
                MessageBox.Show();
                return false;

            }
            else if (Password != AdminPw)
            {
                MessageBox.Show("비밀번호가 다릅니다.", "1identity Counceling Program", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else
            {
                MessageBox.Show();
                return true;
            }


        }

        

        }
    }
