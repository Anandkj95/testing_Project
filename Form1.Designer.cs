namespace AmProcess
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
            this.btn_Testing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Testing
            // 
            this.btn_Testing.Location = new System.Drawing.Point(302, 260);
            this.btn_Testing.Name = "btn_Testing";
            this.btn_Testing.Size = new System.Drawing.Size(169, 50);
            this.btn_Testing.TabIndex = 0;
            this.btn_Testing.Text = "Testing";
            this.btn_Testing.UseVisualStyleBackColor = true;
            this.btn_Testing.Click += new System.EventHandler(this.btn_Testing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Testing);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Testing;
    }
}

