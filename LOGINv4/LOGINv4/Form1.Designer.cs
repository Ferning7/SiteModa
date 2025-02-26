namespace LOGINv4
{
    partial class Form1
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            LogInButton = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            errorProvider1 = new ErrorProvider(components);
            linkLabel2 = new LinkLabel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(64, 64, 0);
            linkLabel1.Font = new Font("Segoe UI", 10F);
            linkLabel1.LinkColor = Color.FromArgb(123, 126, 91);
            linkLabel1.Location = new Point(147, 330);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(67, 23);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Cadastro";
            linkLabel1.VisitedLinkColor = Color.Olive;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(104, 308);
            label5.Name = "label5";
            label5.Size = new Size(155, 23);
            label5.TabIndex = 14;
            label5.Text = "Não possui conta? ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // LogInButton
            // 
            LogInButton.BackColor = Color.FromArgb(123, 126, 91);
            LogInButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogInButton.ForeColor = Color.White;
            LogInButton.Location = new Point(94, 395);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(163, 46);
            LogInButton.TabIndex = 13;
            LogInButton.Text = "Log In";
            LogInButton.UseVisualStyleBackColor = false;
            LogInButton.Click += LogInButton_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(221, 223, 203);
            textBox1.Location = new Point(58, 167);
            textBox1.MinimumSize = new Size(240, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 40);
            textBox1.TabIndex = 17;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(54, 145);
            label2.Name = "label2";
            label2.Size = new Size(45, 23);
            label2.TabIndex = 18;
            label2.Text = "Email";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(221, 223, 203);
            textBox2.Location = new Point(58, 268);
            textBox2.MinimumSize = new Size(240, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(240, 40);
            textBox2.TabIndex = 19;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(55, 246);
            label4.Name = "label4";
            label4.Size = new Size(49, 23);
            label4.TabIndex = 21;
            label4.Text = "Senha";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.FromArgb(64, 64, 0);
            linkLabel2.Font = new Font("Segoe UI", 10F);
            linkLabel2.LinkColor = Color.FromArgb(123, 126, 91);
            linkLabel2.Location = new Point(111, 441);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(136, 24);
            linkLabel2.TabIndex = 22;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Esqueci minha senha";
            linkLabel2.VisitedLinkColor = Color.Olive;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.Captura_de_tela_2025_02_25_101138;
            pictureBox1.Location = new Point(361, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(617, 524);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Captura_de_tela_2025_02_25_095855;
            pictureBox2.Location = new Point(110, 57);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(134, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 524);
            Controls.Add(pictureBox2);
            Controls.Add(linkLabel2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(LogInButton);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel linkLabel1;
        private Label label5;
        private Button LogInButton;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private ErrorProvider errorProvider1;
        private LinkLabel linkLabel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
