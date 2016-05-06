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
    public partial class startDialog : Form
    {
        public startDialog()
        {
            InitializeComponent();
        }

        private void createNewFile(object sender, EventArgs e)
        {
            if (radioDynamic.Checked == true) //Dynamic
            {
                ScriptEd.Program.offType = 0;
                ScriptEd.Program.dynamicOffset = offsetStart.Text;
                ScriptEd.Program.currentScriptId = scriptName.Text;
                if (romEdit.SelectedIndex == 0) //RS
                {
                    ScriptEd.Program.romType = 0;
                }
                if (romEdit.SelectedIndex == 1) //FRLG
                {
                    ScriptEd.Program.romType = 1;
                }
                if (romEdit.SelectedIndex == 2) //EM
                {
                    ScriptEd.Program.romType = 2;
                }
            }
            if (radioFix.Checked == true) //Fixed
            {
                ScriptEd.Program.offType = 1;
                ScriptEd.Program.fixedOffset = offsetFix.Text;
                if (romEdit.SelectedIndex == 0) //RS
                {
                    ScriptEd.Program.romType = 0;
                }
                if (romEdit.SelectedIndex == 1) //FRLG
                {
                    ScriptEd.Program.romType = 1;
                }
                if (romEdit.SelectedIndex == 2) //EM
                {
                    ScriptEd.Program.romType = 2;
                }
            }
            Close();
        }

        private void enableBoxes(object sender, EventArgs e)
        {
            if (radioFix.Checked == true) //Fixed
            {
                offsetStart.Enabled = false;
                offsetFix.Enabled = true;
                scriptName.Enabled = false;
            }
            if (radioDynamic.Checked == true) //Dynamic
            {
                offsetStart.Enabled = true;
                offsetFix.Enabled = false;
                scriptName.Enabled = false;
            }
        }

        private void initForm(object sender, EventArgs e)
        {
            romEdit.SelectedIndex = 1;
        }
    }
}
