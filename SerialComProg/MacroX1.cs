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
    public partial class MacroX1 : Form
    {
        MainMenu mm = (MainMenu)Application.OpenForms["MainMenu"];
        public MacroX1()
        {
            InitializeComponent();
        }
        private void MacroX1_Load(object sender, EventArgs e)
        {
        }

        public static string newButtonName;
        public static string newButtonContent;
        public void buttonChange_Click(object sender, EventArgs e)
        {
            if (textBoxButtonName.Text != "")
            {
                newButtonName = textBoxButtonName.Text;
                mm.buttonMacroXChangeName(newButtonName);
            }
            if (textBoxButtonContent.Text != "")
            {
                newButtonContent = textBoxButtonContent.Text;
                mm.buttonMacroXChangeContent(newButtonContent);
            }
            this.Close();
        }
    }
}
