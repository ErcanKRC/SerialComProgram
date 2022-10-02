using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Windows.Controls;

namespace SerialComProg
{
    public partial class MainMenu : Form
    {
        string dataOUT;
        string dataIN;
        string dataOUT2;
        string dataIN2;

        public MainMenu()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBoxComPort.Items.AddRange(ports);
            comboBoxComPort2.Items.AddRange(ports);
            if (ports.Length > 0)
            {
                comboBoxComPort.SelectedItem = ports[0];
            }
            else if (ports.Length > 1)
            {
                comboBoxComPort2.SelectedItem = ports[1];
            }
            else { }

            buttonOpen.Enabled = true;
            buttonClose.Enabled = false;
            dtrCheckBox.Checked = false;
            serialPort1.DtrEnable = false;
            rtsCheckBox.Checked = false;
            serialPort1.RtsEnable = false;
            buttonSendData.Enabled = false;
            radioButtonWriteLine.Checked = false;
            radioButtonWrite.Checked = true;
            radioButtonAddtoOldData.Checked = true;
            radioButtonAlwaysUpdate.Checked = false;

            buttonOpen2.Enabled = true;
            buttonClose2.Enabled = false;
            checkBoxDtrEnable2.Checked = false;
            serialPort2.DtrEnable = false;
            rtsCheckBox.Checked = false;
            serialPort2.RtsEnable = false;
            buttonSendData2.Enabled = false;
            radioButtonWriteLine2.Checked = false;
            radioButtonWrite2.Checked = true;
            radioButtonAddtoOldData2.Checked = true;
            radioButtonAlwaysUpdate2.Checked = false;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {

            try
            {
                serialPort1.PortName = comboBoxComPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(comboBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), comboBoxParityBits.Text);

                serialPort1.Open();
                progressBar1.Value = 100;
                buttonOpen.Enabled = false;
                buttonClose.Enabled = true;
                buttonSendData.Enabled = true;
                lblStatusCOMPort.Text = "ON";
                checkBoxUsingEnter.Checked = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonOpen.Enabled = true;
                buttonClose.Enabled = false;
                buttonSendData.Enabled = false;
                lblStatusCOMPort.Text = "OFF";
            }

        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                buttonOpen.Enabled = true;
                buttonClose.Enabled = false;
                buttonSendData.Enabled = false;
                lblStatusCOMPort.Text = "OFF";
            }
        }
        private void buttonSendData_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (checkBoxTimestamp1.Checked)
                {
                    textBoxDataX.Text += DateTime.Now.ToString("HH:mm:ss:fff ");
                }
                dataOUT = textBoxCOMXSend.Text;
                if (radioButtonWriteLine.Checked)
                {
                    serialPort1.WriteLine(dataOUT);
                    textBoxDataX.Text += "--> " + dataOUT + "\n";
                }
                else
                {
                    serialPort1.Write(dataOUT);
                    textBoxDataX.Text += "--> " + dataOUT + "\n";
                }
                if (textBoxCOMXSend.Text != "")
                {
                    textBoxCOMXSend.Text = "";
                }
            }
        }
        private void dtrCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.DtrEnable = true;
                MessageBox.Show("DTR Enable", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else { serialPort1.DtrEnable = false; }
        }
        private void rtsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.RtsEnable = true;
            }
            else { serialPort1.RtsEnable = false; }
            MessageBox.Show("RTS Enable", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void buttonClearDataOut_Click(object sender, EventArgs e)
        {
            if (textBoxDataX.Text != "")
            {
                textBoxDataX.Text = "";
            }
        }
        private void textBoxCOMXSend_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxUsingEnter.Checked)
            {
                textBoxCOMXSend.Text = textBoxCOMXSend.Text.Replace(Environment.NewLine, " ");
            }
        }
        private void textBoxCOMXSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (checkBoxUsingEnter.Checked)
            {
                if (e.KeyCode == Keys.Enter)
                {

                    if (serialPort1.IsOpen)
                    {
                        dataOUT = textBoxCOMXSend.Text;
                        e.Handled = true;
                        e.SuppressKeyPress = true;

                        buttonSendData_Click(sender, e);
                    }

                }
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }
        private void ShowData(object sender, EventArgs e)
        {
            if (checkBoxTimestamp1.Checked)
            {
                textBoxDataX.Text += DateTime.Now.ToString("HH:mm:ss:fff ");
            }
            if (radioButtonAlwaysUpdate.Checked)
            {
                textBoxDataX.Text = "<-- " + dataIN;
            }
            else
            {
                textBoxDataX.Text += "<-- " + dataIN;
            }
        }


        private void buttonOpen2_Click(object sender, EventArgs e)
        {

            try
            {
                serialPort2.PortName = comboBoxComPort2.Text;
                serialPort2.BaudRate = Convert.ToInt32(comboBoxBaudRate2.Text);
                serialPort2.DataBits = Convert.ToInt32(comboBoxDataBits2.Text);
                serialPort2.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBoxStopBits2.Text);
                serialPort2.Parity = (Parity)Enum.Parse(typeof(Parity), comboBoxParityBits2.Text);

                serialPort2.Open();
                progressBar2.Value = 100;
                buttonOpen2.Enabled = false;
                buttonClose2.Enabled = true;
                buttonSendData2.Enabled = true;
                lblStatusCOMPort2.Text = "ON";
                checkBoxUsingEnter2.Checked = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonOpen2.Enabled = true;
                buttonClose2.Enabled = false;
                buttonSendData2.Enabled = false;
                lblStatusCOMPort2.Text = "OFF";
            }

        }
        private void buttonClose2_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                serialPort2.Close();
                progressBar2.Value = 0;
                buttonOpen2.Enabled = true;
                buttonClose2.Enabled = false;
                buttonSendData2.Enabled = false;
                lblStatusCOMPort2.Text = "OFF";
            }
        }
        private void buttonSendData2_Click(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                if (checkBoxTimestamp2.Checked)
                {
                    textBoxDataY.Text += DateTime.Now.ToString("HH:mm:ss:fff ");
                }
                dataOUT2 = textBoxCOMYSend.Text;
                if (radioButtonWriteLine2.Checked)
                {
                    serialPort2.WriteLine(dataOUT2);
                    textBoxDataY.Text += "--> " + dataOUT2 + "\n";
                }
                else
                {
                    serialPort2.Write(dataOUT2);
                    textBoxDataY.Text += "--> " + dataOUT2 + "\n";
                }

                if (textBoxCOMYSend.Text != "")
                {
                    textBoxCOMYSend.Text = "";
                }

            }
        }
        private void dtrCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                serialPort2.DtrEnable = true;
                MessageBox.Show("DTR Enable", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else { serialPort2.DtrEnable = false; }
        }
        private void rtsCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (serialPort2.IsOpen)
            {
                serialPort2.RtsEnable = true;
            }
            else { serialPort2.RtsEnable = false; }
            MessageBox.Show("RTS Enable", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void buttonClearDataOut2_Click(object sender, EventArgs e)
        {
            if (textBoxDataY.Text != "")
            {
                textBoxDataY.Text = "";
            }
        }
        private void textBoxCOMYSend_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxUsingEnter2.Checked)
            {
                textBoxCOMYSend.Text = textBoxCOMYSend.Text.Replace(Environment.NewLine, " ");
            }
        }
        private void textBoxCOMYSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (checkBoxUsingEnter2.Checked)
            {
                if (e.KeyCode == Keys.Enter)
                {

                    if (serialPort2.IsOpen)
                    {
                        dataOUT2 = textBoxCOMYSend.Text;
                        e.Handled = true;
                        e.SuppressKeyPress = true;

                        buttonSendData2_Click(sender, e);
                    }

                }
            }
        }
        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN2 = serialPort2.ReadExisting();
            this.Invoke(new EventHandler(ShowData2));
        }
        private void ShowData2(object sender, EventArgs e)
        {
            if (checkBoxTimestamp2.Checked)
            {
                textBoxDataY.Text += DateTime.Now.ToString("HH:mm:ss:fff ");
            }
            if (radioButtonAlwaysUpdate2.Checked)
            {

                textBoxDataY.Text = "<-- " + dataIN2;
            }
            else
            {
                textBoxDataY.Text += "<-- " + dataIN2;
            }
        }

        private void buttonMacroX1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                MacroX1 ffx = new MacroX1();
                ffx.Show();
            }
        }
        public void buttonMacroXChangeName(string newButtonName)
        {
            string buttonName = newButtonName;
            buttonMacroX1.Text = buttonName;
        }
        string buttonContentX1;
        public void buttonMacroXChangeContent(string newContent)
        {
            buttonContentX1 = newContent;
        }
        private void buttonMacroX1_Click(object sender, EventArgs e)
        {
            textBoxCOMXSend.Text = buttonContentX1;
            buttonSendData_Click(sender, e);
        }

        private void buttonMacroY1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                MacroY1 ffy = new MacroY1();
                ffy.Show();
            }
        }
        public void buttonMacroY1ChangeName(string newButtonName)
        {
            string buttonName = newButtonName;
            buttonMacroY1.Text = buttonName;
        }
        string buttonContentY1;
        public void buttonMacroY1ChangeContent(string newContent)
        {
            buttonContentY1 = newContent;
        }
        private void buttonMacroY1_Click(object sender, EventArgs e)
        {
            textBoxCOMYSend.Text = buttonContentY1;
            buttonSendData2_Click(sender, e);
        }

        private void buttonMacroX2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                MacroX2 ffx2 = new MacroX2();
                ffx2.Show();
            }
        }
        public void buttonMacroX2ChangeName(string newButtonName)
        {
            string buttonName = newButtonName;
            buttonMacroX2.Text = buttonName;
        }
        string buttonContentX2;
        public void buttonMacroX2ChangeContent(string newContent)
        {
            buttonContentX2 = newContent;
        }
        private void buttonMacroX2_Click(object sender, EventArgs e)
        {
            textBoxCOMXSend.Text = buttonContentX2;
            buttonSendData_Click(sender, e);
        }

        private void buttonMacroY2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                MacroY2 ffy2 = new MacroY2();
                ffy2.Show();
            }
        }
        public void buttonMacroY2ChangeName(string newButtonName)
        {
            string buttonName = newButtonName;
            buttonMacroY2.Text = buttonName;
        }
        string buttonContentY2;
        public void buttonMacroY2ChangeContent(string newContent)
        {
            buttonContentY2 = newContent;
        }
        private void buttonMacroY2_Click(object sender, EventArgs e)
        {
            textBoxCOMYSend.Text = buttonContentY2;
            buttonSendData2_Click(sender, e);
        }

        public string strPath = "";
        private void buttonBatchRun_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                SelectFile sf = new SelectFile();
                sf.Show();
            }
        }
        public string fName;
        public void batchPathandName(string newStrPath, string name)
        {
            if (newStrPath != "")
            {
                strPath = newStrPath;
            }
            fName = name;
        }
        public void SFileButton(string NewName)
        {
            buttonSelectFile.Text = NewName;
        }

        SelectFile selectFile = (SelectFile)Application.OpenForms["SelectFile"];

        string[] Arguments;
        string ArgumentList;
        public void buttonBatchArgs(string[] Args)
        {
            Arguments = Args;
            for (int i = 0; i < Arguments.Length; i++)
            {
                ArgumentList += " " + Arguments[i];
            }
        }
        private void buttonBatchRun_Click(object sender, EventArgs e)
        {
            if (strPath == "")
            {

                SelectFile sf = new SelectFile();
                sf.Show();

            }
            else
            {
                Process process = new Process();
                process.StartInfo.FileName = strPath;
                for (int i = 0; i < Arguments.Length; i++)
                process.StartInfo.Arguments = string.Format(ArgumentList);
                process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                process.Start();
                process.WaitForExit();
            }
        }
    }
}
