namespace AF_TEST_GUI
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.thermometer1 = new NationalInstruments.UI.WindowsForms.Thermometer();
            this.FW_POWER = new NationalInstruments.UI.WindowsForms.Meter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RW_POWER = new NationalInstruments.UI.WindowsForms.Meter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FW_P_OUT = new System.Windows.Forms.TextBox();
            this.RW_PWR_OUT = new System.Windows.Forms.TextBox();
            this.TMP_OUTPUT = new System.Windows.Forms.TextBox();
            this.switch1 = new NationalInstruments.UI.WindowsForms.Switch();
            this.Jig_lebel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Com_Port_lebel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.thermometer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FW_POWER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RW_POWER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switch1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(52, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_Open
            // 
            this.btn_Open.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Open.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Open.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Open.Location = new System.Drawing.Point(52, 131);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(79, 31);
            this.btn_Open.TabIndex = 1;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = false;
            this.btn_Open.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Close.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Close.Location = new System.Drawing.Point(169, 131);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 31);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.button2_Click);
            // 
            // thermometer1
            // 
            this.thermometer1.Border = NationalInstruments.UI.Border.SolidBlack;
            this.thermometer1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.thermometer1.Location = new System.Drawing.Point(866, 53);
            this.thermometer1.Name = "thermometer1";
            this.thermometer1.Range = new NationalInstruments.UI.Range(-14D, 273D);
            this.thermometer1.Size = new System.Drawing.Size(99, 390);
            this.thermometer1.TabIndex = 4;
            // 
            // FW_POWER
            // 
            this.FW_POWER.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FW_POWER.Border = NationalInstruments.UI.Border.SolidBlack;
            this.FW_POWER.DialColor = System.Drawing.SystemColors.Info;
            this.FW_POWER.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FW_POWER.Location = new System.Drawing.Point(482, 62);
            this.FW_POWER.Name = "FW_POWER";
            this.FW_POWER.Range = new NationalInstruments.UI.Range(0D, 53D);
            this.FW_POWER.Size = new System.Drawing.Size(214, 100);
            this.FW_POWER.SpindleColor = System.Drawing.Color.RosyBrown;
            this.FW_POWER.TabIndex = 5;
            this.FW_POWER.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.FW_POWER_AfterChangeValue);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(47, 338);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(383, 210);
            this.textBox1.TabIndex = 3;
            // 
            // RW_POWER
            // 
            this.RW_POWER.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RW_POWER.Border = NationalInstruments.UI.Border.SolidBlack;
            this.RW_POWER.DialColor = System.Drawing.SystemColors.Info;
            this.RW_POWER.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.RW_POWER.Location = new System.Drawing.Point(495, 296);
            this.RW_POWER.Name = "RW_POWER";
            this.RW_POWER.Range = new NationalInstruments.UI.Range(0D, 53D);
            this.RW_POWER.Size = new System.Drawing.Size(214, 100);
            this.RW_POWER.SpindleColor = System.Drawing.Color.RosyBrown;
            this.RW_POWER.TabIndex = 6;
            this.RW_POWER.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.meter2_AfterChangeValue);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(478, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Forward Power";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(478, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Reverse  Power";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(753, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Temperature";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FW_P_OUT
            // 
            this.FW_P_OUT.Location = new System.Drawing.Point(625, 185);
            this.FW_P_OUT.Name = "FW_P_OUT";
            this.FW_P_OUT.Size = new System.Drawing.Size(100, 22);
            this.FW_P_OUT.TabIndex = 11;
            this.FW_P_OUT.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // RW_PWR_OUT
            // 
            this.RW_PWR_OUT.Location = new System.Drawing.Point(625, 423);
            this.RW_PWR_OUT.Name = "RW_PWR_OUT";
            this.RW_PWR_OUT.Size = new System.Drawing.Size(100, 22);
            this.RW_PWR_OUT.TabIndex = 12;
            // 
            // TMP_OUTPUT
            // 
            this.TMP_OUTPUT.Location = new System.Drawing.Point(902, 478);
            this.TMP_OUTPUT.Name = "TMP_OUTPUT";
            this.TMP_OUTPUT.Size = new System.Drawing.Size(95, 22);
            this.TMP_OUTPUT.TabIndex = 13;
            // 
            // switch1
            // 
            this.switch1.BackColor = System.Drawing.SystemColors.Info;
            this.switch1.Border = NationalInstruments.UI.Border.ThinFrame3D;
            this.switch1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.switch1.Location = new System.Drawing.Point(206, 203);
            this.switch1.Name = "switch1";
            this.switch1.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.switch1.OnColor = System.Drawing.Color.Red;
            this.switch1.Size = new System.Drawing.Size(64, 96);
            this.switch1.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D;
            this.switch1.TabIndex = 14;
            // 
            // Jig_lebel
            // 
            this.Jig_lebel.AutoSize = true;
            this.Jig_lebel.BackColor = System.Drawing.SystemColors.Info;
            this.Jig_lebel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jig_lebel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Jig_lebel.Location = new System.Drawing.Point(52, 233);
            this.Jig_lebel.Name = "Jig_lebel";
            this.Jig_lebel.Size = new System.Drawing.Size(91, 20);
            this.Jig_lebel.TabIndex = 15;
            this.Jig_lebel.Text = "Jig Enable";
            this.Jig_lebel.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(54, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Com Port";
            // 
            // Com_Port_lebel
            // 
            this.Com_Port_lebel.AutoSize = true;
            this.Com_Port_lebel.BackColor = System.Drawing.SystemColors.Info;
            this.Com_Port_lebel.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Com_Port_lebel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Com_Port_lebel.Location = new System.Drawing.Point(48, 315);
            this.Com_Port_lebel.Name = "Com_Port_lebel";
            this.Com_Port_lebel.Size = new System.Drawing.Size(95, 20);
            this.Com_Port_lebel.TabIndex = 17;
            this.Com_Port_lebel.Text = "Serial data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(292, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "ON";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(292, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "OFF";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1022, 616);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Com_Port_lebel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Jig_lebel);
            this.Controls.Add(this.switch1);
            this.Controls.Add(this.TMP_OUTPUT);
            this.Controls.Add(this.RW_PWR_OUT);
            this.Controls.Add(this.FW_P_OUT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RW_POWER);
            this.Controls.Add(this.FW_POWER);
            this.Controls.Add(this.thermometer1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.comboBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thermometer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FW_POWER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RW_POWER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switch1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Button btn_Close;
        private NationalInstruments.UI.WindowsForms.Thermometer thermometer1;
        private NationalInstruments.UI.WindowsForms.Meter FW_POWER;
        private System.Windows.Forms.TextBox textBox1;
        private NationalInstruments.UI.WindowsForms.Meter RW_POWER;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FW_P_OUT;
        private System.Windows.Forms.TextBox RW_PWR_OUT;
        private System.Windows.Forms.TextBox TMP_OUTPUT;
        private NationalInstruments.UI.WindowsForms.Switch switch1;
        private System.Windows.Forms.Label Jig_lebel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Com_Port_lebel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}

