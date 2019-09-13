namespace PasswordGenerator
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
            this.rdbtnDefault = new System.Windows.Forms.RadioButton();
            this.rdbtnCustom = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEnterCharacters = new System.Windows.Forms.Label();
            this.txtboxCustomCharSet = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblReady = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtboxPasswordList = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.passwordNumObj = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordLengthObj = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDefaultCharSet = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordNumObj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLengthObj)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbtnDefault
            // 
            this.rdbtnDefault.AutoSize = true;
            this.rdbtnDefault.Checked = true;
            this.rdbtnDefault.Location = new System.Drawing.Point(15, 23);
            this.rdbtnDefault.Name = "rdbtnDefault";
            this.rdbtnDefault.Size = new System.Drawing.Size(127, 17);
            this.rdbtnDefault.TabIndex = 0;
            this.rdbtnDefault.TabStop = true;
            this.rdbtnDefault.Text = "Default Character Set";
            this.rdbtnDefault.UseVisualStyleBackColor = true;
            this.rdbtnDefault.CheckedChanged += new System.EventHandler(this.rdbtnDefault_CheckedChanged);
            // 
            // rdbtnCustom
            // 
            this.rdbtnCustom.AutoSize = true;
            this.rdbtnCustom.Location = new System.Drawing.Point(15, 86);
            this.rdbtnCustom.Name = "rdbtnCustom";
            this.rdbtnCustom.Size = new System.Drawing.Size(128, 17);
            this.rdbtnCustom.TabIndex = 1;
            this.rdbtnCustom.Text = "Custom Character Set";
            this.rdbtnCustom.UseVisualStyleBackColor = true;
            this.rdbtnCustom.CheckedChanged += new System.EventHandler(this.rdbtnCustom_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDefaultCharSet);
            this.groupBox1.Controls.Add(this.lblEnterCharacters);
            this.groupBox1.Controls.Add(this.txtboxCustomCharSet);
            this.groupBox1.Controls.Add(this.rdbtnDefault);
            this.groupBox1.Controls.Add(this.rdbtnCustom);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 167);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 1";
            // 
            // lblEnterCharacters
            // 
            this.lblEnterCharacters.AutoSize = true;
            this.lblEnterCharacters.Enabled = false;
            this.lblEnterCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterCharacters.Location = new System.Drawing.Point(14, 112);
            this.lblEnterCharacters.Name = "lblEnterCharacters";
            this.lblEnterCharacters.Size = new System.Drawing.Size(155, 12);
            this.lblEnterCharacters.TabIndex = 3;
            this.lblEnterCharacters.Text = "Please Enter Characters as One Line";
            // 
            // txtboxCustomCharSet
            // 
            this.txtboxCustomCharSet.Enabled = false;
            this.txtboxCustomCharSet.Location = new System.Drawing.Point(15, 129);
            this.txtboxCustomCharSet.Name = "txtboxCustomCharSet";
            this.txtboxCustomCharSet.Size = new System.Drawing.Size(266, 20);
            this.txtboxCustomCharSet.TabIndex = 2;
            this.txtboxCustomCharSet.TextChanged += new System.EventHandler(this.txtboxCustomCharSet_TextChanged);
            this.txtboxCustomCharSet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtboxCustomCharSet_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblReady);
            this.groupBox3.Controls.Add(this.btnGenerate);
            this.groupBox3.Controls.Add(this.txtboxPasswordList);
            this.groupBox3.Location = new System.Drawing.Point(12, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(590, 253);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step 3";
            // 
            // lblReady
            // 
            this.lblReady.AutoSize = true;
            this.lblReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReady.Location = new System.Drawing.Point(24, 22);
            this.lblReady.Name = "lblReady";
            this.lblReady.Size = new System.Drawing.Size(121, 33);
            this.lblReady.TabIndex = 2;
            this.lblReady.Text = "Ready?";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Enabled = false;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(5, 81);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(164, 164);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtboxPasswordList
            // 
            this.txtboxPasswordList.Location = new System.Drawing.Point(176, 17);
            this.txtboxPasswordList.Multiline = true;
            this.txtboxPasswordList.Name = "txtboxPasswordList";
            this.txtboxPasswordList.ReadOnly = true;
            this.txtboxPasswordList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxPasswordList.Size = new System.Drawing.Size(406, 228);
            this.txtboxPasswordList.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.passwordNumObj);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.passwordLengthObj);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(310, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 167);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 2";
            // 
            // passwordNumObj
            // 
            this.passwordNumObj.Location = new System.Drawing.Point(15, 123);
            this.passwordNumObj.Name = "passwordNumObj";
            this.passwordNumObj.Size = new System.Drawing.Size(53, 20);
            this.passwordNumObj.TabIndex = 3;
            this.passwordNumObj.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.passwordNumObj.ValueChanged += new System.EventHandler(this.passwordNumObj_ValueChanged);
            this.passwordNumObj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordNumObj_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Amount of Passwords To Be Generated:";
            // 
            // passwordLengthObj
            // 
            this.passwordLengthObj.Location = new System.Drawing.Point(15, 61);
            this.passwordLengthObj.Name = "passwordLengthObj";
            this.passwordLengthObj.Size = new System.Drawing.Size(53, 20);
            this.passwordLengthObj.TabIndex = 1;
            this.passwordLengthObj.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.passwordLengthObj.ValueChanged += new System.EventHandler(this.passwordLengthObj_ValueChanged);
            this.passwordLengthObj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordLengthObj_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Password Length:";
            // 
            // lblDefaultCharSet
            // 
            this.lblDefaultCharSet.AutoSize = true;
            this.lblDefaultCharSet.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDefaultCharSet.Location = new System.Drawing.Point(12, 44);
            this.lblDefaultCharSet.Name = "lblDefaultCharSet";
            this.lblDefaultCharSet.Size = new System.Drawing.Size(269, 26);
            this.lblDefaultCharSet.TabIndex = 4;
            this.lblDefaultCharSet.Text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQR\r\nSTUVWXYZ1234567890,./;\'[]\\\\-=()<>?:" +
    "\\\"{}|_+`~";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator Beta <VERSION_NUMBER>";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordNumObj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLengthObj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbtnDefault;
        private System.Windows.Forms.RadioButton rdbtnCustom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEnterCharacters;
        private System.Windows.Forms.TextBox txtboxCustomCharSet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown passwordNumObj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown passwordLengthObj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReady;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtboxPasswordList;
        private System.Windows.Forms.Label lblDefaultCharSet;
    }
}

