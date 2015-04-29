namespace GabMouseColorPicker
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rbPosition = new System.Windows.Forms.RadioButton();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbBase10 = new System.Windows.Forms.RadioButton();
            this.rbHex = new System.Windows.Forms.RadioButton();
            this.txtCopy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chkAutoCopy = new System.Windows.Forms.CheckBox();
            this.rbMouse = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 148);
            this.panel1.TabIndex = 0;
            // 
            // txtR
            // 
            this.txtR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtR.Location = new System.Drawing.Point(61, 341);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(77, 20);
            this.txtR.TabIndex = 1;
            // 
            // txtG
            // 
            this.txtG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtG.Location = new System.Drawing.Point(61, 367);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(77, 20);
            this.txtG.TabIndex = 2;
            // 
            // txtB
            // 
            this.txtB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB.Location = new System.Drawing.Point(61, 393);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(77, 20);
            this.txtB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "B";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rbPosition
            // 
            this.rbPosition.AutoSize = true;
            this.rbPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbPosition.Location = new System.Drawing.Point(12, 179);
            this.rbPosition.Name = "rbPosition";
            this.rbPosition.Size = new System.Drawing.Size(87, 17);
            this.rbPosition.TabIndex = 8;
            this.rbPosition.Text = "This location:";
            this.rbPosition.UseVisualStyleBackColor = true;
            // 
            // txtX
            // 
            this.txtX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtX.Enabled = false;
            this.txtX.Location = new System.Drawing.Point(61, 207);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(77, 20);
            this.txtX.TabIndex = 9;
            this.txtX.Text = "0";
            // 
            // txtY
            // 
            this.txtY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtY.Enabled = false;
            this.txtY.Location = new System.Drawing.Point(61, 231);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(76, 20);
            this.txtY.TabIndex = 10;
            this.txtY.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Y";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.rbBase10);
            this.panel2.Controls.Add(this.rbHex);
            this.panel2.Location = new System.Drawing.Point(9, 281);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 49);
            this.panel2.TabIndex = 13;
            // 
            // rbBase10
            // 
            this.rbBase10.AutoSize = true;
            this.rbBase10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbBase10.Location = new System.Drawing.Point(3, 26);
            this.rbBase10.Name = "rbBase10";
            this.rbBase10.Size = new System.Drawing.Size(97, 17);
            this.rbBase10.TabIndex = 1;
            this.rbBase10.Text = "Base 10 values";
            this.rbBase10.UseVisualStyleBackColor = true;
            // 
            // rbHex
            // 
            this.rbHex.AutoSize = true;
            this.rbHex.Checked = global::GabMouseColorPicker.Properties.Settings.Default.GMCPSetting_General_HexValues;
            this.rbHex.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GabMouseColorPicker.Properties.Settings.Default, "GMCPSetting_General_HexValues", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rbHex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbHex.Location = new System.Drawing.Point(3, 3);
            this.rbHex.Name = "rbHex";
            this.rbHex.Size = new System.Drawing.Size(119, 17);
            this.rbHex.TabIndex = 0;
            this.rbHex.TabStop = true;
            this.rbHex.Text = "Hexadecimal values";
            this.rbHex.UseVisualStyleBackColor = true;
            // 
            // txtCopy
            // 
            this.txtCopy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCopy.Location = new System.Drawing.Point(9, 419);
            this.txtCopy.Name = "txtCopy";
            this.txtCopy.Size = new System.Drawing.Size(129, 20);
            this.txtCopy.TabIndex = 14;
            this.txtCopy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCopy_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "CTRL+Space : Stop/Resume\r\ncapture";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblStatus.Location = new System.Drawing.Point(98, 158);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "Active";
            // 
            // chkAutoCopy
            // 
            this.chkAutoCopy.AutoSize = true;
            this.chkAutoCopy.Checked = global::GabMouseColorPicker.Properties.Settings.Default.GMCPSetting_General_AutoCopy;
            this.chkAutoCopy.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GabMouseColorPicker.Properties.Settings.Default, "GMCPSetting_General_AutoCopy", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkAutoCopy.Location = new System.Drawing.Point(9, 445);
            this.chkAutoCopy.Name = "chkAutoCopy";
            this.chkAutoCopy.Size = new System.Drawing.Size(132, 17);
            this.chkAutoCopy.TabIndex = 18;
            this.chkAutoCopy.Text = "Auto copy to clipboard";
            this.chkAutoCopy.UseVisualStyleBackColor = true;
            // 
            // rbMouse
            // 
            this.rbMouse.AutoSize = true;
            this.rbMouse.Checked = global::GabMouseColorPicker.Properties.Settings.Default.GMCPSetting_General_MousePointer;
            this.rbMouse.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GabMouseColorPicker.Properties.Settings.Default, "GMCPSetting_General_MousePointer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rbMouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbMouse.Location = new System.Drawing.Point(12, 156);
            this.rbMouse.Name = "rbMouse";
            this.rbMouse.Size = new System.Drawing.Size(91, 17);
            this.rbMouse.TabIndex = 7;
            this.rbMouse.TabStop = true;
            this.rbMouse.Text = "Mouse pointer";
            this.rbMouse.UseVisualStyleBackColor = true;
            this.rbMouse.CheckedChanged += new System.EventHandler(this.rbMouse_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(151, 511);
            this.Controls.Add(this.chkAutoCopy);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCopy);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.rbPosition);
            this.Controls.Add(this.rbMouse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gab Mouse Color Picker";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_Closing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rbMouse;
        private System.Windows.Forms.RadioButton rbPosition;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbBase10;
        private System.Windows.Forms.RadioButton rbHex;
        private System.Windows.Forms.TextBox txtCopy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chkAutoCopy;
    }
}

