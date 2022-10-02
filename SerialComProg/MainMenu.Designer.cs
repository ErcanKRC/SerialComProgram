namespace SerialComProg
{
    partial class MainMenu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtrCheckBox = new System.Windows.Forms.CheckBox();
            this.buttonSendData = new System.Windows.Forms.Button();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxParityBits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtsCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.lblStatusCOMPort = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxCOMXSend = new System.Windows.Forms.TextBox();
            this.textBoxDataX = new System.Windows.Forms.RichTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBoxTimestamp1 = new System.Windows.Forms.CheckBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.radioButtonWrite = new System.Windows.Forms.RadioButton();
            this.radioButtonWriteLine = new System.Windows.Forms.RadioButton();
            this.checkBoxUsingEnter = new System.Windows.Forms.CheckBox();
            this.buttonClearDataOut = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.radioButtonAddtoOldData = new System.Windows.Forms.RadioButton();
            this.radioButtonAlwaysUpdate = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButtonAddtoOldData2 = new System.Windows.Forms.RadioButton();
            this.radioButtonAlwaysUpdate2 = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBoxCOMYSend = new System.Windows.Forms.TextBox();
            this.textBoxDataY = new System.Windows.Forms.RichTextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.checkBoxTimestamp2 = new System.Windows.Forms.CheckBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.radioButtonWrite2 = new System.Windows.Forms.RadioButton();
            this.radioButtonWriteLine2 = new System.Windows.Forms.RadioButton();
            this.checkBoxUsingEnter2 = new System.Windows.Forms.CheckBox();
            this.buttonClearDataOut2 = new System.Windows.Forms.Button();
            this.buttonSendData2 = new System.Windows.Forms.Button();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.lblStatusCOMPort2 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.buttonClose2 = new System.Windows.Forms.Button();
            this.buttonOpen2 = new System.Windows.Forms.Button();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.comboBoxParityBits2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxStopBits2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxDataBits2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxBaudRate2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBoxRtsEnable2 = new System.Windows.Forms.CheckBox();
            this.comboBoxComPort2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBoxDtrEnable2 = new System.Windows.Forms.CheckBox();
            this.buttonMacroX1 = new System.Windows.Forms.Button();
            this.buttonMacroY1 = new System.Windows.Forms.Button();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.buttonMacroX2 = new System.Windows.Forms.Button();
            this.buttonMacroY2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // dtrCheckBox
            // 
            this.dtrCheckBox.AutoSize = true;
            this.dtrCheckBox.Location = new System.Drawing.Point(35, 161);
            this.dtrCheckBox.Name = "dtrCheckBox";
            this.dtrCheckBox.Size = new System.Drawing.Size(94, 17);
            this.dtrCheckBox.TabIndex = 0;
            this.dtrCheckBox.Text = "DTR ENABLE";
            this.dtrCheckBox.UseVisualStyleBackColor = true;
            this.dtrCheckBox.CheckedChanged += new System.EventHandler(this.dtrCheckBox_CheckedChanged);
            // 
            // buttonSendData
            // 
            this.buttonSendData.Location = new System.Drawing.Point(417, 433);
            this.buttonSendData.Name = "buttonSendData";
            this.buttonSendData.Size = new System.Drawing.Size(72, 24);
            this.buttonSendData.TabIndex = 1;
            this.buttonSendData.Text = "Send Data";
            this.buttonSendData.UseVisualStyleBackColor = true;
            this.buttonSendData.Click += new System.EventHandler(this.buttonSendData_Click);
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(104, 19);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxComPort.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "COM PORT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxParityBits);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxStopBits);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxDataBits);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxBaudRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rtsCheckBox);
            this.groupBox1.Controls.Add(this.comboBoxComPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtrCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 200);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM-X Port Control";
            // 
            // comboBoxParityBits
            // 
            this.comboBoxParityBits.FormattingEnabled = true;
            this.comboBoxParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.comboBoxParityBits.Location = new System.Drawing.Point(104, 127);
            this.comboBoxParityBits.Name = "comboBoxParityBits";
            this.comboBoxParityBits.Size = new System.Drawing.Size(121, 21);
            this.comboBoxParityBits.TabIndex = 11;
            this.comboBoxParityBits.Text = "None";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "PARITY BITS";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.comboBoxStopBits.Location = new System.Drawing.Point(104, 100);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStopBits.TabIndex = 9;
            this.comboBoxStopBits.Text = "One";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "STOP BITS";
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.comboBoxDataBits.Location = new System.Drawing.Point(104, 73);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDataBits.TabIndex = 7;
            this.comboBoxDataBits.Text = "8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "DATA BITS";
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(104, 46);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBaudRate.TabIndex = 5;
            this.comboBoxBaudRate.Text = "9600";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAUD RATE";
            // 
            // rtsCheckBox
            // 
            this.rtsCheckBox.AutoSize = true;
            this.rtsCheckBox.Location = new System.Drawing.Point(127, 161);
            this.rtsCheckBox.Name = "rtsCheckBox";
            this.rtsCheckBox.Size = new System.Drawing.Size(93, 17);
            this.rtsCheckBox.TabIndex = 4;
            this.rtsCheckBox.Text = "RTS ENABLE";
            this.rtsCheckBox.UseVisualStyleBackColor = true;
            this.rtsCheckBox.CheckedChanged += new System.EventHandler(this.rtsCheckBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox13);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.buttonClose);
            this.groupBox2.Controls.Add(this.buttonOpen);
            this.groupBox2.Location = new System.Drawing.Point(278, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 120);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.lblStatusCOMPort);
            this.groupBox13.Location = new System.Drawing.Point(114, 11);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(104, 71);
            this.groupBox13.TabIndex = 5;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "COM PORT X STATUS";
            // 
            // lblStatusCOMPort
            // 
            this.lblStatusCOMPort.AutoSize = true;
            this.lblStatusCOMPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatusCOMPort.Location = new System.Drawing.Point(27, 37);
            this.lblStatusCOMPort.Name = "lblStatusCOMPort";
            this.lblStatusCOMPort.Size = new System.Drawing.Size(44, 20);
            this.lblStatusCOMPort.TabIndex = 0;
            this.lblStatusCOMPort.Text = "OFF";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(114, 88);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(104, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(6, 63);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 48);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "CLOSE";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(6, 11);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(101, 48);
            this.buttonOpen.TabIndex = 2;
            this.buttonOpen.Text = "OPEN";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxCOMXSend);
            this.groupBox3.Controls.Add(this.textBoxDataX);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.buttonSendData);
            this.groupBox3.Location = new System.Drawing.Point(12, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(495, 557);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "COM-X";
            // 
            // textBoxCOMXSend
            // 
            this.textBoxCOMXSend.Location = new System.Drawing.Point(6, 435);
            this.textBoxCOMXSend.Name = "textBoxCOMXSend";
            this.textBoxCOMXSend.Size = new System.Drawing.Size(405, 20);
            this.textBoxCOMXSend.TabIndex = 12;
            this.textBoxCOMXSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCOMXSend_KeyDown);
            // 
            // textBoxDataX
            // 
            this.textBoxDataX.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxDataX.ForeColor = System.Drawing.Color.Lime;
            this.textBoxDataX.Location = new System.Drawing.Point(6, 19);
            this.textBoxDataX.Name = "textBoxDataX";
            this.textBoxDataX.ReadOnly = true;
            this.textBoxDataX.Size = new System.Drawing.Size(483, 408);
            this.textBoxDataX.TabIndex = 7;
            this.textBoxDataX.Text = "";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBoxTimestamp1);
            this.groupBox6.Controls.Add(this.groupBox15);
            this.groupBox6.Controls.Add(this.checkBoxUsingEnter);
            this.groupBox6.Controls.Add(this.buttonClearDataOut);
            this.groupBox6.Controls.Add(this.groupBox9);
            this.groupBox6.Location = new System.Drawing.Point(6, 463);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(483, 88);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            // 
            // checkBoxTimestamp1
            // 
            this.checkBoxTimestamp1.AutoSize = true;
            this.checkBoxTimestamp1.Location = new System.Drawing.Point(6, 56);
            this.checkBoxTimestamp1.Name = "checkBoxTimestamp1";
            this.checkBoxTimestamp1.Size = new System.Drawing.Size(107, 17);
            this.checkBoxTimestamp1.TabIndex = 15;
            this.checkBoxTimestamp1.Text = "Show Timestamp";
            this.checkBoxTimestamp1.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.radioButtonWrite);
            this.groupBox15.Controls.Add(this.radioButtonWriteLine);
            this.groupBox15.Location = new System.Drawing.Point(116, 14);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(101, 66);
            this.groupBox15.TabIndex = 13;
            this.groupBox15.TabStop = false;
            // 
            // radioButtonWrite
            // 
            this.radioButtonWrite.AutoSize = true;
            this.radioButtonWrite.Location = new System.Drawing.Point(7, 42);
            this.radioButtonWrite.Name = "radioButtonWrite";
            this.radioButtonWrite.Size = new System.Drawing.Size(50, 17);
            this.radioButtonWrite.TabIndex = 1;
            this.radioButtonWrite.TabStop = true;
            this.radioButtonWrite.Text = "Write";
            this.radioButtonWrite.UseVisualStyleBackColor = true;
            // 
            // radioButtonWriteLine
            // 
            this.radioButtonWriteLine.AutoSize = true;
            this.radioButtonWriteLine.Location = new System.Drawing.Point(7, 19);
            this.radioButtonWriteLine.Name = "radioButtonWriteLine";
            this.radioButtonWriteLine.Size = new System.Drawing.Size(70, 17);
            this.radioButtonWriteLine.TabIndex = 0;
            this.radioButtonWriteLine.TabStop = true;
            this.radioButtonWriteLine.Text = "WriteLine";
            this.radioButtonWriteLine.UseVisualStyleBackColor = true;
            // 
            // checkBoxUsingEnter
            // 
            this.checkBoxUsingEnter.AutoSize = true;
            this.checkBoxUsingEnter.Location = new System.Drawing.Point(6, 33);
            this.checkBoxUsingEnter.Name = "checkBoxUsingEnter";
            this.checkBoxUsingEnter.Size = new System.Drawing.Size(81, 17);
            this.checkBoxUsingEnter.TabIndex = 14;
            this.checkBoxUsingEnter.Text = "Using Enter";
            this.checkBoxUsingEnter.UseVisualStyleBackColor = true;
            // 
            // buttonClearDataOut
            // 
            this.buttonClearDataOut.Location = new System.Drawing.Point(350, 20);
            this.buttonClearDataOut.Name = "buttonClearDataOut";
            this.buttonClearDataOut.Size = new System.Drawing.Size(127, 63);
            this.buttonClearDataOut.TabIndex = 5;
            this.buttonClearDataOut.Text = "Clear Data Out";
            this.buttonClearDataOut.UseVisualStyleBackColor = true;
            this.buttonClearDataOut.Click += new System.EventHandler(this.buttonClearDataOut_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.radioButtonAddtoOldData);
            this.groupBox9.Controls.Add(this.radioButtonAlwaysUpdate);
            this.groupBox9.Location = new System.Drawing.Point(223, 14);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(121, 69);
            this.groupBox9.TabIndex = 9;
            this.groupBox9.TabStop = false;
            // 
            // radioButtonAddtoOldData
            // 
            this.radioButtonAddtoOldData.AutoSize = true;
            this.radioButtonAddtoOldData.Location = new System.Drawing.Point(7, 42);
            this.radioButtonAddtoOldData.Name = "radioButtonAddtoOldData";
            this.radioButtonAddtoOldData.Size = new System.Drawing.Size(105, 17);
            this.radioButtonAddtoOldData.TabIndex = 1;
            this.radioButtonAddtoOldData.TabStop = true;
            this.radioButtonAddtoOldData.Text = "Add To Old Data";
            this.radioButtonAddtoOldData.UseVisualStyleBackColor = true;
            // 
            // radioButtonAlwaysUpdate
            // 
            this.radioButtonAlwaysUpdate.AutoSize = true;
            this.radioButtonAlwaysUpdate.Location = new System.Drawing.Point(7, 19);
            this.radioButtonAlwaysUpdate.Name = "radioButtonAlwaysUpdate";
            this.radioButtonAlwaysUpdate.Size = new System.Drawing.Size(96, 17);
            this.radioButtonAlwaysUpdate.TabIndex = 0;
            this.radioButtonAlwaysUpdate.TabStop = true;
            this.radioButtonAlwaysUpdate.Text = "Always Update";
            this.radioButtonAlwaysUpdate.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButtonAddtoOldData2);
            this.groupBox5.Controls.Add(this.radioButtonAlwaysUpdate2);
            this.groupBox5.Location = new System.Drawing.Point(228, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(121, 66);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            // 
            // radioButtonAddtoOldData2
            // 
            this.radioButtonAddtoOldData2.AutoSize = true;
            this.radioButtonAddtoOldData2.Location = new System.Drawing.Point(7, 42);
            this.radioButtonAddtoOldData2.Name = "radioButtonAddtoOldData2";
            this.radioButtonAddtoOldData2.Size = new System.Drawing.Size(105, 17);
            this.radioButtonAddtoOldData2.TabIndex = 1;
            this.radioButtonAddtoOldData2.TabStop = true;
            this.radioButtonAddtoOldData2.Text = "Add To Old Data";
            this.radioButtonAddtoOldData2.UseVisualStyleBackColor = true;
            // 
            // radioButtonAlwaysUpdate2
            // 
            this.radioButtonAlwaysUpdate2.AutoSize = true;
            this.radioButtonAlwaysUpdate2.Location = new System.Drawing.Point(7, 19);
            this.radioButtonAlwaysUpdate2.Name = "radioButtonAlwaysUpdate2";
            this.radioButtonAlwaysUpdate2.Size = new System.Drawing.Size(96, 17);
            this.radioButtonAlwaysUpdate2.TabIndex = 0;
            this.radioButtonAlwaysUpdate2.TabStop = true;
            this.radioButtonAlwaysUpdate2.Text = "Always Update";
            this.radioButtonAlwaysUpdate2.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBoxCOMYSend);
            this.groupBox7.Controls.Add(this.textBoxDataY);
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Controls.Add(this.buttonSendData2);
            this.groupBox7.Location = new System.Drawing.Point(513, 218);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(495, 557);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "COM-Y";
            // 
            // textBoxCOMYSend
            // 
            this.textBoxCOMYSend.Location = new System.Drawing.Point(7, 437);
            this.textBoxCOMYSend.Name = "textBoxCOMYSend";
            this.textBoxCOMYSend.Size = new System.Drawing.Size(399, 20);
            this.textBoxCOMYSend.TabIndex = 8;
            this.textBoxCOMYSend.TextChanged += new System.EventHandler(this.textBoxCOMYSend_TextChanged);
            this.textBoxCOMYSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCOMYSend_KeyDown);
            // 
            // textBoxDataY
            // 
            this.textBoxDataY.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxDataY.ForeColor = System.Drawing.Color.Lime;
            this.textBoxDataY.Location = new System.Drawing.Point(6, 19);
            this.textBoxDataY.Name = "textBoxDataY";
            this.textBoxDataY.ReadOnly = true;
            this.textBoxDataY.Size = new System.Drawing.Size(483, 408);
            this.textBoxDataY.TabIndex = 7;
            this.textBoxDataY.Text = "";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.checkBoxTimestamp2);
            this.groupBox8.Controls.Add(this.groupBox5);
            this.groupBox8.Controls.Add(this.groupBox14);
            this.groupBox8.Controls.Add(this.checkBoxUsingEnter2);
            this.groupBox8.Controls.Add(this.buttonClearDataOut2);
            this.groupBox8.Location = new System.Drawing.Point(6, 465);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(483, 86);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            // 
            // checkBoxTimestamp2
            // 
            this.checkBoxTimestamp2.AutoSize = true;
            this.checkBoxTimestamp2.Location = new System.Drawing.Point(6, 55);
            this.checkBoxTimestamp2.Name = "checkBoxTimestamp2";
            this.checkBoxTimestamp2.Size = new System.Drawing.Size(107, 17);
            this.checkBoxTimestamp2.TabIndex = 16;
            this.checkBoxTimestamp2.Text = "Show Timestamp";
            this.checkBoxTimestamp2.UseVisualStyleBackColor = true;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.radioButtonWrite2);
            this.groupBox14.Controls.Add(this.radioButtonWriteLine2);
            this.groupBox14.Location = new System.Drawing.Point(121, 12);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(101, 66);
            this.groupBox14.TabIndex = 9;
            this.groupBox14.TabStop = false;
            // 
            // radioButtonWrite2
            // 
            this.radioButtonWrite2.AutoSize = true;
            this.radioButtonWrite2.Location = new System.Drawing.Point(7, 42);
            this.radioButtonWrite2.Name = "radioButtonWrite2";
            this.radioButtonWrite2.Size = new System.Drawing.Size(50, 17);
            this.radioButtonWrite2.TabIndex = 1;
            this.radioButtonWrite2.TabStop = true;
            this.radioButtonWrite2.Text = "Write";
            this.radioButtonWrite2.UseVisualStyleBackColor = true;
            // 
            // radioButtonWriteLine2
            // 
            this.radioButtonWriteLine2.AutoSize = true;
            this.radioButtonWriteLine2.Location = new System.Drawing.Point(7, 19);
            this.radioButtonWriteLine2.Name = "radioButtonWriteLine2";
            this.radioButtonWriteLine2.Size = new System.Drawing.Size(70, 17);
            this.radioButtonWriteLine2.TabIndex = 0;
            this.radioButtonWriteLine2.TabStop = true;
            this.radioButtonWriteLine2.Text = "WriteLine";
            this.radioButtonWriteLine2.UseVisualStyleBackColor = true;
            // 
            // checkBoxUsingEnter2
            // 
            this.checkBoxUsingEnter2.AutoSize = true;
            this.checkBoxUsingEnter2.Location = new System.Drawing.Point(6, 32);
            this.checkBoxUsingEnter2.Name = "checkBoxUsingEnter2";
            this.checkBoxUsingEnter2.Size = new System.Drawing.Size(81, 17);
            this.checkBoxUsingEnter2.TabIndex = 12;
            this.checkBoxUsingEnter2.Text = "Using Enter";
            this.checkBoxUsingEnter2.UseVisualStyleBackColor = true;
            // 
            // buttonClearDataOut2
            // 
            this.buttonClearDataOut2.Location = new System.Drawing.Point(356, 18);
            this.buttonClearDataOut2.Name = "buttonClearDataOut2";
            this.buttonClearDataOut2.Size = new System.Drawing.Size(121, 60);
            this.buttonClearDataOut2.TabIndex = 1;
            this.buttonClearDataOut2.Text = "Clear Data Out";
            this.buttonClearDataOut2.UseVisualStyleBackColor = true;
            this.buttonClearDataOut2.Click += new System.EventHandler(this.buttonClearDataOut2_Click);
            // 
            // buttonSendData2
            // 
            this.buttonSendData2.Location = new System.Drawing.Point(412, 435);
            this.buttonSendData2.Name = "buttonSendData2";
            this.buttonSendData2.Size = new System.Drawing.Size(77, 24);
            this.buttonSendData2.TabIndex = 11;
            this.buttonSendData2.Text = "Send Data";
            this.buttonSendData2.UseVisualStyleBackColor = true;
            this.buttonSendData2.Click += new System.EventHandler(this.buttonSendData2_Click);
            // 
            // serialPort2
            // 
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox10);
            this.groupBox4.Controls.Add(this.progressBar2);
            this.groupBox4.Controls.Add(this.buttonClose2);
            this.groupBox4.Controls.Add(this.buttonOpen2);
            this.groupBox4.Location = new System.Drawing.Point(513, 40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(229, 121);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.lblStatusCOMPort2);
            this.groupBox10.Location = new System.Drawing.Point(114, 11);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(104, 71);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "COM PORT Y STATUS";
            // 
            // lblStatusCOMPort2
            // 
            this.lblStatusCOMPort2.AutoSize = true;
            this.lblStatusCOMPort2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatusCOMPort2.Location = new System.Drawing.Point(26, 37);
            this.lblStatusCOMPort2.Name = "lblStatusCOMPort2";
            this.lblStatusCOMPort2.Size = new System.Drawing.Size(44, 20);
            this.lblStatusCOMPort2.TabIndex = 0;
            this.lblStatusCOMPort2.Text = "OFF";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(111, 88);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(107, 23);
            this.progressBar2.TabIndex = 4;
            // 
            // buttonClose2
            // 
            this.buttonClose2.Location = new System.Drawing.Point(6, 63);
            this.buttonClose2.Name = "buttonClose2";
            this.buttonClose2.Size = new System.Drawing.Size(100, 48);
            this.buttonClose2.TabIndex = 3;
            this.buttonClose2.Text = "CLOSE";
            this.buttonClose2.UseVisualStyleBackColor = true;
            this.buttonClose2.Click += new System.EventHandler(this.buttonClose2_Click);
            // 
            // buttonOpen2
            // 
            this.buttonOpen2.Location = new System.Drawing.Point(6, 11);
            this.buttonOpen2.Name = "buttonOpen2";
            this.buttonOpen2.Size = new System.Drawing.Size(101, 48);
            this.buttonOpen2.TabIndex = 2;
            this.buttonOpen2.Text = "OPEN";
            this.buttonOpen2.UseVisualStyleBackColor = true;
            this.buttonOpen2.Click += new System.EventHandler(this.buttonOpen2_Click);
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.comboBoxParityBits2);
            this.groupBox16.Controls.Add(this.label7);
            this.groupBox16.Controls.Add(this.comboBoxStopBits2);
            this.groupBox16.Controls.Add(this.label8);
            this.groupBox16.Controls.Add(this.comboBoxDataBits2);
            this.groupBox16.Controls.Add(this.label10);
            this.groupBox16.Controls.Add(this.comboBoxBaudRate2);
            this.groupBox16.Controls.Add(this.label11);
            this.groupBox16.Controls.Add(this.checkBoxRtsEnable2);
            this.groupBox16.Controls.Add(this.comboBoxComPort2);
            this.groupBox16.Controls.Add(this.label12);
            this.groupBox16.Controls.Add(this.checkBoxDtrEnable2);
            this.groupBox16.Location = new System.Drawing.Point(748, 12);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(260, 200);
            this.groupBox16.TabIndex = 13;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "COM-Y Port Control";
            // 
            // comboBoxParityBits2
            // 
            this.comboBoxParityBits2.FormattingEnabled = true;
            this.comboBoxParityBits2.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.comboBoxParityBits2.Location = new System.Drawing.Point(104, 127);
            this.comboBoxParityBits2.Name = "comboBoxParityBits2";
            this.comboBoxParityBits2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxParityBits2.TabIndex = 11;
            this.comboBoxParityBits2.Text = "None";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "PARITY BITS";
            // 
            // comboBoxStopBits2
            // 
            this.comboBoxStopBits2.FormattingEnabled = true;
            this.comboBoxStopBits2.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.comboBoxStopBits2.Location = new System.Drawing.Point(104, 100);
            this.comboBoxStopBits2.Name = "comboBoxStopBits2";
            this.comboBoxStopBits2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStopBits2.TabIndex = 9;
            this.comboBoxStopBits2.Text = "One";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "STOP BITS";
            // 
            // comboBoxDataBits2
            // 
            this.comboBoxDataBits2.FormattingEnabled = true;
            this.comboBoxDataBits2.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.comboBoxDataBits2.Location = new System.Drawing.Point(104, 73);
            this.comboBoxDataBits2.Name = "comboBoxDataBits2";
            this.comboBoxDataBits2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDataBits2.TabIndex = 7;
            this.comboBoxDataBits2.Text = "8";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "DATA BITS";
            // 
            // comboBoxBaudRate2
            // 
            this.comboBoxBaudRate2.FormattingEnabled = true;
            this.comboBoxBaudRate2.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.comboBoxBaudRate2.Location = new System.Drawing.Point(104, 46);
            this.comboBoxBaudRate2.Name = "comboBoxBaudRate2";
            this.comboBoxBaudRate2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBaudRate2.TabIndex = 5;
            this.comboBoxBaudRate2.Text = "9600";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "BAUD RATE";
            // 
            // checkBoxRtsEnable2
            // 
            this.checkBoxRtsEnable2.AutoSize = true;
            this.checkBoxRtsEnable2.Location = new System.Drawing.Point(127, 161);
            this.checkBoxRtsEnable2.Name = "checkBoxRtsEnable2";
            this.checkBoxRtsEnable2.Size = new System.Drawing.Size(93, 17);
            this.checkBoxRtsEnable2.TabIndex = 4;
            this.checkBoxRtsEnable2.Text = "RTS ENABLE";
            this.checkBoxRtsEnable2.UseVisualStyleBackColor = true;
            // 
            // comboBoxComPort2
            // 
            this.comboBoxComPort2.FormattingEnabled = true;
            this.comboBoxComPort2.Location = new System.Drawing.Point(104, 19);
            this.comboBoxComPort2.Name = "comboBoxComPort2";
            this.comboBoxComPort2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxComPort2.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "COM PORT";
            // 
            // checkBoxDtrEnable2
            // 
            this.checkBoxDtrEnable2.AutoSize = true;
            this.checkBoxDtrEnable2.Location = new System.Drawing.Point(35, 161);
            this.checkBoxDtrEnable2.Name = "checkBoxDtrEnable2";
            this.checkBoxDtrEnable2.Size = new System.Drawing.Size(94, 17);
            this.checkBoxDtrEnable2.TabIndex = 0;
            this.checkBoxDtrEnable2.Text = "DTR ENABLE";
            this.checkBoxDtrEnable2.UseVisualStyleBackColor = true;
            // 
            // buttonMacroX1
            // 
            this.buttonMacroX1.Location = new System.Drawing.Point(47, 817);
            this.buttonMacroX1.Name = "buttonMacroX1";
            this.buttonMacroX1.Size = new System.Drawing.Size(75, 23);
            this.buttonMacroX1.TabIndex = 14;
            this.buttonMacroX1.Text = "MacroX1";
            this.buttonMacroX1.UseVisualStyleBackColor = true;
            this.buttonMacroX1.Click += new System.EventHandler(this.buttonMacroX1_Click);
            this.buttonMacroX1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMacroX1_MouseDown);
            // 
            // buttonMacroY1
            // 
            this.buttonMacroY1.Location = new System.Drawing.Point(519, 817);
            this.buttonMacroY1.Name = "buttonMacroY1";
            this.buttonMacroY1.Size = new System.Drawing.Size(75, 23);
            this.buttonMacroY1.TabIndex = 15;
            this.buttonMacroY1.Text = "MacroY1";
            this.buttonMacroY1.UseVisualStyleBackColor = true;
            this.buttonMacroY1.Click += new System.EventHandler(this.buttonMacroY1_Click);
            this.buttonMacroY1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMacroY1_MouseDown);
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.AutoSize = true;
            this.buttonSelectFile.Location = new System.Drawing.Point(330, 817);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(93, 23);
            this.buttonSelectFile.TabIndex = 16;
            this.buttonSelectFile.Text = "Select (.bat) File";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonBatchRun_Click);
            this.buttonSelectFile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonBatchRun_MouseDown);
            // 
            // buttonMacroX2
            // 
            this.buttonMacroX2.Location = new System.Drawing.Point(128, 817);
            this.buttonMacroX2.Name = "buttonMacroX2";
            this.buttonMacroX2.Size = new System.Drawing.Size(75, 23);
            this.buttonMacroX2.TabIndex = 17;
            this.buttonMacroX2.Text = "MacroX2";
            this.buttonMacroX2.UseVisualStyleBackColor = true;
            this.buttonMacroX2.Click += new System.EventHandler(this.buttonMacroX2_Click);
            this.buttonMacroX2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMacroX2_MouseDown);
            // 
            // buttonMacroY2
            // 
            this.buttonMacroY2.Location = new System.Drawing.Point(600, 817);
            this.buttonMacroY2.Name = "buttonMacroY2";
            this.buttonMacroY2.Size = new System.Drawing.Size(75, 23);
            this.buttonMacroY2.TabIndex = 18;
            this.buttonMacroY2.Text = "MacroY2";
            this.buttonMacroY2.UseVisualStyleBackColor = true;
            this.buttonMacroY2.Click += new System.EventHandler(this.buttonMacroY2_Click);
            this.buttonMacroY2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMacroY2_MouseDown);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 1058);
            this.Controls.Add(this.buttonMacroY2);
            this.Controls.Add(this.buttonMacroX2);
            this.Controls.Add(this.buttonSelectFile);
            this.Controls.Add(this.buttonMacroY1);
            this.Controls.Add(this.buttonMacroX1);
            this.Controls.Add(this.groupBox16);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainMenu";
            this.Text = "Serial Port Communication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox dtrCheckBox;
        private System.Windows.Forms.Button buttonSendData;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox rtsCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonClearDataOut;
        private System.Windows.Forms.ComboBox comboBoxParityBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RichTextBox textBoxDataY;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button buttonClearDataOut2;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label lblStatusCOMPort;
        private System.Windows.Forms.RichTextBox textBoxDataX;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RadioButton radioButtonAddtoOldData;
        private System.Windows.Forms.RadioButton radioButtonAlwaysUpdate;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label lblStatusCOMPort2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button buttonClose2;
        private System.Windows.Forms.Button buttonOpen2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButtonAddtoOldData2;
        private System.Windows.Forms.RadioButton radioButtonAlwaysUpdate2;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.RadioButton radioButtonWrite;
        private System.Windows.Forms.RadioButton radioButtonWriteLine;
        private System.Windows.Forms.CheckBox checkBoxUsingEnter;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.RadioButton radioButtonWrite2;
        private System.Windows.Forms.RadioButton radioButtonWriteLine2;
        private System.Windows.Forms.CheckBox checkBoxUsingEnter2;
        private System.Windows.Forms.Button buttonSendData2;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.ComboBox comboBoxParityBits2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxStopBits2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxDataBits2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxBaudRate2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBoxRtsEnable2;
        private System.Windows.Forms.ComboBox comboBoxComPort2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBoxDtrEnable2;
        private System.Windows.Forms.TextBox textBoxCOMXSend;
        private System.Windows.Forms.TextBox textBoxCOMYSend;
        private System.Windows.Forms.CheckBox checkBoxTimestamp1;
        private System.Windows.Forms.CheckBox checkBoxTimestamp2;
        private System.Windows.Forms.Button buttonMacroX1;
        private System.Windows.Forms.Button buttonMacroY1;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.Button buttonMacroX2;
        private System.Windows.Forms.Button buttonMacroY2;
    }
}

