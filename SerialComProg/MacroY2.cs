using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialComProg
{
    public partial class MacroY2 : Form
    {
        MainMenu mm = (MainMenu)Application.OpenForms["MainMenu"];
        public MacroY2()
        {
            InitializeComponent();
        }

        public static string newButtonNameY2;
        public static string newButtonContentY2;
        public void buttonChange_Click(object sender, EventArgs e)
        {
            if (textBoxButtonName.Text != "")
            {
                newButtonNameY2 = textBoxButtonName.Text;
                mm.buttonMacroY2ChangeName(newButtonNameY2);
            }
            if (textBoxButtonContent.Text != "")
            {
                newButtonContentY2 = textBoxButtonContent.Text;
                mm.buttonMacroY2ChangeContent(newButtonContentY2);
            }
            this.Close();
        }
    }
}
