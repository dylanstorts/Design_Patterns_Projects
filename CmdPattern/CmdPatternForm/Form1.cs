using CmdClass_Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CmdPatternForm
{
    public partial class Form1 : Form
    {

        User user = new User();

        public Form1()
        {
            InitializeComponent();
        }

        private void txtb_write_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ' ')
            {
                user.Write(txtb_write.Text);
            }
        }

        private void btn_undo_Click(object sender, EventArgs e)
        {
            txtb_write.Text = user.Undo();
        }

        private void btn_redo_Click(object sender, EventArgs e)
        {
            txtb_write.Text = user.Redo();
        }
    }
}
