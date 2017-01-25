using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _300833478_Lovell__ASS2
{
    public partial class LoginUserControl : UserControl
    {
        public string Username;
        public string Password;
        public LoginUserControl()
        {
            InitializeComponent();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
          
            Username = text.Text;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;

            Password = text.Text;
        }
    }
}
