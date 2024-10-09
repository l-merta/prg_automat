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
            this.automat_name = new System.Windows.Forms.Label();
            this.nadpis_1 = new System.Windows.Forms.Label();
            this.piti_1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.piti_1)).BeginInit();
            this.SuspendLayout();
            // 
            // automat_name
            // 
            this.automat_name.AutoSize = true;
            this.automat_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.automat_name.Location = new System.Drawing.Point(273, 9);
            this.automat_name.Name = "automat_name";
            this.automat_name.Size = new System.Drawing.Size(94, 24);
            this.automat_name.TabIndex = 0;
            this.automat_name.Text = "PIçOMAT";
            // 
            // nadpis_1
            // 
            this.nadpis_1.AutoSize = true;
            this.nadpis_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nadpis_1.Location = new System.Drawing.Point(202, 33);
            this.nadpis_1.Name = "nadpis_1";
            this.nadpis_1.Size = new System.Drawing.Size(232, 31);
            this.nadpis_1.TabIndex = 1;
            this.nadpis_1.Text = "VYBERTE SI PITÕ";
            // 
            // piti_1
            // 
            this.piti_1.Image = global::prg_automat.Properties.Resources.cola;
            this.piti_1.InitialImage = global::prg_automat.Properties.Resources.cola;
            this.piti_1.Location = new System.Drawing.Point(66, 91);
            this.piti_1.Name = "piti_1";
            this.piti_1.Size = new System.Drawing.Size(120, 120);
            this.piti_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piti_1.TabIndex = 3;
            this.piti_1.TabStop = false;
            this.piti_1.Click += new System.EventHandler(this.piti_1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 606);
            this.Controls.Add(this.piti_1);
            this.Controls.Add(this.nadpis_1);
            this.Controls.Add(this.automat_name);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.piti_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label automat_name;
        private System.Windows.Forms.Label nadpis_1;
        private System.Windows.Forms.PictureBox piti_1;
    }
}