using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JdbcTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string SignUpName = NameTextBox.Text;
            string CompanyCode = CompanyList.Text;
            string Discription = DiscriptionTextBox.Text;*/
            string connetionString;
            string phone;

            if (iPhoneRadio.Checked == true) phone = "iPhone";
            else if (SamsungRadio.Checked == true) phone = "Galaxy";
            else if (LGRadio.Checked == true) phone = "LG";
            else phone = "ETC";


            connetionString = ;
            //////
            SqlConnection cnn;

            cnn = new SqlConnection(connetionString);
            cnn.Open();
            string SqlCommandLine = "insert into UserLicenseReport(Name, Company, Discription, PhoneMaker) values('"+NameTextBox.Text+"' ,'"+CompanyList.Text+"' ,'"+DiscriptionTextBox.Text+"','"+phone+"')";

            SqlCommand scmd = new SqlCommand(SqlCommandLine, cnn);

            scmd.ExecuteNonQuery();
            MessageBox.Show("Data Saved");
            cnn.Close();




        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=DESKTOP-378OLOA\MSSQLSERVER01; Initial Catalog=HdelUserList; User ID=bonggu; Password=201017";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection OPEN !!!");
            cnn.Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void CompanyList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DiscriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
