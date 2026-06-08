namespace EntreAcordes
{
    partial class LoginAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAdm));
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-57, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(321, 430);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label5.Location = new Point(320, 151);
            label5.Name = "label5";
            label5.Size = new Size(210, 20);
            label5.TabIndex = 21;
            label5.Text = "informe o seu e-mail e senha.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label4.Location = new Point(296, 130);
            label4.Name = "label4";
            label4.Size = new Size(262, 20);
            label4.TabIndex = 20;
            label4.Text = "Para fazer login como administrador,";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(304, 87);
            label3.Name = "label3";
            label3.Size = new Size(238, 30);
            label3.TabIndex = 19;
            label3.Text = "Bem-vindo de volta!";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox2.Location = new Point(376, 239);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(157, 23);
            maskedTextBox2.TabIndex = 18;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox1.Location = new Point(376, 202);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(157, 23);
            maskedTextBox1.TabIndex = 17;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(111, 43, 10);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(537, 7);
            button2.Name = "button2";
            button2.Size = new Size(40, 41);
            button2.TabIndex = 16;
            button2.Text = "↩";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(121, 83, 61);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(374, 295);
            button1.Name = "button1";
            button1.Size = new Size(114, 29);
            button1.TabIndex = 15;
            button1.Text = "Fazer Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.Location = new Point(311, 241);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 14;
            label2.Text = "Senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label1.Location = new Point(310, 204);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 13;
            label1.Text = "E-mail:";
            // 
            // LoginAdm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(584, 423);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginAdm";
            Text = "Entre Acordes - Login (ADM)";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
    }
}