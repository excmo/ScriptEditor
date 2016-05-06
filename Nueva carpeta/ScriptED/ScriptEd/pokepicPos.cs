using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScriptEd
{
    public partial class pokepicPos : Form
    {
        Conversors conv = new Conversors();
        public pokepicPos()
        {
            InitializeComponent();
        }


        private void xMove(object sender, EventArgs e)
        {
            int x = 8*(int)x_var.Value;
            int y = 8*(int)y_var.Value;
            if (x / 8 < 16)
            {
            hex_x.Text ="HEX: (0"+conv.decToHex(x/8)+")";
            }
            else
            {
                hex_x.Text = "HEX: (" + conv.decToHex(x / 8) + ")";
            }
            if (y / 8 < 16)
            {
                hex_y.Text = "HEX: (0" + conv.decToHex(y / 8) + ")";
            }
            else
            {
                hex_y.Text = "HEX: (" + conv.decToHex(y / 8) + ")";
            }
            pokePic.Location = new Point (x, y);
        }

        private void showBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showBox.Checked == true)
            {
                showTextBox.Visible = true;
            }
            else
            {
                showTextBox.Visible = false;
            }
        }

        private void getPos(object sender, EventArgs e)
        {
            int x = (int)x_var.Value;
            int y = (int)y_var.Value;
            ScriptEd.Program.pokepic_x = x;
            ScriptEd.Program.pokepic_y = y;
            Close();
        }

        private void initPos(object sender, EventArgs e)
        {
            x_var.Value = ScriptEd.Program.pokepic_x;
            y_var.Value = ScriptEd.Program.pokepic_y;
            hex_x.Text = conv.decToHex(ScriptEd.Program.pokepic_x);
            hex_y.Text = conv.decToHex(ScriptEd.Program.pokepic_y);
            if (x_var.Value  < 16)
            {
                hex_x.Text = "HEX: (0" + conv.decToHex((int)x_var.Value) + ")";
            }
            else
            {
                hex_x.Text = "HEX: (" + conv.decToHex((int)x_var.Value) + ")";
            }
            if (y_var.Value  < 16)
            {
                hex_y.Text = "HEX: (0" + conv.decToHex((int)y_var.Value) + ")";
            }
            else
            {
                hex_y.Text = "HEX: (" + conv.decToHex((int)y_var.Value) + ")";
            }
            if (ScriptEd.Program.romType == 1)
            {
                screenBg.BackgroundImage = ScriptEd.Properties.Resources.bg_fr;
            }
            else
            {
                screenBg.BackgroundImage = ScriptEd.Properties.Resources.bg_rse;
            }
        }
    }
}
