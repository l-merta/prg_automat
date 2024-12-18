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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_sprite = new System.Windows.Forms.PictureBox();
            this.button_minute_maid = new System.Windows.Forms.PictureBox();
            this.button_fuze_tea = new System.Windows.Forms.PictureBox();
            this.button_fanta = new System.Windows.Forms.PictureBox();
            this.button_cola = new System.Windows.Forms.PictureBox();
            this.button_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.automat_name.Location = new System.Drawing.Point(185, 31);
            this.automat_name.Name = "automat_name";
            this.automat_name.Size = new System.Drawing.Size(94, 24);
            this.automat_name.TabIndex = 0;
            this.automat_name.Text = "PIçOMAT";
            // 
            // nadpis_1
            // 
            this.nadpis_1.AutoSize = true;
            this.nadpis_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nadpis_1.Location = new System.Drawing.Point(114, 55);
            this.nadpis_1.Name = "nadpis_1";
            this.nadpis_1.Size = new System.Drawing.Size(232, 31);
            this.nadpis_1.TabIndex = 1;
            this.nadpis_1.Text = "VYBERTE SI PITÕ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::prg_automat.Properties.Resources.bg_automat;
            this.pictureBox1.InitialImage = global::prg_automat.Properties.Resources.fanta;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(461, 612);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button_sprite
            // 
            this.button_sprite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_sprite.Image = global::prg_automat.Properties.Resources.sprite;
            this.button_sprite.InitialImage = global::prg_automat.Properties.Resources.sprite;
            this.button_sprite.Location = new System.Drawing.Point(293, 113);
            this.button_sprite.Name = "button_sprite";
            this.button_sprite.Size = new System.Drawing.Size(100, 100);
            this.button_sprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_sprite.TabIndex = 7;
            this.button_sprite.TabStop = false;
            this.button_sprite.Click += new System.EventHandler(this.button_sprite_Click);
            // 
            // button_minute_maid
            // 
            this.button_minute_maid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_minute_maid.Image = global::prg_automat.Properties.Resources.minute_maid;
            this.button_minute_maid.InitialImage = global::prg_automat.Properties.Resources.minute_maid;
            this.button_minute_maid.Location = new System.Drawing.Point(243, 212);
            this.button_minute_maid.Name = "button_minute_maid";
            this.button_minute_maid.Size = new System.Drawing.Size(100, 100);
            this.button_minute_maid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_minute_maid.TabIndex = 6;
            this.button_minute_maid.TabStop = false;
            this.button_minute_maid.Click += new System.EventHandler(this.button_minute_maid_Click);
            // 
            // button_fuze_tea
            // 
            this.button_fuze_tea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_fuze_tea.Image = global::prg_automat.Properties.Resources.fuze_tea;
            this.button_fuze_tea.InitialImage = global::prg_automat.Properties.Resources.fuze_tea;
            this.button_fuze_tea.Location = new System.Drawing.Point(121, 212);
            this.button_fuze_tea.Name = "button_fuze_tea";
            this.button_fuze_tea.Size = new System.Drawing.Size(100, 100);
            this.button_fuze_tea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_fuze_tea.TabIndex = 5;
            this.button_fuze_tea.TabStop = false;
            this.button_fuze_tea.Click += new System.EventHandler(this.button_fuze_tea_Click);
            // 
            // button_fanta
            // 
            this.button_fanta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_fanta.Image = global::prg_automat.Properties.Resources.fanta;
            this.button_fanta.InitialImage = global::prg_automat.Properties.Resources.fanta;
            this.button_fanta.Location = new System.Drawing.Point(64, 113);
            this.button_fanta.Name = "button_fanta";
            this.button_fanta.Size = new System.Drawing.Size(100, 100);
            this.button_fanta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_fanta.TabIndex = 4;
            this.button_fanta.TabStop = false;
            this.button_fanta.Click += new System.EventHandler(this.button_fanta_Click);
            // 
            // button_cola
            // 
            this.button_cola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cola.Image = global::prg_automat.Properties.Resources.coca_cola;
            this.button_cola.InitialImage = global::prg_automat.Properties.Resources.coca_cola;
            this.button_cola.Location = new System.Drawing.Point(179, 113);
            this.button_cola.Name = "button_cola";
            this.button_cola.Size = new System.Drawing.Size(100, 100);
            this.button_cola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button_cola.TabIndex = 3;
            this.button_cola.TabStop = false;
            this.button_cola.Click += new System.EventHandler(this.button_cola_Click);
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.Firebrick;
            this.button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_close.ForeColor = System.Drawing.Color.White;
            this.button_close.Location = new System.Drawing.Point(404, 31);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(29, 26);
            this.button_close.TabIndex = 9;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 606);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_sprite);
            this.Controls.Add(this.button_minute_maid);
            this.Controls.Add(this.button_fuze_tea);
            this.Controls.Add(this.button_fanta);
            this.Controls.Add(this.button_cola);
            this.Controls.Add(this.nadpis_1);
            this.Controls.Add(this.automat_name);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "V˝bÏr znaËky";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_close;
    }
}