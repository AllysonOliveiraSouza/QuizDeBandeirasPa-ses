namespace Quiz
{
    partial class F_P3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_P3));
            this.rad_jamaica = new System.Windows.Forms.RadioButton();
            this.rad_china = new System.Windows.Forms.RadioButton();
            this.rad_marrocos = new System.Windows.Forms.RadioButton();
            this.rad_angola = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_responder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rad_jamaica
            // 
            this.rad_jamaica.AutoSize = true;
            this.rad_jamaica.Location = new System.Drawing.Point(25, 326);
            this.rad_jamaica.Name = "rad_jamaica";
            this.rad_jamaica.Size = new System.Drawing.Size(64, 17);
            this.rad_jamaica.TabIndex = 30;
            this.rad_jamaica.TabStop = true;
            this.rad_jamaica.Text = "Jamaica";
            this.rad_jamaica.UseVisualStyleBackColor = true;
            // 
            // rad_china
            // 
            this.rad_china.AutoSize = true;
            this.rad_china.Location = new System.Drawing.Point(25, 303);
            this.rad_china.Name = "rad_china";
            this.rad_china.Size = new System.Drawing.Size(52, 17);
            this.rad_china.TabIndex = 29;
            this.rad_china.TabStop = true;
            this.rad_china.Text = "China";
            this.rad_china.UseVisualStyleBackColor = true;
            // 
            // rad_marrocos
            // 
            this.rad_marrocos.AutoSize = true;
            this.rad_marrocos.Location = new System.Drawing.Point(25, 280);
            this.rad_marrocos.Name = "rad_marrocos";
            this.rad_marrocos.Size = new System.Drawing.Size(69, 17);
            this.rad_marrocos.TabIndex = 28;
            this.rad_marrocos.TabStop = true;
            this.rad_marrocos.Text = "Marrocos";
            this.rad_marrocos.UseVisualStyleBackColor = true;
            // 
            // rad_angola
            // 
            this.rad_angola.AutoSize = true;
            this.rad_angola.Location = new System.Drawing.Point(25, 257);
            this.rad_angola.Name = "rad_angola";
            this.rad_angola.Size = new System.Drawing.Size(58, 17);
            this.rad_angola.TabIndex = 27;
            this.rad_angola.TabStop = true;
            this.rad_angola.Text = "Angola";
            this.rad_angola.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Qual é o país abaixo?";
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(153, 361);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 24;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_responder
            // 
            this.btn_responder.Location = new System.Drawing.Point(56, 361);
            this.btn_responder.Name = "btn_responder";
            this.btn_responder.Size = new System.Drawing.Size(75, 23);
            this.btn_responder.TabIndex = 23;
            this.btn_responder.Text = "Responder";
            this.btn_responder.UseVisualStyleBackColor = true;
            this.btn_responder.Click += new System.EventHandler(this.btn_responder_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quiz.Properties.Resources.china;
            this.pictureBox1.Location = new System.Drawing.Point(25, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // F_P3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 396);
            this.ControlBox = false;
            this.Controls.Add(this.rad_jamaica);
            this.Controls.Add(this.rad_china);
            this.Controls.Add(this.rad_marrocos);
            this.Controls.Add(this.rad_angola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_responder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_P3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz dos países";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rad_jamaica;
        private System.Windows.Forms.RadioButton rad_china;
        private System.Windows.Forms.RadioButton rad_marrocos;
        private System.Windows.Forms.RadioButton rad_angola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_responder;
    }
}