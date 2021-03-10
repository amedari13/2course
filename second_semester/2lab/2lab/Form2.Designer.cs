namespace _2lab
{
    partial class Form2
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
            this.locationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // locationButton
            // 
            this.locationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.locationButton.Location = new System.Drawing.Point(46, 46);
            this.locationButton.Name = "locationButton";
            this.locationButton.Size = new System.Drawing.Size(281, 71);
            this.locationButton.TabIndex = 0;
            this.locationButton.Text = "Enter your location";
            this.locationButton.UseVisualStyleBackColor = true;
            this.locationButton.Click += new System.EventHandler(this.locationButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 174);
            this.Controls.Add(this.locationButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button locationButton;
    }
}