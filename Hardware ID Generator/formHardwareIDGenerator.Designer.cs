
namespace Hardware_ID_Generator
{
    partial class formHardwareIDGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHardwareIDGenerator));
            this.textBoxHardwareIDGenerator = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxHardwareIDGenerator
            // 
            this.textBoxHardwareIDGenerator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxHardwareIDGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHardwareIDGenerator.ForeColor = System.Drawing.Color.Green;
            this.textBoxHardwareIDGenerator.Location = new System.Drawing.Point(17, 27);
            this.textBoxHardwareIDGenerator.Name = "textBoxHardwareIDGenerator";
            this.textBoxHardwareIDGenerator.ReadOnly = true;
            this.textBoxHardwareIDGenerator.Size = new System.Drawing.Size(500, 34);
            this.textBoxHardwareIDGenerator.TabIndex = 0;
            this.textBoxHardwareIDGenerator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // formHardwareIDGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 89);
            this.Controls.Add(this.textBoxHardwareIDGenerator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formHardwareIDGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hardware ID Generator";
            this.Load += new System.EventHandler(this.formHardwareIDGenerator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHardwareIDGenerator;
    }
}

