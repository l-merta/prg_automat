
namespace prg_automat
{
    partial class Form4
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
            this.to_pay = new System.Windows.Forms.Label();
            this.drink_price = new System.Windows.Forms.Label();
            this.button_terminal = new System.Windows.Forms.PictureBox();
            this.drink_icon = new System.Windows.Forms.PictureBox();
            this.corp_icon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.button_terminal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drink_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corp_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nadpis_2
            // 
            this.nadpis_2.AutoSize = true;
            this.nadpis_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nadpis_2.Location = new System.Drawing.Point(89, 43);
            this.nadpis_2.Name = "nadpis_2";
            this.nadpis_2.Size = new System.Drawing.Size(106, 20);
            this.nadpis_2.TabIndex = 7;
            this.nadpis_2.Text = "Název značky";
            // 
            // to_pay
            // 
            this.to_pay.AutoSize = true;
            this.to_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.to_pay.Location = new System.Drawing.Point(144, 228);
            this.to_pay.Name = "to_pay";
            this.to_pay.Size = new System.Drawing.Size(186, 33);
            this.to_pay.TabIndex = 14;
            this.to_pay.Text = "Přiložte kartu";
            // 
            // drink_price
            // 
            this.drink_price.AutoSize = true;
            this.drink_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.drink_price.Location = new System.Drawing.Point(255, 134);
            this.drink_price.Name = "drink_price";
            this.drink_price.Size = new System.Drawing.Size(86, 42);
            this.drink_price.TabIndex = 13;
            this.drink_price.Text = "20,-";
            // 
            // button_terminal
            // 
            this.button_terminal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_terminal.Image = global::prg_automat.Properties.Resources.platebni_terminal;
            this.button_terminal.Location = new System.Drawing.Point(155, 280);
            this.button_terminal.Name = "button_terminal";
            this.button_terminal.Size = new System.Drawing.Size(150, 150);
            this.button_terminal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_terminal.TabIndex = 26;
            this.button_terminal.TabStop = false;
            this.button_terminal.Click += new System.EventHandler(this.button_terminal_Click);
            // 
            // drink_icon
            // 
            this.drink_icon.Image = global::prg_automat.Properties.Resources.coca_cola;
            this.drink_icon.Location = new System.Drawing.Point(118, 94);
            this.drink_icon.Name = "drink_icon";
            this.drink_icon.Size = new System.Drawing.Size(120, 120);
            this.drink_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.drink_icon.TabIndex = 12;
            this.drink_icon.TabStop = false;
            // 
            // corp_icon
            // 
            this.corp_icon.Image = global::prg_automat.Properties.Resources.coca_cola;
            this.corp_icon.Location = new System.Drawing.Point(28, 27);
            this.corp_icon.Name = "corp_icon";
            this.corp_icon.Size = new System.Drawing.Size(55, 55);
            this.corp_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.corp_icon.TabIndex = 8;
            this.corp_icon.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::prg_automat.Properties.Resources.bg_automat;
            this.pictureBox1.InitialImage = global::prg_automat.Properties.Resources.fanta;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(461, 612);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.Firebrick;
            this.button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_close.ForeColor = System.Drawing.Color.White;
            this.button_close.Location = new System.Drawing.Point(406, 32);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(29, 26);
            this.button_close.TabIndex = 27;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 611);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_terminal);
            this.Controls.Add(this.to_pay);
            this.Controls.Add(this.drink_price);
            this.Controls.Add(this.drink_icon);
            this.Controls.Add(this.corp_icon);
            this.Controls.Add(this.nadpis_2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form4";
            this.Text = "Platba - kartou";
            ((System.ComponentModel.ISupportInitialize)(this.button_terminal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drink_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corp_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox corp_icon;
        private System.Windows.Forms.Label nadpis_2;
        private System.Windows.Forms.Label to_pay;
        private System.Windows.Forms.Label drink_price;
        private System.Windows.Forms.PictureBox drink_icon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox button_terminal;
        private System.Windows.Forms.Button button_close;
    }
}