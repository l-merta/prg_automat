
namespace prg_automat
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
            this.nadpis_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nadpis_2
            // 
            this.nadpis_2.AutoSize = true;
            this.nadpis_2.Location = new System.Drawing.Point(58, 19);
            this.nadpis_2.Name = "nadpis_2";
            this.nadpis_2.Size = new System.Drawing.Size(67, 13);
            this.nadpis_2.TabIndex = 0;
            this.nadpis_2.Text = "Možnosti pití";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.nadpis_2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nadpis_2;
    }
}