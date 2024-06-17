using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormClient
{
    public partial class OtherChat : UserControl
    {
        public OtherChat() : this("Hello World", "User1") { }

        public OtherChat(string message, string user)
        {
            InitializeComponent();
            otherLbl.Text = message;
            userLbl.Text = user;
        }

        public string Message
        {
            get { return otherLbl.Text; }
            set { otherLbl.Text = value; }
        }

        public string User
        {
            get { return userLbl.Text; }
            set { userLbl.Text = value; }
        }
    }
}