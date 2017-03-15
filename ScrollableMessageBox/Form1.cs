using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrollableMessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var message = "1\n2\n3\n4\n5\n6\n7\n8\n9\n0\n";
            //assumes it's called from inside another Form
            ScrollMessageBox.ShowDialog(message, "My Message", this);

           

        }
    }
}
