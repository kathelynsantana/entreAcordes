namespace EntreAcordes
{
    partial class Sobrenos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sobrenos));
            panel1 = new Panel();
            button2 = new Button();
            linkLabel3 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(238, 189, 145);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(linkLabel3);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-4, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 61);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(556, 8);
            button2.Name = "button2";
            button2.Size = new Size(40, 43);
            button2.TabIndex = 5;
            button2.Text = "↩";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // linkLabel3
            // 
            linkLabel3.ActiveLinkColor = Color.SaddleBrown;
            linkLabel3.AutoSize = true;
            linkLabel3.DisabledLinkColor = Color.FromArgb(111, 62, 17);
            linkLabel3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            linkLabel3.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel3.LinkColor = Color.FromArgb(111, 62, 17);
            linkLabel3.Location = new Point(326, 21);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(73, 20);
            linkLabel3.TabIndex = 3;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "MÚSICAS";
            linkLabel3.VisitedLinkColor = Color.FromArgb(111, 62, 17);
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.SaddleBrown;
            linkLabel2.AutoSize = true;
            linkLabel2.DisabledLinkColor = Color.FromArgb(111, 62, 17);
            linkLabel2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            linkLabel2.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel2.LinkColor = Color.FromArgb(111, 62, 17);
            linkLabel2.Location = new Point(196, 21);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(89, 20);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "SOBRE NÓS";
            linkLabel2.VisitedLinkColor = Color.FromArgb(111, 62, 17);
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.SaddleBrown;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.FromArgb(111, 62, 17);
            linkLabel1.Location = new Point(97, 21);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(53, 20);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "INÍCIO";
            linkLabel1.VisitedLinkColor = Color.FromArgb(111, 62, 17);
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(238, 189, 145);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(509, 8);
            button1.Name = "button1";
            button1.Size = new Size(40, 43);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AntiqueWhite;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(41, 148);
            panel2.Name = "panel2";
            panel2.Size = new Size(519, 458);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(220, 86);
            label1.Name = "label1";
            label1.Size = new Size(159, 40);
            label1.TabIndex = 4;
            label1.Text = "Sobre Nós";
            // 
            // Sobrenos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 646);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Sobrenos";
            Text = "Entre Acordes - Sobre Nós";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Button button1;
        private Panel panel2;
        private Label label1;
        private Button button2;
    }
}