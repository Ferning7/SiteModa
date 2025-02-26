namespace telaLogin;

partial class Login
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
        panel1 = new System.Windows.Forms.Panel();
        label2 = new System.Windows.Forms.Label();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        panel2 = new System.Windows.Forms.Panel();
        label4 = new System.Windows.Forms.Label();
        pictureBox2 = new System.Windows.Forms.PictureBox();
        panel3 = new System.Windows.Forms.Panel();
        label3 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        linkLabel1 = new System.Windows.Forms.LinkLabel();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        panel3.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)221)), ((int)((byte)223)), ((int)((byte)203)));
        panel1.Controls.Add(label2);
        panel1.ForeColor = System.Drawing.Color.Coral;
        panel1.Location = new System.Drawing.Point(92, 234);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(252, 54);
        panel1.TabIndex = 1;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 10F);
        label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
        label2.Location = new System.Drawing.Point(3, 16);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(59, 23);
        label2.TabIndex = 10;
        label2.Text = "Email";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        label2.Click += label2_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.Location = new System.Drawing.Point(429, 0);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(736, 767);
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 2;
        pictureBox1.TabStop = false;
        // 
        // panel2
        // 
        panel2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)123)), ((int)((byte)126)), ((int)((byte)91)));
        panel2.Controls.Add(label4);
        panel2.Location = new System.Drawing.Point(116, 465);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(200, 43);
        panel2.TabIndex = 2;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
        label4.Location = new System.Drawing.Point(68, 9);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(59, 23);
        label4.TabIndex = 12;
        label4.Text = "Log In";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // pictureBox2
        // 
        pictureBox2.Image = ((System.Drawing.Image)resources.GetObject("pictureBox2.Image"));
        pictureBox2.Location = new System.Drawing.Point(130, 113);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new System.Drawing.Size(165, 86);
        pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
        pictureBox2.TabIndex = 3;
        pictureBox2.TabStop = false;
        // 
        // panel3
        // 
        panel3.BackColor = System.Drawing.Color.FromArgb(((int)((byte)221)), ((int)((byte)223)), ((int)((byte)203)));
        panel3.Controls.Add(label3);
        panel3.Location = new System.Drawing.Point(92, 314);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(252, 54);
        panel3.TabIndex = 2;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 10F);
        label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
        label3.Location = new System.Drawing.Point(3, 15);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(59, 23);
        label3.TabIndex = 11;
        label3.Text = "Senha";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        label3.Click += label3_Click;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 10F);
        label1.Location = new System.Drawing.Point(140, 511);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(155, 23);
        label1.TabIndex = 4;
        label1.Text = "Esqueceu sua senha?";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        label1.Click += label1_Click_1;
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI", 10F);
        label5.Location = new System.Drawing.Point(140, 371);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(155, 23);
        label5.TabIndex = 8;
        label5.Text = "Não possui conta? ";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        label5.Click += label5_Click;
        // 
        // linkLabel1
        // 
        linkLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
        linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)((byte)123)), ((int)((byte)126)), ((int)((byte)91)));
        linkLabel1.Location = new System.Drawing.Point(184, 394);
        linkLabel1.Name = "linkLabel1";
        linkLabel1.Size = new System.Drawing.Size(91, 23);
        linkLabel1.TabIndex = 9;
        linkLabel1.TabStop = true;
        linkLabel1.Text = "Cadastro";
        linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        // 
        // Login
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(1165, 767);
        Controls.Add(linkLabel1);
        Controls.Add(label5);
        Controls.Add(label1);
        Controls.Add(panel3);
        Controls.Add(pictureBox2);
        Controls.Add(panel2);
        Controls.Add(pictureBox1);
        Controls.Add(panel1);
        Text = "Form1";
        panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        panel3.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.LinkLabel linkLabel1;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.PictureBox pictureBox2;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.PictureBox pictureBox1;

    #endregion
}