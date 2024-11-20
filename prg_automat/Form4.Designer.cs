
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
            this.corp_icon = new System.Windows.Forms.PictureBox();
            this.to_pay = new System.Windows.Forms.Label();
            this.drink_price = new System.Windows.Forms.Label();
            this.drink_icon = new System.Windows.Forms.PictureBox();
            this.pay_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.corp_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drink_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // nadpis_2
            // 
            this.nadpis_2.AutoSize = true;
            this.nadpis_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nadpis_2.Location = new System.Drawing.Point(73, 28);
            this.nadpis_2.Name = "nadpis_2";
            this.nadpis_2.Size = new System.Drawing.Size(106, 20);
            this.nadpis_2.TabIndex = 7;
            this.nadpis_2.Text = "Název značky";
            // 
            // corp_icon
            // 
            this.corp_icon.Image = global::prg_automat.Properties.Resources.coca_cola;
            this.corp_icon.Location = new System.Drawing.Point(12, 12);
            this.corp_icon.Name = "corp_icon";
            this.corp_icon.Size = new System.Drawing.Size(55, 55);
            this.corp_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.corp_icon.TabIndex = 8;
            this.corp_icon.TabStop = false;
            // 
            // to_pay
            // 
            this.to_pay.AutoSize = true;
            this.to_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.to_pay.Location = new System.Drawing.Point(199, 230);
            this.to_pay.Name = "to_pay";
            this.to_pay.Size = new System.Drawing.Size(186, 33);
            this.to_pay.TabIndex = 14;
            this.to_pay.Text = "Přiložte kartu";
            // 
            // drink_price
            // 
            this.drink_price.AutoSize = true;
            this.drink_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.drink_price.Location = new System.Drawing.Point(310, 136);
            this.drink_price.Name = "drink_price";
            this.drink_price.Size = new System.Drawing.Size(86, 42);
            this.drink_price.TabIndex = 13;
            this.drink_price.Text = "20,-";
            // 
            // drink_icon
            // 
            this.drink_icon.Image = global::prg_automat.Properties.Resources.coca_cola;
            this.drink_icon.Location = new System.Drawing.Point(173, 96);
            this.drink_icon.Name = "drink_icon";
            this.drink_icon.Size = new System.Drawing.Size(120, 120);
            this.drink_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.drink_icon.TabIndex = 12;
            this.drink_icon.TabStop = false;
            // 
            // pay_button
            // 
            this.pay_button.Location = new System.Drawing.Point(255, 309);
            this.pay_button.Name = "pay_button";
            this.pay_button.Size = new System.Drawing.Size(75, 23);
            this.pay_button.TabIndex = 15;
            this.pay_button.Text = "Zaplatit";
            this.pay_button.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.pay_button);
            this.Controls.Add(this.to_pay);
            this.Controls.Add(this.drink_price);
            this.Controls.Add(this.drink_icon);
            this.Controls.Add(this.corp_icon);
            this.Controls.Add(this.nadpis_2);
            this.Name = "Form4";
            this.Text = "Platba - kartou";
            ((System.ComponentModel.ISupportInitialize)(this.corp_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drink_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox corp_icon;
        private System.Windows.Forms.Label nadpis_2;
        private System.Windows.Forms.Label to_pay;
        private System.Windows.Forms.Label drink_price;
        private System.Windows.Forms.PictureBox drink_icon;
        private System.Windows.Forms.Button pay_button;
    }
}