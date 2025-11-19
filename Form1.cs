using System.Drawing.Text;

namespace Barangay_Employee_Management_System
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        
        private void login_btn_Click(object sender, EventArgs e)
        {
            
            string username = username_txtbox.Text;
            string password = password_txtbox.Text;

            // Replace the condition when connecting to the SQL Database)
            // Temporary Only
            if (username == "admin" && password == "123")
            {
                MessageBox.Show("Login Successfully");

                /*Initialize Form because Form is a Class not an 
                 Object */
                Form2 Form2 = new Form2();
                Form2.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials, Please Try Again");
                username_txtbox.Clear();
                password_txtbox.Clear();

            }

        }
    }
}
