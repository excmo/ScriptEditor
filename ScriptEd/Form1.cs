using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace ScriptEd
{
    public partial class mainWindow : Form
    {
        Compiling compileObject = new Compiling();
        long offset;
        OpenFileDialog commandsFile;
        ArrayList commands = new ArrayList();
        ArrayList bytes = new ArrayList();
        String commandsString;
        String[] orgs;
        Script[] scripts;
        compiledScript[] compiledScripts;
        Conversors convert = new Conversors();
        public mainWindow()
        {
            InitializeComponent();
        }

        private void openStringFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openFirst(object sender, EventArgs e)
        {
            startDialog start = new startDialog();
            start.ShowDialog();
            if(ScriptEd.Program.romType==0)
            {
                romTypeText.Text = "Ruby";
                romTypeText.ForeColor = Color.DarkRed;
                movedir6.Text = "❤";
                movedir6.Font = new Font(movedir6.Font.Name, movedir6.Font.Size, FontStyle.Regular);
                movedir7.Enabled = false;
                movedir7.Visible = false;
                movedir8.Enabled = false;
                movedir8.Visible = false;
                moveSpeed_moves.Value = 2;
                moveSpeed_moves.Maximum = 2;
            }
            if (ScriptEd.Program.romType == 1)
            {
                romTypeText.Text = "FireRed";
                romTypeText.ForeColor = Color.OrangeRed;
                movedir6.Text = "!!";
                movedir6.Font = new Font(movedir6.Font.Name, movedir6.Font.Size, FontStyle.Bold);
                movedir7.Enabled = true;
                movedir7.Visible = true;
                movedir8.Enabled = true;
                movedir8.Visible = true;
                moveSpeed_moves.Value = 3;
                moveSpeed_moves.Maximum = 4;
            }
            if (ScriptEd.Program.romType == 2)
            {
                romTypeText.Text = "Emerald";
                romTypeText.ForeColor = Color.DarkGreen;
                movedir6.Text = "❤";
                movedir6.Font = new Font(movedir6.Font.Name, movedir6.Font.Size, FontStyle.Regular);
                movedir7.Enabled = false;
                movedir7.Visible = false;
                movedir8.Enabled = false;
                movedir8.Visible = false;
                moveSpeed_moves.Value = 3;
                moveSpeed_moves.Maximum = 2;
            }
            if(ScriptEd.Program.offType==0)
            {
                scriptBox.Text = "#dynamic 0x" + ScriptEd.Program.dynamicOffset;
                scriptBox.Text = scriptBox.Text + System.Environment.NewLine + "'--------------" + System.Environment.NewLine + "#org @"+ ScriptEd.Program.currentScriptId + System.Environment.NewLine;
            }
            else
            {
                scriptBox.Text = "#org 0x" + ScriptEd.Program.fixedOffset;
                scriptBox.Text = scriptBox.Text + System.Environment.NewLine;
            }
        }

        private void hexToDec(object sender, EventArgs e)
        {
            int dec;
            dec=convert.hexToDec(HTD.Text);
            DTH.Text = string.Concat(dec);
        }

        private void decToHex(object sender, EventArgs e)
        {
            try
            {
                int dec = int.Parse(DTH.Text);
                HTD.Text = convert.decToHex(dec);
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show("Only possitive integers are allowed in this box (0-9).", "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                HTD.Text = "";
                DTH.Text = "";
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void advPic_Click(object sender, EventArgs e)
        {
            pokepicPos adv = new pokepicPos();
            ScriptEd.Program.pokepic_x = (int)pokepicX.Value;
            ScriptEd.Program.pokepic_y = (int)pokepicY.Value;
            adv.ShowDialog();
            pokepicX.Value = ScriptEd.Program.pokepic_x;
            pokepicY.Value = ScriptEd.Program.pokepic_y;
            ScriptEd.Program.pokepic_x = 10;
            ScriptEd.Program.pokepic_y = 3;
        }

        private void giveEgg(object sender, EventArgs e)
        {
            scriptBox.Text = scriptBox.Text + "Giveegg 0x"+convert.decToHex(eggPokeName.SelectedIndex)+" 'Gives an egg of "+eggPokeName.Text;
            scriptBox.Text = scriptBox.Text + System.Environment.NewLine;
        }

        private void movBt_Click(object sender, EventArgs e)
        {
            applyMovement mov = new applyMovement();
            mov.ShowDialog();
        }

        private void OpenAddMart(object sender, EventArgs e)
        {
            addShop mart = new addShop();
            mart.ShowDialog();
        }

        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openAddStr(object sender, EventArgs e)
        {
            string oldStr = Program.stringId;
            addString str = new addString();
            Program.stringId = "stringName";
            DialogResult option = str.ShowDialog();
            if (option != DialogResult.None)
            {
                if (oldStr != Program.stringId)
                {
                    TreeNode name = stringBox.Nodes.Add("#org @" + Program.stringId);
                    name.ImageIndex = 0;
                    name.SelectedImageIndex = 0;
                    TreeNode text = name.Nodes.Add("=" + Program.sendString);
                    text.ImageIndex = 1;
                    text.SelectedImageIndex = 1;
                    scriptBox.Text = scriptBox.Text + "msgbox @" + Program.stringId + " ";
                    switch (Program.boxType)
                    {
                        case 0: scriptBox.Text = scriptBox.Text + "0x0"; break;
                        case 1: scriptBox.Text = scriptBox.Text + "0x1"; break;
                        case 2: scriptBox.Text = scriptBox.Text + "0x2"; break;
                        case 3: scriptBox.Text = scriptBox.Text + "0x3"; break;
                        case 4: scriptBox.Text = scriptBox.Text + "0x4"; break;
                        case 5: scriptBox.Text = scriptBox.Text + "0x5" + Environment.NewLine + "compare 0x800D 0x" + Program.ynSel + Environment.NewLine + "0x1 " + Program.ynDo + " @" + Program.ynOff; break;
                        case 6: scriptBox.Text = scriptBox.Text + "0x6"; break;
                        case 7: scriptBox.Text = scriptBox.Text + "0xA"; break;
                        default: break;
                    }
                    scriptBox.Text = scriptBox.Text + Environment.NewLine;
                    Program.sendString = "";
                }
            }
        }

        private void callStr(object sender, TreeNodeMouseClickEventArgs e)
        {
            string info = e.Node.Text;
            if (info[0] == '=')
            {
                addString str = new addString();
                string strId = e.Node.Parent.Text.Remove(0, 6);
                string text = e.Node.Text.Remove(0,1);
                text = text.Replace("\\l\r\n", " ");
                text = text.Replace("\\n\r\n", " ");
                text = text.Replace("\\p\r\n", " ");
                Program.stringId = strId;
                Program.sendString = text;
                str.ShowDialog();
                e.Node.Parent.Remove();

                TreeNode name = stringBox.Nodes.Add("#org @" + Program.stringId);
                name.ImageIndex = 0;
                name.SelectedImageIndex = 0;
                TreeNode text2 = name.Nodes.Add("=" + Program.sendString);
                text2.ImageIndex = 1;
                text2.SelectedImageIndex = 1;
                Program.sendString = "";
            }

        }

        //Quick movement menú

        private void moveButtonClick(object sender, EventArgs e)
        {
            int rom;
            Button clicked = (Button)sender;
            string dirChar = "" + clicked.Name[7];
            int dir;
            rom = Program.romType;
            if (rom == 2) { rom = 0; }
            dir = int.Parse(dirChar);
            newMovement(dir, moveSpeed_moves.Value, rom);
        }

        private void newMovement(int dir, int vel, int rom)
        {
            //rom: 0->rse , 1->frlg
            //dir: 0->down, 1->up, 2->right, 3->left, 4->head
            //vel: 0->look
            string newMove;
            int index = 3 * rom + vel;
            string[] dnRaw = {/*RSE*/ "#RAW 0x0 'Look down"       , "#RAW 0x4 'Step down (slow)" , "#RAW 0x8  'Step down (normal)"    , /*FRLG*/ "#RAW 0x0 'Look down"  , "#RAW 0x8 'Step down (very slow)"  , "#RAW 0xC 'Step down (slow)" , "#RAW 0x10 'Step down" , "#RAW 0x1D 'Step down (fast)"  };
            string[] upRaw = {/*RSE*/ "#RAW 0x1 'Look up"         , "#RAW 0x5 'Step up (slow)"   , "#RAW 0x9  'Step up (normal)"      , /*FRLG*/ "#RAW 0x1 'Look up"    , "#RAW 0x9 'Step up (very slow)"    , "#RAW 0xD 'Step up (slow)"   , "#RAW 0x11 'Step up"   , "#RAW 0x1E 'Step up (fast)"    };
            string[] rgRaw = {/*RSE*/ "#RAW 0x2 'Look right"      , "#RAW 0x6 'Step right (slow)", "#RAW 0x10 'Step right (normal)"   , /*FRLG*/ "#RAW 0x2 'Look right" , "#RAW 0xA 'Step right (very slow)" , "#RAW 0xE 'Step right (slow)", "#RAW 0x12 'Step right", "#RAW 0x1F 'Step right (fast)" };
            string[] lfRaw = {/*RSE*/ "#RAW 0x3 'Look left"       , "#RAW 0x7 'Step left (slow)" , "#RAW 0x11 'Step left (normal)"    , /*FRLG*/ "#RAW 0x3 'Look left"  , "#RAW 0xB 'Step left (very slow)"  , "#RAW 0xF 'Step left (slow)" , "#RAW 0x13 'Step left" , "#RAW 0x20 'Step left (fast)"  };

            string[] hdRaw = {/*RSE*/ "#RAW 0x56 'Exclamation (!)", "#RAW 0x57 'Question (?)"    , "RAW 0x58 'Heart (<3)"             ,
                              /*FRLG*/"#RAW 0x62 'Exclamation (!)", "#RAW 0x63 'Question (?)"    , "RAW 0x65 'Double exclamation (!!)",          "RAW 0x64 'Ex (X)"     , "RAW 0x66 'Happy (^_^)"           };

            switch (dir)
            {
                case 0:  newMove = dnRaw[index]; break;
                case 1:  newMove = upRaw[index]; break;
                case 2:  newMove = rgRaw[index]; break;
                case 3:  newMove = lfRaw[index]; break;
                default: newMove = hdRaw[3 * rom + dir - 4]; break;
            }

            moveList_moves.Items.Add(newMove);
        }

        //Compilation
        private void compileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commandsString = compileObject.commands();
            //split the Strings, add them into the list
            String[] temp = Regex.Split(commandsString, "\r\n");
            foreach (String str in temp)
            {
                if (!str.StartsWith("//"))
                {
                    commands.Add(str);
                }
            }

            //split the script by #orgs
            orgs = Regex.Split(scriptBox.Text, "#org ");

            //get the free space offset. I will add a check if it's free space later
            String tempOffset = Regex.Split(orgs[0], "\r\n")[0].Split(' ')[1];
            if (tempOffset.StartsWith("0x"))
            {
                tempOffset = tempOffset.Replace("0x", "");
                offset = Int32.Parse(tempOffset, System.Globalization.NumberStyles.HexNumber);
            }
            else
            {
                offset = Int32.Parse(tempOffset);
            }
            scripts = new Script[orgs.Length];
            compiledScripts = new compiledScript[orgs.Length];

            //now there is an array of Scripts, which have an offset, and the commands that haven't been compiled yet.
            int i = 0;
            foreach(String str in orgs)
            {
                scripts[i] = new Script( offset , str);
                getSize(str);
                /*string x = scripts[i].getOffset() + " ";
                x += scripts[i].getBytes();
                MessageBox.Show(x);*/
                i++;
            }

            i = 0;
            foreach (Script scr in scripts)
            {
                compiledScript cs = new compiledScript();
                cs.setOffset(scr.getOffset());
                cs.setBytes(compile(scr.getBytes()));
            }
        }

        public byte[] compile(String script)
        {
            Boolean found = false;
            MessageBox.Show("script " + script);
            bytes.Clear();
            String[] divided = Regex.Split(script, "\r\n");
            foreach(String str in divided)
            {
                string[] spaces = str.Split(' ');
                string word = spaces[0].ToLower();
                while (!found)
                {
                    foreach(String key in commands)
                    {
                        string[] tempDivied = key.Split(' ');
                        if(tempDivied.Length > 1)
                        {
                            string maybe = tempDivied[0].ToLower();
                            MessageBox.Show(maybe + " " + word);
                            if (maybe.Equals(word))
                            {
                                bytes.Add((byte)Convert.ToInt32(tempDivied[1]));
                                for(int iterator = 2; iterator < tempDivied.Length; iterator++)
                                {
                                    String param = tempDivied[iterator].ToLower();
                                    MessageBox.Show(param);
                                }
                                found = true;
                            }
                            
                        }
                        found = true;
                    }
                }

            }

            //Actually returning
            byte[] toReturn = new byte[bytes.Count];
            int i = 0;
            foreach (byte b in bytes)
            {
                toReturn[i] = b;
                i++;
            }
            return toReturn;
        }
        public int getSize(String str)
        {
            int count = 0;
            String[] divided = Regex.Split(str, "\r\n");
            foreach(String temp in divided){
                String[] line = temp.Split(' ');
                foreach(String x in line)
                {
                    String word = x.ToLower();
                    if (word.Equals("if") || word.Equals("if1") || word.Equals("if2"))
                    {
                        count += 6;
                    }
                    else if (word.Equals("messagebox") || word.Equals("msgbox"))
                    {
                        count += 8;
                    }
                    else if (word.Equals("trainerbattle"))
                    {
                        count += 14;
                    }
                    else
                    {
                        if (word.Equals("word"))
                        {
                            count += 2;
                        }
                        else if (word.Equals("byte"))
                        {
                            count++;
                        }
                        else if (word.Equals("pointer") || word.Equals("rampointer") || word.Equals("dword"))
                        {
                            count += 2;
                        }
                        else
                        {
                            count++;
                        }
                    }

                }
            }

            offset += count;
            return count;
        }

    }
}
