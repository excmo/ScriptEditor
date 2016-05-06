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
    public partial class addString : Form
    {
        setColor setColor = new setColor();
        string getLast = "black";
        public addString()
        {
            InitializeComponent();
        }

        private void convertText(object sender, EventArgs e)
        {
            getPrev();
            getBox();

        }

        private string getAux(int init, string text)
        {
            string aux = "";
            int i = init, j = 0;
            char read;
            bool count=true, endAux=false;
            while(endAux== false) //montar cadena auxiliar con 34 caracteres
                {
                try
                {
                    read = text[i]; //lectura del caracter actual
                    aux = aux + read; //añadir a la cadena auxiliar
                    switch (read) //procesar el último caracter
                    {
                        case '[': count = false; break; //Al detectar un corchete dejar de contar
                        case ']': count = true;  break; //hasta detectar el cierre del corchete
                        case '\\': j--; aux = aux + text[i + 1];endAux=true ; break; //Si aparece '\x' salir del bucle
                        default: if(count==true) j++; break; //Contar todos los demás caracteres
                    }
                    if (j == 34||i==(text.Length-1)) //cuando llegue a 34 caracteres salir del bucle
                    {
                        endAux = true;
                    }
                    if (i < text.Length - 1 && endAux == false)
                    {
                        i++;
                    }
                    else
                    {
                        endAux = true;
                    }
                }
                catch
                {
                    endAux = true;
                }
                    
                }
            return aux;
        }

        private int countAux(int init, string text)
        {
            string aux = "";
            int i = init, j = 0;
            char read;
            bool count = true, endAux = false;
            while (endAux == false) //montar cadena auxiliar con 34 caracteres
            {
                try
                {
                    read = text[i]; //lectura del caracter actual
                    aux = aux + read; //añadir a la cadena auxiliar
                    switch (read) //procesar el último caracter
                    {
                        case '[': count = false; j++ ; break; //Al detectar un corchete dejar de contar
                        case ']': count = true; j++; break; //hasta detectar el cierre del corchete
                        case '\\': j--; aux = aux + text[i + 1]; endAux = true; break; //Si aparece '\x' salir del bucle
                        default: if (count == true) j++; break; //Contar todos los demás caracteres
                    }
                    if (j == 34 || i == (text.Length - 1)) //cuando llegue a 34 caracteres salir del bucle
                    {
                        endAux = true;
                    }
                    if (i < text.Length - 1 && endAux == false)
                    {
                        i++;
                    }
                    else
                    {
                        endAux = true;
                    }
                }
                catch
                {
                    endAux = true;
                }
            }
                return j;
        }

        private string getLine(string aux, int auxLen)
        {
            //Contar aux
            int init = aux.Length;
            int i = init-1;
            int j = 0;
            bool end=false;
            char s = '\0';
            string line = "";
            if (auxLen < 34)
            {
                return aux;
            }

            //Buscar ' '
            while(end==false)
            {
                    s = aux[i];
                    switch (s) //procesar el último caracter
                    {
                        case ' ': end = true; break; //salir del bucle cuando detecte el primer espacio
                        case '\\': i++; end = true; break; //Si aparece '\x' salir del bucle
                        default: i--; break; //Contar todos los demás caracteres
                    }
                    if (i <= 0)
                    {
                        end = true;
                    }
            }
            while (j < i)
            {
                line = line + aux[j];
                j++;
            }
            return line;
        }
        
        private void getPrev()
        {
            stResult.Clear(); //Borra texto anterior
            string aux, aux2;
            string newLine = ""; //Cada línea
            string prevText = ""; //Texto final
            bool endLoop = false;
            string text = stringBox.Text; //Texto inicial
            int i=0; //Contador caracteres total
            int l = 0; //contar líneas
            int lenght = text.Length - 1;
            while(endLoop==false)
            {
                aux = getAux(i, text);
                if (i==lenght)
                {
                    endLoop = true;
                }
                newLine = getLine(aux, countAux(i, text));
                i = i + newLine.Length+1;
                if (newLine == "")
                {
                    endLoop = true;
                }
                else
                {
                    if (l != 0)
                    {
                        if (l == 1)
                        {
                            prevText = prevText + "\\n" + Environment.NewLine;
                        }
                        prevText = prevText + newLine + "\\l" + Environment.NewLine;
                    }
                    else
                    {
                        prevText = prevText + newLine;
                    }
                    l++;
                }
                
                newLine = "";
            }
            stResult.Text = prevText;
        }

        private void getBox()
        {
            prev.Clear();
            string prevText = stResult.Text, show="", comm="";
            int length = stResult.TextLength;
            int i=0,j=0, start, end;
            bool endBox = false, readComm = false, Comm0 = false;
            char read;
            string color = "black_fr";
            while(endBox == false)
            {
                read = prevText[i];
                switch (read)
                {
                    case '[': readComm = true; end = j; break;
                    case ']': readComm = false; start = j; break;
                    case '\\': i = i + 2; break;
                    default: if (readComm == false) {show = show + read; j++; } else comm = comm + read; break;
                }
                if (readComm == false && Comm0 == true)
                {
                    switch (comm)
                    {
                        case "...":    show = show + "…"; break;
                        case "$":      show = show + "₽"; break;
                        case "player": show = show + "player"; break;
                        case "rival":  show = show + "rival"; break;
                        case "m":      show = show + "♂"; break;
                        case "f":      show = show + "♀"; break;
                        case "Lv":     show = show + "Lv."; break;
                        case "PK":     show = show + "PK"; break;
                        case "MN":     show = show + "MN"; break;
                        case "PO":     show = show + "PO"; break;
                        case "KE":     show = show + "Ké"; break;
                        case "BL":     show = show + "BL"; break;
                        case "OC":     show = show + "OCK"; break;
                        case "Po":     show = show + "Po"; break;
                        case "Ké":     show = show + "ke"; break;
                        default:       color = comm; break;
                    }
                    comm = "";
                }
                i++;
                prev.Text = show;
                if (i == (length - 1))
                {
                    endBox = true;
                }                
                Comm0 = readComm;
            }
            
        }

        private void doBlackFr(object sender, EventArgs e)
        {
            Color oldColor  = stringBox.SelectionColor;
            string newColor = "black_fr";
            colorText(oldColor, newColor);
        }

        private void doWhiteFr(object sender, EventArgs e)
        {
            Color oldColor = stringBox.SelectionColor;
            string newColor = "white_fr";
            colorText(oldColor, newColor);
        }

        private void doGrayFr(object sender, EventArgs e)
        {
            Color oldColor = stringBox.SelectionColor;
            string newColor = "gray_fr";
            colorText(oldColor, newColor);
        }

        private void doRedFr(object sender, EventArgs e)
        {
            Color oldColor = stringBox.SelectionColor;
            string newColor = "red_fr";
            colorText(oldColor, newColor);
        }

        private void doOrangeFr(object sender, EventArgs e)
        {
            Color oldColor = stringBox.SelectionColor;
            string newColor = "orange_fr";
            colorText(oldColor, newColor);
        }

        private void doGreenFr(object sender, EventArgs e)
        {
            Color oldColor = stringBox.SelectionColor;
            string newColor = "green_fr";
            colorText(oldColor, newColor);
        }

        private void doLightGreenFr(object sender, EventArgs e)
        {
            Color oldColor = stringBox.SelectionColor;
            string newColor = "lightgreen_fr";
            colorText(oldColor, newColor);
        }

        private void doBlueFr(object sender, EventArgs e)
        {
            Color oldColor = stringBox.SelectionColor;
            string newColor = "blue_fr";
            colorText(oldColor, newColor);
        }

        private void doLightBlueFr(object sender, EventArgs e)
        {
            Color oldColor = stringBox.SelectionColor;
            string newColor = "lightblue_fr";
            colorText(oldColor, newColor);
        }

        private void doLightBlue2Fr(object sender, EventArgs e)
        {
            Color oldColor = stringBox.SelectionColor;
            string newColor = "lightblue2_fr";
            colorText(oldColor, newColor);
        }

        private void doCyanFr(object sender, EventArgs e)
        {
            Color oldColor = stringBox.SelectionColor;
            string newColor = "cyan_fr";
            colorText(oldColor, newColor);
        }

        private void doLightBlue3Fr(object sender, EventArgs e)
        {
            Color oldColor = stringBox.SelectionColor;
            string newColor = "lightblue3_fr";
            colorText(oldColor, newColor);
        }

        private void doNavyBlueFr(object sender, EventArgs e)
        {
            Color oldColor = stringBox.SelectionColor;
            string newColor = "navyblue_fr";
            colorText(oldColor, newColor);
        }

        private void doDarkNavyBlueFr(object sender, EventArgs e)
        {
            Color oldColor = stringBox.SelectionColor;
            string newColor = "darknavyblue_fr";
            colorText(oldColor, newColor);
        }

        private void initString(object sender, EventArgs e)
        {
            boxType.SelectedIndex = 6;
            Color color = setColor.TextToColor(getLast = "black_fr");
            stringBox.SelectionColor = color;
            yesNo.SelectedIndex = 0;
            gotoCall.SelectedIndex = 0;
            yesNo.Enabled = false;
            gotoCall.Enabled = false;
            ynOffset.Enabled = false;
        }

        private void colorText(Color color1, string color2Name)
        {
            string color1Name = setColor.ColorToText(color1);
            Color color2 = setColor.TextToColor(color2Name);
            stringBox.SelectionColor = color2;
            stringBox.SelectedText = "[" + color2Name + "]" + stringBox.SelectedText + "[" + color1Name + "]";
        }

        private void enableYN(object sender, EventArgs e)
        {
            int type = boxType.SelectedIndex;
            if (type == 5)
            {
                yesNo.Enabled = true;
                gotoCall.Enabled = true;
                ynOffset.Enabled = true;
            }
            else
            {
                yesNo.Enabled = false;
                gotoCall.Enabled = false;
                ynOffset.Enabled = false;
            }
        }

        private void setString(object sender, EventArgs e)
        {
            Program.stringId = strId.Text;
            Program.boxType = boxType.SelectedIndex;
            if (boxType.SelectedIndex == 5) 
            {
                Program.ynSel = yesNo.SelectedIndex;
                Program.ynDo = gotoCall.SelectedText;
                Program.ynOff = ynOffset.Text;
            }
            Program.sendString = stResult.Text;
            Close();
        }
    }
}
