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
    public partial class Conversors
    {
        public string decToHex(int dec)
        {
            int r;
            int i = 0;
            string hex = "";

            try {
                if (dec < 0)
                {
                    DialogResult result = MessageBox.Show("Only possitive integers are allowed in this box (0-9).", "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    hex = "";
                    return hex;
                }

                for (i = 0; dec >= 16; i++)
                {
                    r = dec % 16;
                    dec = dec / 16;
                    switch (r)
                    {
                        case 10: hex = "A" + hex; break;
                        case 11: hex = "B" + hex; break;
                        case 12: hex = "C" + hex; break;
                        case 13: hex = "D" + hex; break;
                        case 14: hex = "E" + hex; break;
                        case 15: hex = "F" + hex; break;
                        default: hex = string.Concat(r) + hex; break;
                    }
                }
                switch (dec)
                {
                    case 10: hex = "A" + hex; break;
                    case 11: hex = "B" + hex; break;
                    case 12: hex = "C" + hex; break;
                    case 13: hex = "D" + hex; break;
                    case 14: hex = "E" + hex; break;
                    case 15: hex = "F" + hex; break;
                    default: hex = string.Concat(dec) + hex; break;
                }
                return hex;
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show("Only possitive integers are allowed in this box (0-9).", "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                hex = "";
                return hex;
            }
        }
        public int hexToDec(string hex)
        {
            int l = hex.Length;
            int i = 0;
            int j = l - 1;
            int a;
            int b = 0;
            int dec = 0;
            for (i = 0; i < l; i++)
            {
                a = (hex[i]);
                switch (a)
                {
                    case 48: b = 0; break;//0
                    case 49: b = 1; break;//1
                    case 50: b = 2; break;//2
                    case 51: b = 3; break;//3
                    case 52: b = 4; break;//4
                    case 53: b = 5; break;//5
                    case 54: b = 6; break;//6
                    case 55: b = 7; break;//7
                    case 56: b = 8; break;//8
                    case 57: b = 9; break;//9
                    case 65: b = 10; break;//A
                    case 66: b = 11; break;//B
                    case 67: b = 12; break;//C
                    case 68: b = 13; break;//D
                    case 69: b = 14; break;//E
                    case 70: b = 15; break;//F
                    default:
                        DialogResult result = MessageBox.Show("Only HEX is allowed in this box (0-9 and A-F).", "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        dec = 0;
                        return dec;
                }
                dec = dec + b * (int)Math.Pow(16, j);
                j--;

            }
            return dec;

        }
    }
   public partial class Saving
    {
        public void moveFiles(string movId, string owId, Boolean waitMov, ListBox moveList, int rom, string path)
        {
            string moves = "";
            for(int i = 0; i <= moveList.Items.Count; i++)
            {
                moves = moveList.GetItemText(i)+ System.Environment.NewLine;
            }
        }
    }
    public partial class setColor
    {
        Color black_fr = Color.FromArgb(0x00606060);
        Color white_fr = Color.FromArgb(0x00f8f8f8);
        Color gray_fr = Color.FromArgb(0x00D0D0C8);
        Color red_fr = Color.FromArgb(0x00E00808);
        Color orange_fr = Color.FromArgb(0x00F8B870);
        Color green_fr = Color.FromArgb(0x00209808);
        Color lightgreen_fr = Color.FromArgb(0x0090f090);
        Color blue_fr = Color.FromArgb(0x003050C8);
        Color lightblue_fr = Color.FromArgb(0x00a0c0f0);
        Color lightblue2_fr = Color.FromArgb(0x00d0e0f0);
        Color cyan_fr = Color.FromArgb(0x00a0d0e0);
        Color lightblue3_fr = Color.FromArgb(0x00e0f0f8);
        Color navyblue_fr = Color.FromArgb(0x0070A0C0);
        Color darknavyblue_fr = Color.FromArgb(0x004870A0);
        public Color TextToColor(string name)
        {
            switch (name)
            {
                case "black_fr": return black_fr;
                case "white_fr": return white_fr;
                case "gray_fr": return gray_fr;
                case "red_fr": return red_fr;
                case "orange_fr": return orange_fr;
                case "green_fr": return green_fr;
                case "lightgreen_fr": return lightgreen_fr;
                case "blue_fr": return blue_fr;
                case "lightblue_fr": return lightblue_fr;
                case "lightblue2_fr": return lightblue2_fr;
                case "cyan_fr": return cyan_fr;
                case "lightblue3_fr": return lightblue3_fr;
                case "navyblue_fr": return navyblue_fr;
                case "darknavyblue_fr": return darknavyblue_fr;
                default: return black_fr;
            }
        }
        public string ColorToText(Color frcolor)
        {
            switch (frcolor.ToArgb())
            {
                case 0x00606060: return "black_fr";
                case 0x00f8f8f8: return "white_fr";
                case 0x00D0D0C8: return "gray_fr";
                case 0x00E00808: return "red_fr";
                case 0x00F8B870: return "orange_fr";
                case 0x00209808: return "green_fr";
                case 0x0090f090: return "lightgreen_fr";
                case 0x003050C8: return "blue_fr";
                case 0x00a0c0f0: return "lightblue_fr";
                case 0x00d0e0f0: return "lightblue2_fr";
                case 0x00a0d0e0: return "cyan_fr";
                case 0x00e0f0f8: return "lightblue3_fr";
                case 0x0070A0C0: return "navyblue_fr";
                case 0x004870A0: return "darknavyblue_fr";
                default:         return "black_fr";
            }
        }
    }
}