using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace SerialComProg
{
    public partial class SelectFile : Form
    {
        MainMenu mainMenu = (MainMenu)Application.OpenForms["MainMenu"];


        public SelectFile()
        {
            InitializeComponent();
        }


        public string filePath;
        string newPath;
        public string fileName;
        private void buttonChooseFolder_Click(object sender, EventArgs e)
        {
            selectFile();

        }
        public void selectFile()
        {
            FolderBrowserDialog file = new FolderBrowserDialog();
            file.ShowNewFolderButton = false;
            file.Description = "Please select a file";
            if (file.ShowDialog() == DialogResult.OK)
            {
                filePath = file.SelectedPath;
                textBoxFolderPath.Text = file.SelectedPath;

                DirectoryInfo batchPath = new DirectoryInfo(file.SelectedPath);
                FileInfo[] files = batchPath.GetFiles("*.bat");
                comboBox1.Items.Clear();
                comboBox1.DataSource = files;
            }
        }
        private void splitTextBox()
        {
            string[] tboxsplitargs = textBoxArgs.Text.Split(' ');
            mainMenu.buttonBatchArgs(tboxsplitargs);

        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            newPath = filePath + "\\" + comboBox1.SelectedItem;
            fileName = comboBox1.SelectedItem.ToString();
            mainMenu.batchPathandName(newPath,fileName);
            mainMenu.SFileButton(fileName);
            splitTextBox();
            this.Close();
            
        }

    }
}
