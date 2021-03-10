namespace _1_2lab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.creationButton = new System.Windows.Forms.Button();
            this.AsortButton = new System.Windows.Forms.Button();
            this.DsortButton = new System.Windows.Forms.Button();
            this.request1 = new System.Windows.Forms.Button();
            this.request2 = new System.Windows.Forms.Button();
            this.request3 = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.ListBox();
            this.result = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(253, 75);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(124, 38);
            this.textBox.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.Color.Firebrick;
            this.label.Location = new System.Drawing.Point(148, 43);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(328, 29);
            this.label.TabIndex = 1;
            this.label.Text = "Enter the quantity of elements";
            // 
            // creationButton
            // 
            this.creationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.creationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creationButton.ForeColor = System.Drawing.Color.Firebrick;
            this.creationButton.Location = new System.Drawing.Point(253, 130);
            this.creationButton.Name = "creationButton";
            this.creationButton.Size = new System.Drawing.Size(124, 97);
            this.creationButton.TabIndex = 2;
            this.creationButton.Text = "Create collection";
            this.creationButton.UseVisualStyleBackColor = false;
            this.creationButton.Click += new System.EventHandler(this.creationButton_Click);
            // 
            // AsortButton
            // 
            this.AsortButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AsortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AsortButton.ForeColor = System.Drawing.Color.IndianRed;
            this.AsortButton.Location = new System.Drawing.Point(65, 187);
            this.AsortButton.Name = "AsortButton";
            this.AsortButton.Size = new System.Drawing.Size(182, 41);
            this.AsortButton.TabIndex = 3;
            this.AsortButton.Text = "Ascending";
            this.AsortButton.UseVisualStyleBackColor = false;
            this.AsortButton.Click += new System.EventHandler(this.AsortButton_Click);
            // 
            // DsortButton
            // 
            this.DsortButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DsortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DsortButton.ForeColor = System.Drawing.Color.IndianRed;
            this.DsortButton.Location = new System.Drawing.Point(383, 187);
            this.DsortButton.Name = "DsortButton";
            this.DsortButton.Size = new System.Drawing.Size(182, 40);
            this.DsortButton.TabIndex = 4;
            this.DsortButton.Text = "Descending";
            this.DsortButton.UseVisualStyleBackColor = false;
            this.DsortButton.Click += new System.EventHandler(this.DsortButton_Click);
            // 
            // request1
            // 
            this.request1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.request1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.request1.ForeColor = System.Drawing.Color.IndianRed;
            this.request1.Location = new System.Drawing.Point(42, 244);
            this.request1.Name = "request1";
            this.request1.Size = new System.Drawing.Size(182, 40);
            this.request1.TabIndex = 5;
            this.request1.Text = "Request №1";
            this.request1.UseVisualStyleBackColor = false;
            this.request1.Click += new System.EventHandler(this.request1_Click);
            // 
            // request2
            // 
            this.request2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.request2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.request2.ForeColor = System.Drawing.Color.IndianRed;
            this.request2.Location = new System.Drawing.Point(230, 244);
            this.request2.Name = "request2";
            this.request2.Size = new System.Drawing.Size(182, 40);
            this.request2.TabIndex = 6;
            this.request2.Text = "Request №2";
            this.request2.UseVisualStyleBackColor = false;
            this.request2.Click += new System.EventHandler(this.request2_Click);
            // 
            // request3
            // 
            this.request3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.request3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.request3.ForeColor = System.Drawing.Color.IndianRed;
            this.request3.Location = new System.Drawing.Point(418, 244);
            this.request3.Name = "request3";
            this.request3.Size = new System.Drawing.Size(182, 40);
            this.request3.TabIndex = 7;
            this.request3.Text = "Request №3";
            this.request3.UseVisualStyleBackColor = false;
            this.request3.Click += new System.EventHandler(this.request3_Click);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.start.FormattingEnabled = true;
            this.start.ItemHeight = 16;
            this.start.Location = new System.Drawing.Point(32, 307);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(282, 84);
            this.start.TabIndex = 8;
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.result.FormattingEnabled = true;
            this.result.ItemHeight = 16;
            this.result.Location = new System.Drawing.Point(320, 307);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(294, 84);
            this.result.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_1_2lab.Properties.Resources.beautiful_background_with_pink_clouds_sky_1278_71;
            this.ClientSize = new System.Drawing.Size(626, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.start);
            this.Controls.Add(this.request3);
            this.Controls.Add(this.request2);
            this.Controls.Add(this.request1);
            this.Controls.Add(this.DsortButton);
            this.Controls.Add(this.AsortButton);
            this.Controls.Add(this.creationButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "1.2lab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button creationButton;
        private System.Windows.Forms.Button AsortButton;
        private System.Windows.Forms.Button DsortButton;
        private System.Windows.Forms.Button request1;
        private System.Windows.Forms.Button request2;
        private System.Windows.Forms.Button request3;
        private System.Windows.Forms.ListBox start;
        private System.Windows.Forms.ListBox result;
    }
}

