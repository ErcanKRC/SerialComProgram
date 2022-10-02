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
    public partial class MacroX2 : Form
    {
        MainMenu mm = (MainMenu)Application.OpenForms["MainMenu"];
        public MacroX2()
        {
            InitializeComponent();
        }

        public static string newButtonName;
        public static string newButtonContent;
        public void buttonChange_Click(object sender, EventArgs e)
        {
            if (textBoxButtonName.Text != "")
            {
                newButtonName = textBoxButtonName.Text;
                mm.buttonMacroX2ChangeName(newButtonName);
            }
            if (textBoxButtonContent.Text != "")
            {
                newButtonContent = textBoxButtonContent.Text;
                mm.buttonMacroX2ChangeContent(newButtonContent);
            }
            this.Close();
        }
    }
}
