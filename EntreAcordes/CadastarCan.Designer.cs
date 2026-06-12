namespace EntreAcordes
{
    partial class CadastarCan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastarCan));
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label9 = new Label();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-6, -103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 505);
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(367, 184);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 23);
            textBox1.TabIndex = 46;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label9.Location = new Point(310, 224);
            label9.Name = "label9";
            label9.Size = new Size(63, 20);
            label9.TabIndex = 44;
            label9.Text = "Gênero:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.Location = new Point(310, 185);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 41;
            label2.Text = "Nome:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label5.Location = new Point(347, 134);
            label5.Name = "label5";
            label5.Size = new Size(158, 20);
            label5.TabIndex = 40;
            label5.Text = "os dados logo abaixo.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label4.Location = new Point(305, 114);
            label4.Name = "label4";
            label4.Size = new Size(252, 20);
            label4.TabIndex = 39;
            label4.Text = "Para cadastrar um cantor, preencha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 15, 8);
            label1.Location = new Point(308, 75);
            label1.Name = "label1";
            label1.Size = new Size(231, 30);
            label1.TabIndex = 38;
            label1.Text = "Cadastro de Cantor";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(115, 57, 34);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(555, 6);
            button2.Name = "button2";
            button2.Size = new Size(40, 41);
            button2.TabIndex = 37;
            button2.Text = "↩";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(163, 96, 13);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(369, 311);
            button1.Name = "button1";
            button1.Size = new Size(104, 29);
            button1.TabIndex = 36;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(375, 221);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 23);
            textBox2.TabIndex = 48;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label3.Location = new Point(310, 263);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 42;
            label3.Text = "Data de Nasc.:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox1.Location = new Point(418, 261);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(115, 23);
            maskedTextBox1.TabIndex = 50;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // CadastarCan
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(602, 395);
            Controls.Add(maskedTextBox1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CadastarCan";
            Text = "Entre Acordes - Cadastrar Cantor (ADM)";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label9;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label1;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private Label label3;
        private MaskedTextBox maskedTextBox1;
    }
}