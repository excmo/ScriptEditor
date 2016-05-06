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
    public partial class applyMovement : Form
    {
        public applyMovement()
        {
            InitializeComponent();
        }

        private void getRAW(object sender, TreeNodeMouseClickEventArgs e)
        {
            string rawId = e.Node.Name;
            if (rawId.Length == 3)
            {
                string rawAction = e.Node.Parent.Text;
                string rawDesc = e.Node.Text;
                movList.Items.Add("#RAW 0" + rawId+"  '"+rawAction+" "+rawDesc);
            }
        }

        private void removeRaw(object sender, EventArgs e)
        {
            if (movList.SelectedIndex < 0 || movList.SelectedItem == null)
            {
                return;
            }
            else
            {
                movList.Items.Remove(movList.SelectedItem);
            }
        }

        private void moveUp(object sender, EventArgs e)
        {
            moveItem(-1);
        }

        private void moveItem(int i)
        {
            int newIndex = movList.SelectedIndex + i;

            if (movList.SelectedIndex < 0 || movList.SelectedItem == null)
            {
                return;
            }

            if(newIndex<0||newIndex>=movList.Items.Count)
            {
                return;
            }

            object selected = movList.SelectedItem;

            movList.Items.Remove(selected);
            movList.Items.Insert(newIndex, selected);
            movList.SetSelected(newIndex, true);
        }

        private void moveDown(object sender, EventArgs e)
        {
            moveItem(1);
        }

        private void moveLast(object sender, EventArgs e)
        {
            moveItem(movList.Items.Count - movList.SelectedIndex - 1);
        }

        private void moveFirst(object sender, EventArgs e)
        {
            moveItem(-(movList.SelectedIndex));
        }

        private void clearList(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will clear all movements. You won't be able to undo this action.", "Clear movements", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                movList.Items.Clear();
            }
            else return;
        }
    }
}
