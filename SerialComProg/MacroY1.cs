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
    public partial class MacroY1 : Form
    {
        MainMenu mm = (MainMenu)Application.OpenForms["MainMenu"];
        public MacroY1()
        {
            InitializeComponent();
        }

        private void MacroY1_Load(object sender, EventArgs e)
        {
        }
        public static string newButtonNameY1;
        public static string newButtonContentY1;
        public void buttonChange_Click(object sender, EventArgs e)
        {
            if (textBoxButtonName.Text != "")
            {
                newButtonNameY1 = textBoxButtonName.Text;
                mm.buttonMacroY1ChangeName(newButtonNameY1);
            }
            if (textBoxButtonContent.Text != "")
            {
                newButtonContentY1 = textBoxButtonContent.Text;
                mm.buttonMacroY1ChangeContent(newButtonContentY1);
            }
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxButtonContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxButtonName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
