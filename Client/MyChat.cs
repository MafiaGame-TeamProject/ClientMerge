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
    public partial class MyChat : UserControl
    {
        public MyChat() : this("Hello My World") { }
        public MyChat(string message)
        {
            InitializeComponent();
            myLbl.Text = message;
        }

        public string Message
        {
            get { return myLbl.Text; }
            set { myLbl.Text = value; }
        }
    }
}
