namespace prg_automat
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
            this.button1_rob = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1_rob
            // 
            this.button1_rob.Location = new System.Drawing.Point(514, 82);
            this.button1_rob.Name = "button1_rob";
            this.button1_rob.Size = new System.Drawing.Size(75, 23);
            this.button1_rob.TabIndex = 0;
            this.button1_rob.Text = "button1";
            this.button1_rob.UseVisualStyleBackColor = true;
          
            this.button1_lukas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1_lukas
            // 
            this.button1_lukas.Location = new System.Drawing.Point(123, 199);
            this.button1_lukas.Name = "button1_lukas";
            this.button1_lukas.Size = new System.Drawing.Size(75, 23);
            this.button1_lukas.TabIndex = 0;
            this.button1_lukas.Text = "prd";
            this.button1_lukas.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1_rob);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
          
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1_lukas);
          
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1_rob;
        private System.Windows.Forms.Button button1_lukas;
    }
}