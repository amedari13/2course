using System.Windows.Forms;

namespace _3lab
{
    partial class FindNSort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindNSort));
            this.FIND = new System.Windows.Forms.Button();
            this.SORT = new System.Windows.Forms.Button();
            this.SAVE = new System.Windows.Forms.Button();
            this.INFO = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.FINDtext = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.FIND_textBox = new System.Windows.Forms.TextBox();
            this.SORT_textBox = new System.Windows.Forms.TextBox();
            this.SAVE_textBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.FINDtoolStrip = new System.Windows.Forms.ToolStripButton();
            this.SORTtoolStrip = new System.Windows.Forms.ToolStripButton();
            this.SAVEtoolStrip = new System.Windows.Forms.ToolStripButton();
            this.INFOtoolStrip = new System.Windows.Forms.ToolStripButton();
            this.CLEARtoolStrip = new System.Windows.Forms.ToolStripButton();
            this.DELETEtoolStrip = new System.Windows.Forms.ToolStripButton();
            this.DOWNLOADtoolStrip = new System.Windows.Forms.ToolStripButton();

            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();


            ///добавленное
            infoLabel = new ToolStripLabel();
            infoLabel.Text = "Date and time: ";
            dateLabel = new ToolStripLabel();
            quantityLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();

            statusStrip1.Items.Add(infoLabel);
            statusStrip1.Items.Add(dateLabel);
            statusStrip1.Items.Add(timeLabel);
            statusStrip1.Items.Add(quantityLabel);

            timer = new System.Windows.Forms.Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();



            // 
            // FIND
            // 
            this.FIND.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FIND.Location = new System.Drawing.Point(9, 10);
            this.FIND.Margin = new System.Windows.Forms.Padding(2);
            this.FIND.Name = "FIND";
            this.FIND.Size = new System.Drawing.Size(130, 82);
            this.FIND.TabIndex = 0;
            this.FIND.Text = "Find";
            this.FIND.UseVisualStyleBackColor = true;
            this.FIND.Click += new System.EventHandler(this.FIND_Click);
            // 
            // SORT
            // 
            this.SORT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.SORT.Location = new System.Drawing.Point(9, 107);
            this.SORT.Margin = new System.Windows.Forms.Padding(2);
            this.SORT.Name = "SORT";
            this.SORT.Size = new System.Drawing.Size(130, 85);
            this.SORT.TabIndex = 1;
            this.SORT.Text = "Sort";
            this.SORT.UseVisualStyleBackColor = true;
            this.SORT.Click += new System.EventHandler(this.SORT_Click);
            // 
            // SAVE
            // 
            this.SAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.SAVE.Location = new System.Drawing.Point(9, 208);
            this.SAVE.Margin = new System.Windows.Forms.Padding(2);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(130, 89);
            this.SAVE.TabIndex = 2;
            this.SAVE.Text = "Save";
            this.SAVE.UseVisualStyleBackColor = true;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // INFO
            // 
            this.INFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.INFO.Location = new System.Drawing.Point(9, 314);
            this.INFO.Margin = new System.Windows.Forms.Padding(2);
            this.INFO.Name = "INFO";
            this.INFO.Size = new System.Drawing.Size(130, 86);
            this.INFO.TabIndex = 3;
            this.INFO.Text = "INFO";
            this.INFO.UseVisualStyleBackColor = true;
            this.INFO.Click += new System.EventHandler(this.INFO_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Name",
            "Specialization",
            "GPA"});
            this.comboBox1.Location = new System.Drawing.Point(158, 10);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // FINDtext
            // 
            this.FINDtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FINDtext.Location = new System.Drawing.Point(158, 66);
            this.FINDtext.Margin = new System.Windows.Forms.Padding(2);
            this.FINDtext.Name = "FINDtext";
            this.FINDtext.Size = new System.Drawing.Size(147, 27);
            this.FINDtext.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Age (Ascending)",
            "Age (Descending)",
            "GPU (Ascending)",
            "GPU (Descending)"});
            this.comboBox2.Location = new System.Drawing.Point(158, 107);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(147, 28);
            this.comboBox2.TabIndex = 6;
            // 
            // FIND_textBox
            // 
            this.FIND_textBox.Location = new System.Drawing.Point(401, 10);
            this.FIND_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.FIND_textBox.Multiline = true;
            this.FIND_textBox.Name = "FIND_textBox";
            this.FIND_textBox.ReadOnly = true;
            this.FIND_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FIND_textBox.Size = new System.Drawing.Size(253, 83);
            this.FIND_textBox.TabIndex = 7;
            // 
            // SORT_textBox
            // 
            this.SORT_textBox.Location = new System.Drawing.Point(401, 107);
            this.SORT_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.SORT_textBox.Multiline = true;
            this.SORT_textBox.Name = "SORT_textBox";
            this.SORT_textBox.ReadOnly = true;
            this.SORT_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SORT_textBox.Size = new System.Drawing.Size(253, 86);
            this.SORT_textBox.TabIndex = 8;
            // 
            // SAVE_textBox
            // 
            this.SAVE_textBox.Location = new System.Drawing.Point(401, 208);
            this.SAVE_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.SAVE_textBox.Multiline = true;
            this.SAVE_textBox.Name = "SAVE_textBox";
            this.SAVE_textBox.ReadOnly = true;
            this.SAVE_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SAVE_textBox.Size = new System.Drawing.Size(253, 89);
            this.SAVE_textBox.TabIndex = 9;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 406);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(687, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FINDtoolStrip,
            this.SORTtoolStrip,
            this.SAVEtoolStrip,
            this.INFOtoolStrip,
            this.CLEARtoolStrip,
            this.DELETEtoolStrip,
            this.DOWNLOADtoolStrip});
            this.toolStrip1.Location = new System.Drawing.Point(655, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(32, 406);
            this.toolStrip1.TabIndex = 11;
            // 
            // FINDtoolStrip
            // 
            this.FINDtoolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FINDtoolStrip.Image = ((System.Drawing.Image)(resources.GetObject("FINDtoolStrip.Image")));
            this.FINDtoolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FINDtoolStrip.Name = "FINDtoolStrip";
            this.FINDtoolStrip.Size = new System.Drawing.Size(29, 20);
            this.FINDtoolStrip.Text = "Find element in collection";
            this.FINDtoolStrip.Click += new System.EventHandler(this.FINDtoolStrip_Click);
            // 
            // SORTtoolStrip
            // 
            this.SORTtoolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SORTtoolStrip.Image = ((System.Drawing.Image)(resources.GetObject("SORTtoolStrip.Image")));
            this.SORTtoolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SORTtoolStrip.Name = "SORTtoolStrip";
            this.SORTtoolStrip.Size = new System.Drawing.Size(29, 20);
            this.SORTtoolStrip.Text = "Sort collection";
            this.SORTtoolStrip.Click += new System.EventHandler(this.SORTtoolStrip_Click);
            // 
            // SAVEtoolStrip
            // 
            this.SAVEtoolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SAVEtoolStrip.Image = ((System.Drawing.Image)(resources.GetObject("SAVEtoolStrip.Image")));
            this.SAVEtoolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SAVEtoolStrip.Name = "SAVEtoolStrip";
            this.SAVEtoolStrip.Size = new System.Drawing.Size(29, 20);
            this.SAVEtoolStrip.Text = "Save to file";
            this.SAVEtoolStrip.Click += new System.EventHandler(this.SAVEtoolStrip_Click);
            // 
            // INFOtoolStrip
            // 
            this.INFOtoolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.INFOtoolStrip.Image = ((System.Drawing.Image)(resources.GetObject("INFOtoolStrip.Image")));
            this.INFOtoolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.INFOtoolStrip.Name = "INFOtoolStrip";
            this.INFOtoolStrip.Size = new System.Drawing.Size(29, 20);
            this.INFOtoolStrip.Text = "Information";
            this.INFOtoolStrip.Click += new System.EventHandler(this.INFOtoolStrip_Click);
            // 
            // CLEARtoolStrip
            // 
            this.CLEARtoolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CLEARtoolStrip.Image = ((System.Drawing.Image)(resources.GetObject("CLEARtoolStrip.Image")));
            this.CLEARtoolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CLEARtoolStrip.Name = "CLEARtoolStrip";
            this.CLEARtoolStrip.Size = new System.Drawing.Size(29, 20);
            this.CLEARtoolStrip.Text = "Clear all textboxes";
            this.CLEARtoolStrip.Click += new System.EventHandler(this.CLEARtoolStrip_Click);
            // 
            // DELETEtoolStrip
            // 
            this.DELETEtoolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DELETEtoolStrip.Image = ((System.Drawing.Image)(resources.GetObject("DELETEtoolStrip.Image")));
            this.DELETEtoolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DELETEtoolStrip.Name = "DELETEtoolStrip";
            this.DELETEtoolStrip.Size = new System.Drawing.Size(29, 20);
            this.DELETEtoolStrip.Text = "Delete collection";
            this.DELETEtoolStrip.Click += new System.EventHandler(this.DELETEtoolStrip_Click);
            // 
            // DOWNLOADtoolStrip
            // 
            this.DOWNLOADtoolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DOWNLOADtoolStrip.Image = ((System.Drawing.Image)(resources.GetObject("DOWNLOADtoolStrip.Image")));
            this.DOWNLOADtoolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DOWNLOADtoolStrip.Name = "DOWNLOADtoolStrip";
            this.DOWNLOADtoolStrip.Size = new System.Drawing.Size(29, 20);
            this.DOWNLOADtoolStrip.Text = "Download collection";
            this.DOWNLOADtoolStrip.Click += new System.EventHandler(this.DOWNLOADtoolStrip_Click);
            // 
            // FindNSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 428);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.SAVE_textBox);
            this.Controls.Add(this.SORT_textBox);
            this.Controls.Add(this.FIND_textBox);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.FINDtext);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.INFO);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.SORT);
            this.Controls.Add(this.FIND);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FindNSort";
            this.Text = "FindNSort";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FIND;
        private System.Windows.Forms.Button SORT;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.Button INFO;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox FINDtext;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox FIND_textBox;
        private System.Windows.Forms.TextBox SORT_textBox;
        private System.Windows.Forms.TextBox SAVE_textBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton FINDtoolStrip;
        private System.Windows.Forms.ToolStripButton SORTtoolStrip;
        private System.Windows.Forms.ToolStripButton SAVEtoolStrip;
        private System.Windows.Forms.ToolStripButton INFOtoolStrip;
        private System.Windows.Forms.ToolStripButton CLEARtoolStrip;
        private System.Windows.Forms.ToolStripButton DELETEtoolStrip;
        private System.Windows.Forms.ToolStripButton DOWNLOADtoolStrip;

        //добавленное
        ToolStripLabel dateLabel;
        ToolStripLabel timeLabel;
        ToolStripLabel infoLabel;
        ToolStripLabel quantityLabel;
        System.Windows.Forms.Timer timer;

    }
}