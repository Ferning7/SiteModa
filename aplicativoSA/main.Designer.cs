namespace aplicativoSA
{
    partial class main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            panel1 = new Panel();
            pictureBox8 = new PictureBox();
            txtBoxBusca = new TextBox();
            pictureBox7 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            linkLabel1 = new LinkLabel();
            linkCamisas = new LinkLabel();
            linkCalcas = new LinkLabel();
            linkMulher = new LinkLabel();
            linkHomem = new LinkLabel();
            content = new Panel();
            scrollMain = new VScrollBar();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(123, 126, 91);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(txtBoxBusca);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(856, 46);
            panel1.TabIndex = 0;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(791, 10);
            pictureBox8.Margin = new Padding(3, 2, 3, 2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(30, 26);
            pictureBox8.TabIndex = 12;
            pictureBox8.TabStop = false;
            pictureBox8.Tag = "";
            pictureBox8.Click += pictureBox8_Click;
            // 
            // txtBoxBusca
            // 
            txtBoxBusca.Location = new Point(349, 14);
            txtBoxBusca.Margin = new Padding(3, 2, 3, 2);
            txtBoxBusca.Name = "txtBoxBusca";
            txtBoxBusca.PlaceholderText = "BUSCA";
            txtBoxBusca.Size = new Size(173, 23);
            txtBoxBusca.TabIndex = 11;
            // 
            // pictureBox7
            // 
            pictureBox7.Cursor = Cursors.Hand;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(527, 12);
            pictureBox7.Margin = new Padding(3, 2, 3, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(26, 26);
            pictureBox7.TabIndex = 10;
            pictureBox7.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(4, -52);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(178, 148);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(221, 222, 203);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(linkCamisas);
            panel2.Controls.Add(linkCalcas);
            panel2.Controls.Add(linkMulher);
            panel2.Controls.Add(linkHomem);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 46);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(185, 347);
            panel2.TabIndex = 1;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(123, 126, 91);
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(36, 37);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(107, 23);
            linkLabel1.TabIndex = 19;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "HOME";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // linkCamisas
            // 
            linkCamisas.ActiveLinkColor = Color.FromArgb(123, 126, 91);
            linkCamisas.Cursor = Cursors.Hand;
            linkCamisas.Font = new Font("Palatino Linotype", 14.25F);
            linkCamisas.LinkColor = Color.Black;
            linkCamisas.Location = new Point(36, 116);
            linkCamisas.Name = "linkCamisas";
            linkCamisas.Size = new Size(107, 28);
            linkCamisas.TabIndex = 18;
            linkCamisas.TabStop = true;
            linkCamisas.Text = "CAMISAS";
            linkCamisas.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkCalcas
            // 
            linkCalcas.ActiveLinkColor = Color.FromArgb(123, 126, 91);
            linkCalcas.Cursor = Cursors.Hand;
            linkCalcas.Font = new Font("Palatino Linotype", 14.25F);
            linkCalcas.LinkColor = Color.Black;
            linkCalcas.Location = new Point(36, 77);
            linkCalcas.Name = "linkCalcas";
            linkCalcas.Size = new Size(107, 26);
            linkCalcas.TabIndex = 14;
            linkCalcas.TabStop = true;
            linkCalcas.Text = "CALÇAS";
            linkCalcas.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkMulher
            // 
            linkMulher.ActiveLinkColor = Color.FromArgb(123, 126, 91);
            linkMulher.Cursor = Cursors.Hand;
            linkMulher.Font = new Font("Palatino Linotype", 14.25F);
            linkMulher.LinkColor = Color.Black;
            linkMulher.Location = new Point(36, 198);
            linkMulher.Name = "linkMulher";
            linkMulher.Size = new Size(107, 28);
            linkMulher.TabIndex = 13;
            linkMulher.TabStop = true;
            linkMulher.Text = "MULHER";
            linkMulher.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkHomem
            // 
            linkHomem.ActiveLinkColor = Color.FromArgb(123, 126, 91);
            linkHomem.Cursor = Cursors.Hand;
            linkHomem.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkHomem.LinkColor = Color.Black;
            linkHomem.Location = new Point(36, 155);
            linkHomem.Name = "linkHomem";
            linkHomem.Size = new Size(107, 23);
            linkHomem.TabIndex = 12;
            linkHomem.TabStop = true;
            linkHomem.Text = "HOMEM";
            linkHomem.LinkClicked += linkHomem_LinkClicked;
            // 
            // content
            // 
            content.AutoSize = true;
            content.Location = new Point(185, 46);
            content.Margin = new Padding(3, 2, 3, 2);
            content.Name = "content";
            content.Size = new Size(651, 347);
            content.TabIndex = 2;
            content.Paint += content_Paint;
            // 
            // scrollMain
            // 
            scrollMain.Dock = DockStyle.Right;
            scrollMain.Location = new Point(839, 46);
            scrollMain.Name = "scrollMain";
            scrollMain.Size = new Size(17, 347);
            scrollMain.TabIndex = 0;
            scrollMain.Scroll += vScrollBar1_Scroll;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 393);
            Controls.Add(scrollMain);
            Controls.Add(content);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "main";
            Text = "Form1";
            Load += main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.LinkLabel linkLabel1;

        #endregion

        private Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkCalcas;
        private System.Windows.Forms.LinkLabel linkMulher;
        private System.Windows.Forms.LinkLabel linkHomem;
        private PictureBox pictureBox3;
        private PictureBox pictureBox8;
        private TextBox txtBoxBusca;
        private PictureBox pictureBox7;
        private System.Windows.Forms.LinkLabel linkCamisas;
        private Panel content;
        private VScrollBar scrollMain;
    }
}
