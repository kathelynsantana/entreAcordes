namespace EntreAcordes
{
    partial class ExcCantor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcCantor));
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            label6 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-97, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(423, 473);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label5.Location = new Point(423, 162);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 34;
            label5.Text = "que deseja excluir.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(396, 296);
            label4.Name = "label4";
            label4.Size = new Size(203, 19);
            label4.TabIndex = 33;
            label4.Text = "Se sim, clique no botão abaixo.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label3.Location = new Point(382, 276);
            label3.Name = "label3";
            label3.Size = new Size(224, 20);
            label3.TabIndex = 32;
            label3.Text = "Tem certeza que deseja excluir?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.Location = new Point(384, 205);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 31;
            label2.Text = "Código:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label1.Location = new Point(392, 142);
            label1.Name = "label1";
            label1.Size = new Size(197, 20);
            label1.TabIndex = 30;
            label1.Text = "Informe o código do cantor";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox1.ForeColor = Color.Black;
            maskedTextBox1.Location = new Point(452, 203);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(153, 23);
            maskedTextBox1.TabIndex = 29;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(165, 38, 23);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 10.25F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(438, 329);
            button1.Name = "button1";
            button1.Size = new Size(109, 33);
            button1.TabIndex = 28;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(77, 28, 21);
            label6.Location = new Point(409, 89);
            label6.Name = "label6";
            label6.Size = new Size(170, 30);
            label6.TabIndex = 35;
            label6.Text = "Excluir Cantor";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(115, 57, 34);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(622, 8);
            button2.Name = "button2";
            button2.Size = new Size(40, 41);
            button2.TabIndex = 38;
            button2.Text = "↩";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ExcCantor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(669, 457);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(maskedTextBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ExcCantor";
            Text = "Entre Acordes - Excluir Cantor (ADM)";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private Button button1;
        private Label label6;
        private Button button2;
    }
}