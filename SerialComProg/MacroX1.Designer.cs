﻿namespace SerialComProg
{
    partial class MacroX1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonChange = new System.Windows.Forms.Button();
            this.textBoxButtonName = new System.Windows.Forms.TextBox();
            this.textBoxButtonContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(248, 30);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 0;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // textBoxButtonName
            // 
            this.textBoxButtonName.Location = new System.Drawing.Point(96, 4);
            this.textBoxButtonName.Name = "textBoxButtonName";
            this.textBoxButtonName.Size = new System.Drawing.Size(100, 20);
            this.textBoxButtonName.TabIndex = 1;
            // 
            // textBoxButtonContent
            // 
            this.textBoxButtonContent.Location = new System.Drawing.Point(96, 30);
            this.textBoxButtonContent.Name = "textBoxButtonContent";
            this.textBoxButtonContent.Size = new System.Drawing.Size(146, 20);
            this.textBoxButtonContent.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Button Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Button Content";
            // 
            // MacroX1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 61);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxButtonContent);
            this.Controls.Add(this.textBoxButtonName);
            this.Controls.Add(this.buttonChange);
            this.Name = "MacroX1";
            this.Text = "MacroX1";
            this.Load += new System.EventHandler(this.MacroX1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.TextBox textBoxButtonName;
        private System.Windows.Forms.TextBox textBoxButtonContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}