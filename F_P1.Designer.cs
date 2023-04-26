namespace Quiz
{
    partial class F_P1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_P1));
            this.label2 = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_responder = new System.Windows.Forms.Button();
            this.rad_chile = new System.Windows.Forms.RadioButton();
            this.rad_colombia = new System.Windows.Forms.RadioButton();
            this.rad_russia = new System.Windows.Forms.RadioButton();
            this.rad_equador = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Qual é o país abaixo?";
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(154, 367);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 8;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_responder
            // 
            this.btn_responder.Location = new System.Drawing.Point(57, 367);
            this.btn_responder.Name = "btn_responder";
            this.btn_responder.Size = new System.Drawing.Size(75, 23);
            this.btn_responder.TabIndex = 7;
            this.btn_responder.Text = "Responder";
            this.btn_responder.UseVisualStyleBackColor = true;
            this.btn_responder.Click += new System.EventHandler(this.btn_responder_Click);
            // 
            // rad_chile
            // 
            this.rad_chile.AutoSize = true;
            this.rad_chile.Location = new System.Drawing.Point(26, 263);
            this.rad_chile.Name = "rad_chile";
            this.rad_chile.Size = new System.Drawing.Size(48, 17);
            this.rad_chile.TabIndex = 11;
            this.rad_chile.TabStop = true;
            this.rad_chile.Text = "Chile";
            this.rad_chile.UseVisualStyleBackColor = true;
            // 
            // rad_colombia
            // 
            this.rad_colombia.AutoSize = true;
            this.rad_colombia.Location = new System.Drawing.Point(26, 286);
            this.rad_colombia.Name = "rad_colombia";
            this.rad_colombia.Size = new System.Drawing.Size(68, 17);
            this.rad_colombia.TabIndex = 12;
            this.rad_colombia.TabStop = true;
            this.rad_colombia.Text = "Colombia";
            this.rad_colombia.UseVisualStyleBackColor = true;
            // 
            // rad_russia
            // 
            this.rad_russia.AutoSize = true;
            this.rad_russia.Location = new System.Drawing.Point(26, 309);
            this.rad_russia.Name = "rad_russia";
            this.rad_russia.Size = new System.Drawing.Size(57, 17);
            this.rad_russia.TabIndex = 13;
            this.rad_russia.TabStop = true;
            this.rad_russia.Text = "Russia";
            this.rad_russia.UseVisualStyleBackColor = true;
            // 
            // rad_equador
            // 
            this.rad_equador.AutoSize = true;
            this.rad_equador.Location = new System.Drawing.Point(26, 332);
            this.rad_equador.Name = "rad_equador";
            this.rad_equador.Size = new System.Drawing.Size(65, 17);
            this.rad_equador.TabIndex = 14;
            this.rad_equador.TabStop = true;
            this.rad_equador.Text = "Equador";
            this.rad_equador.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quiz.Properties.Resources.equador;
            this.pictureBox1.Location = new System.Drawing.Point(26, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // F_P1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 407);
            this.ControlBox = false;
            this.Controls.Add(this.rad_equador);
            this.Controls.Add(this.rad_russia);
            this.Controls.Add(this.rad_colombia);
            this.Controls.Add(this.rad_chile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_responder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_P1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz dos países";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_responder;
        private System.Windows.Forms.RadioButton rad_chile;
        private System.Windows.Forms.RadioButton rad_colombia;
        private System.Windows.Forms.RadioButton rad_russia;
        private System.Windows.Forms.RadioButton rad_equador;
    }
}