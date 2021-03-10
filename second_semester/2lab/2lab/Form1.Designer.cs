namespace _2lab
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ageBar = new System.Windows.Forms.TrackBar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioGroupBox = new System.Windows.Forms.GroupBox();
            this.ISS_for_MS = new System.Windows.Forms.RadioButton();
            this.ITS = new System.Windows.Forms.RadioButton();
            this.DE_and_Wp = new System.Windows.Forms.RadioButton();
            this.IS_and_T = new System.Windows.Forms.RadioButton();
            this.takePlacebutton = new System.Windows.Forms.Button();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.readNwriteButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.GPATextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ageBar)).BeginInit();
            this.radioGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(13, 13);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(143, 20);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Text = "Full name";
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBox_KeyPress);
            // 
            // ageBar
            // 
            this.ageBar.Location = new System.Drawing.Point(13, 39);
            this.ageBar.Maximum = 35;
            this.ageBar.Minimum = 18;
            this.ageBar.Name = "ageBar";
            this.ageBar.Size = new System.Drawing.Size(143, 45);
            this.ageBar.TabIndex = 1;
            this.ageBar.Value = 18;
            this.ageBar.Scroll += new System.EventHandler(this.AgeBar_Scroll);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(162, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // radioGroupBox
            // 
            this.radioGroupBox.Controls.Add(this.ISS_for_MS);
            this.radioGroupBox.Controls.Add(this.ITS);
            this.radioGroupBox.Controls.Add(this.DE_and_Wp);
            this.radioGroupBox.Controls.Add(this.IS_and_T);
            this.radioGroupBox.Location = new System.Drawing.Point(13, 90);
            this.radioGroupBox.Name = "radioGroupBox";
            this.radioGroupBox.Size = new System.Drawing.Size(143, 110);
            this.radioGroupBox.TabIndex = 3;
            this.radioGroupBox.TabStop = false;
            this.radioGroupBox.Text = "Specialization";
            this.radioGroupBox.Validated += new System.EventHandler(this.radioGroupBox_Validated);
            // 
            // ISS_for_MS
            // 
            this.ISS_for_MS.AutoSize = true;
            this.ISS_for_MS.Location = new System.Drawing.Point(6, 84);
            this.ISS_for_MS.Name = "ISS_for_MS";
            this.ISS_for_MS.Size = new System.Drawing.Size(76, 17);
            this.ISS_for_MS.TabIndex = 3;
            this.ISS_for_MS.TabStop = true;
            this.ISS_for_MS.Text = "ISS for MS";
            this.ISS_for_MS.UseVisualStyleBackColor = true;
            // 
            // ITS
            // 
            this.ITS.AutoSize = true;
            this.ITS.Location = new System.Drawing.Point(6, 38);
            this.ITS.Name = "ITS";
            this.ITS.Size = new System.Drawing.Size(42, 17);
            this.ITS.TabIndex = 1;
            this.ITS.TabStop = true;
            this.ITS.Text = "ITS";
            this.ITS.UseVisualStyleBackColor = true;
            // 
            // DE_and_Wp
            // 
            this.DE_and_Wp.AutoSize = true;
            this.DE_and_Wp.Location = new System.Drawing.Point(6, 15);
            this.DE_and_Wp.Name = "DE_and_Wp";
            this.DE_and_Wp.Size = new System.Drawing.Size(81, 17);
            this.DE_and_Wp.TabIndex = 0;
            this.DE_and_Wp.TabStop = true;
            this.DE_and_Wp.Text = "DE and Wp";
            this.DE_and_Wp.UseVisualStyleBackColor = true;
            // 
            // IS_and_T
            // 
            this.IS_and_T.AutoSize = true;
            this.IS_and_T.Location = new System.Drawing.Point(6, 61);
            this.IS_and_T.Name = "IS_and_T";
            this.IS_and_T.Size = new System.Drawing.Size(66, 17);
            this.IS_and_T.TabIndex = 2;
            this.IS_and_T.TabStop = true;
            this.IS_and_T.Text = "IS and T";
            this.IS_and_T.UseVisualStyleBackColor = true;
            // 
            // takePlacebutton
            // 
            this.takePlacebutton.Location = new System.Drawing.Point(12, 206);
            this.takePlacebutton.Name = "takePlacebutton";
            this.takePlacebutton.Size = new System.Drawing.Size(307, 23);
            this.takePlacebutton.TabIndex = 4;
            this.takePlacebutton.Text = "Get location";
            this.takePlacebutton.UseVisualStyleBackColor = true;
            this.takePlacebutton.Click += new System.EventHandler(this.LocationButton_Click);
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel.Location = new System.Drawing.Point(10, 329);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(59, 13);
            this.linkLabel.TabIndex = 5;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "GitHub link";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(162, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Personal projects";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(162, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 110);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Validated += new System.EventHandler(this.groupBox2_Validated);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(3, 84);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(73, 17);
            this.checkBox4.TabIndex = 10;
            this.checkBox4.Text = "High GPA";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(3, 61);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(141, 17);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "Good personal strengths";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(3, 38);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(125, 17);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Work experience > 2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 260);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(307, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save the result";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // readNwriteButton
            // 
            this.readNwriteButton.Location = new System.Drawing.Point(12, 290);
            this.readNwriteButton.Name = "readNwriteButton";
            this.readNwriteButton.Size = new System.Drawing.Size(307, 23);
            this.readNwriteButton.TabIndex = 10;
            this.readNwriteButton.Text = "Read all the information from the file";
            this.readNwriteButton.UseVisualStyleBackColor = true;
            this.readNwriteButton.Click += new System.EventHandler(this.ReadNwriteButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultTextBox.Location = new System.Drawing.Point(335, 13);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(203, 300);
            this.resultTextBox.TabIndex = 11;
            // 
            // GPATextBox
            // 
            this.GPATextBox.Location = new System.Drawing.Point(207, 64);
            this.GPATextBox.Mask = "0";
            this.GPATextBox.Name = "GPATextBox";
            this.GPATextBox.Size = new System.Drawing.Size(112, 20);
            this.GPATextBox.TabIndex = 12;
            this.GPATextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.GPATextBox_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(162, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "GPA is";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_2lab.Properties.Resources.preview_16_9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 351);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GPATextBox);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.readNwriteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.takePlacebutton);
            this.Controls.Add(this.radioGroupBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ageBar);
            this.Controls.Add(this.nameTextBox);
            this.MinimumSize = new System.Drawing.Size(566, 376);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Second work";
            ((System.ComponentModel.ISupportInitialize)(this.ageBar)).EndInit();
            this.radioGroupBox.ResumeLayout(false);
            this.radioGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TrackBar ageBar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox radioGroupBox;
        private System.Windows.Forms.RadioButton ISS_for_MS;
        private System.Windows.Forms.RadioButton ITS;
        private System.Windows.Forms.RadioButton DE_and_Wp;
        private System.Windows.Forms.RadioButton IS_and_T;
        private System.Windows.Forms.Button takePlacebutton;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button readNwriteButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.MaskedTextBox GPATextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

