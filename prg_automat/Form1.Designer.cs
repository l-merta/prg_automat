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
            this.button_sprite = new System.Windows.Forms.PictureBox();
            this.button_minute_maid = new System.Windows.Forms.PictureBox();
            this.button_fuze_tea = new System.Windows.Forms.PictureBox();
            this.button_fanta = new System.Windows.Forms.PictureBox();
            this.button_cola = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.button_sprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_minute_maid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_fuze_tea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_fanta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_cola)).BeginInit();
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
            // button_sprite
            // 
            this.button_sprite.Image = global::prg_automat.Properties.Resources.sprite;
            this.button_sprite.InitialImage = global::prg_automat.Properties.Resources.cola;
            this.button_sprite.Location = new System.Drawing.Point(417, 103);
            this.button_sprite.Name = "button_sprite";
            this.button_sprite.Size = new System.Drawing.Size(120, 120);
            this.button_sprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_sprite.TabIndex = 7;
            this.button_sprite.TabStop = false;
            this.button_sprite.Click += new System.EventHandler(this.button_sprite_Click);
            // 
            // button_minute_maid
            // 
            this.button_minute_maid.Image = global::prg_automat.Properties.Resources.minute_maid;
            this.button_minute_maid.InitialImage = global::prg_automat.Properties.Resources.cola;
            this.button_minute_maid.Location = new System.Drawing.Point(341, 258);
            this.button_minute_maid.Name = "button_minute_maid";
            this.button_minute_maid.Size = new System.Drawing.Size(120, 120);
            this.button_minute_maid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_minute_maid.TabIndex = 6;
            this.button_minute_maid.TabStop = false;
            this.button_minute_maid.Click += new System.EventHandler(this.button_minute_maid_Click);
            // 
            // button_fuze_tea
            // 
            this.button_fuze_tea.Image = global::prg_automat.Properties.Resources.fuze_tea;
            this.button_fuze_tea.InitialImage = global::prg_automat.Properties.Resources.cola;
            this.button_fuze_tea.Location = new System.Drawing.Point(177, 258);
            this.button_fuze_tea.Name = "button_fuze_tea";
            this.button_fuze_tea.Size = new System.Drawing.Size(120, 120);
            this.button_fuze_tea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_fuze_tea.TabIndex = 5;
            this.button_fuze_tea.TabStop = false;
            this.button_fuze_tea.Click += new System.EventHandler(this.button_fuze_tea_Click);
            // 
            // button_fanta
            // 
            this.button_fanta.Image = global::prg_automat.Properties.Resources.fanta;
            this.button_fanta.InitialImage = global::prg_automat.Properties.Resources.cola;
            this.button_fanta.Location = new System.Drawing.Point(98, 103);
            this.button_fanta.Name = "button_fanta";
            this.button_fanta.Size = new System.Drawing.Size(120, 120);
            this.button_fanta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_fanta.TabIndex = 4;
            this.button_fanta.TabStop = false;
            this.button_fanta.Click += new System.EventHandler(this.button_fanta_Click);
            // 
            // button_cola
            // 
            this.button_cola.Image = global::prg_automat.Properties.Resources.cola;
            this.button_cola.InitialImage = global::prg_automat.Properties.Resources.cola;
            this.button_cola.Location = new System.Drawing.Point(258, 103);
            this.button_cola.Name = "button_cola";
            this.button_cola.Size = new System.Drawing.Size(120, 120);
            this.button_cola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_cola.TabIndex = 3;
            this.button_cola.TabStop = false;
            this.button_cola.Click += new System.EventHandler(this.button_cola_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 606);
            this.Controls.Add(this.button_sprite);
            this.Controls.Add(this.button_minute_maid);
            this.Controls.Add(this.button_fuze_tea);
            this.Controls.Add(this.button_fanta);
            this.Controls.Add(this.button_cola);
            this.Controls.Add(this.nadpis_1);
            this.Controls.Add(this.automat_name);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.button_sprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_minute_maid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_fuze_tea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_fanta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button_cola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label automat_name;
        private System.Windows.Forms.Label nadpis_1;
        private System.Windows.Forms.PictureBox button_cola;
        private System.Windows.Forms.PictureBox button_fanta;
        private System.Windows.Forms.PictureBox button_fuze_tea;
        private System.Windows.Forms.PictureBox button_minute_maid;
        private System.Windows.Forms.PictureBox button_sprite;
    }
}