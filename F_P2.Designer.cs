namespace Quiz
{
    partial class F_P2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_P2));
            this.rad_paraguai = new System.Windows.Forms.RadioButton();
            this.rad_canada = new System.Windows.Forms.RadioButton();
            this.rad_japao = new System.Windows.Forms.RadioButton();
            this.rad_coreia = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_responder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rad_paraguai
            // 
            this.rad_paraguai.AutoSize = true;
            this.rad_paraguai.Location = new System.Drawing.Point(34, 345);
            this.rad_paraguai.Name = "rad_paraguai";
            this.rad_paraguai.Size = new System.Drawing.Size(67, 17);
            this.rad_paraguai.TabIndex = 22;
            this.rad_paraguai.TabStop = true;
            this.rad_paraguai.Text = "Paraguai";
            this.rad_paraguai.UseVisualStyleBackColor = true;
            // 
            // rad_canada
            // 
            this.rad_canada.AutoSize = true;
            this.rad_canada.Location = new System.Drawing.Point(34, 322);
            this.rad_canada.Name = "rad_canada";
            this.rad_canada.Size = new System.Drawing.Size(62, 17);
            this.rad_canada.TabIndex = 21;
            this.rad_canada.TabStop = true;
            this.rad_canada.Text = "Canadá";
            this.rad_canada.UseVisualStyleBackColor = true;
            // 
            // rad_japao
            // 
            this.rad_japao.AutoSize = true;
            this.rad_japao.Location = new System.Drawing.Point(34, 299);
            this.rad_japao.Name = "rad_japao";
            this.rad_japao.Size = new System.Drawing.Size(54, 17);
            this.rad_japao.TabIndex = 20;
            this.rad_japao.TabStop = true;
            this.rad_japao.Text = "Japão";
            this.rad_japao.UseVisualStyleBackColor = true;
            // 
            // rad_coreia
            // 
            this.rad_coreia.AutoSize = true;
            this.rad_coreia.Location = new System.Drawing.Point(34, 276);
            this.rad_coreia.Name = "rad_coreia";
            this.rad_coreia.Size = new System.Drawing.Size(86, 17);
            this.rad_coreia.TabIndex = 19;
            this.rad_coreia.TabStop = true;
            this.rad_coreia.Text = "Coreia do sul";
            this.rad_coreia.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Qual é o país abaixo?";
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(162, 380);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 16;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_responder
            // 
            this.btn_responder.Location = new System.Drawing.Point(65, 380);
            this.btn_responder.Name = "btn_responder";
            this.btn_responder.Size = new System.Drawing.Size(75, 23);
            this.btn_responder.TabIndex = 15;
            this.btn_responder.Text = "Responder";
            this.btn_responder.UseVisualStyleBackColor = true;
            this.btn_responder.Click += new System.EventHandler(this.btn_responder_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quiz.Properties.Resources.coreia;
            this.pictureBox1.Location = new System.Drawing.Point(34, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // F_P2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 419);
            this.ControlBox = false;
            this.Controls.Add(this.rad_paraguai);
            this.Controls.Add(this.rad_canada);
            this.Controls.Add(this.rad_japao);
            this.Controls.Add(this.rad_coreia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_responder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_P2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz dos países";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rad_paraguai;
        private System.Windows.Forms.RadioButton rad_canada;
        private System.Windows.Forms.RadioButton rad_japao;
        private System.Windows.Forms.RadioButton rad_coreia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_responder;
    }
}