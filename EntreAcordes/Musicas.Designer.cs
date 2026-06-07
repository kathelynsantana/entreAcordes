namespace EntreAcordes
{
    partial class Musicas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Musicas));
            panel1 = new Panel();
            linkLabel3 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(238, 189, 145);
            panel1.Controls.Add(linkLabel3);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-4, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 61);
            panel1.TabIndex = 3;
            // 
            // linkLabel3
            // 
            linkLabel3.ActiveLinkColor = Color.Red;
            linkLabel3.AutoSize = true;
            linkLabel3.DisabledLinkColor = Color.FromArgb(111, 62, 17);
            linkLabel3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            linkLabel3.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel3.LinkColor = Color.FromArgb(111, 62, 17);
            linkLabel3.Location = new Point(326, 22);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(73, 20);
            linkLabel3.TabIndex = 3;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "MÚSICAS";
            linkLabel3.VisitedLinkColor = Color.FromArgb(111, 62, 17);
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.Red;
            linkLabel2.AutoSize = true;
            linkLabel2.DisabledLinkColor = Color.FromArgb(111, 62, 17);
            linkLabel2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            linkLabel2.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel2.LinkColor = Color.FromArgb(111, 62, 17);
            linkLabel2.Location = new Point(196, 22);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(89, 20);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "SOBRE NÓS";
            linkLabel2.VisitedLinkColor = Color.FromArgb(111, 62, 17);
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.FromArgb(111, 62, 17);
            linkLabel1.Location = new Point(97, 22);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(53, 20);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "INÍCIO";
            linkLabel1.VisitedLinkColor = Color.FromArgb(111, 62, 17);
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(238, 189, 145);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(497, 9);
            button1.Name = "button1";
            button1.Size = new Size(40, 43);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            // 
            // Musicas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 646);
            Controls.Add(panel1);
            Name = "Musicas";
            Text = "Entre Acordes - Músicas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Button button1;
    }
}