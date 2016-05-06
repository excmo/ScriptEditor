using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScriptEd
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        public static int romType; // 0=RS; 1=FRLG; 2=EM
        public static int offType; // 0=dynamic; 1=fixed
        public static string dynamicOffset;
        public static string fixedOffset;
        public static string scriptPath = "";
        public static string textPath = "";
        public static string movePath = "";
        public static string etcPath = "";
        public static int pokepic_x = 10;
        public static int pokepic_y = 3;
        public static string currentScriptId = "";
        //String variables
        public static string sendString = "";
        public static string stringId = "";
        public static int boxType = 0;
        public static string ynDo;
        public static int ynSel;
        public static string ynOff;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainWindow());
        }
    }
}
