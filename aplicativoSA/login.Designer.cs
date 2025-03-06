using aplicativoSA.Properties;

namespace LOGINv4
{
    partial class login
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
            linkCadastro = new LinkLabel();
            label5 = new Label();
            LogInButton = new Button();
            inputEmail = new TextBox();
            label2 = new Label();
            label3 = new Label();
            inputSenha = new TextBox();
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
            // linkCadastro
            // 
            linkCadastro.ActiveLinkColor = Color.FromArgb(64, 64, 0);
            linkCadastro.Font = new Font("Segoe UI", 10F);
            linkCadastro.LinkColor = Color.FromArgb(123, 126, 91);
            linkCadastro.Location = new Point(147, 330);
            linkCadastro.Name = "linkCadastro";
            linkCadastro.Size = new Size(67, 23);
            linkCadastro.TabIndex = 15;
            linkCadastro.TabStop = true;
            linkCadastro.Text = "Cadastro";
            linkCadastro.VisitedLinkColor = Color.Olive;
            linkCadastro.LinkClicked += linkLabel1_LinkClicked;
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
            // inputEmail
            // 
            inputEmail.BackColor = Color.FromArgb(221, 223, 203);
            inputEmail.Location = new Point(58, 167);
            inputEmail.MinimumSize = new Size(240, 40);
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(240, 40);
            inputEmail.TabIndex = 17;
            inputEmail.TextChanged += textBox1_TextChanged;
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
            // inputSenha
            // 
            inputSenha.BackColor = Color.FromArgb(221, 223, 203);
            inputSenha.Location = new Point(58, 268);
            inputSenha.MinimumSize = new Size(240, 40);
            inputSenha.Name = "inputSenha";
            inputSenha.PasswordChar = '*';
            inputSenha.Size = new Size(240, 40);
            inputSenha.TabIndex = 19;
            inputSenha.TextChanged += textBox2_TextChanged;
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
            pictureBox1.Image = Resources.Captura_de_tela_2025_02_25_101138;
            pictureBox1.Location = new Point(375, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(540, 524);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resources.Captura_de_tela_2025_02_25_095855;
            pictureBox2.Location = new Point(110, 57);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(134, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 524);
            Controls.Add(pictureBox2);
            Controls.Add(linkLabel2);
            Controls.Add(inputSenha);
            Controls.Add(inputEmail);
            Controls.Add(LogInButton);
            Controls.Add(pictureBox1);
            Controls.Add(linkCadastro);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Name = "login";
            
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel linkCadastro;
        private Label label5;
        private Button LogInButton;
        private TextBox inputEmail;
        private Label label2;
        private Label label3;
        private TextBox inputSenha;
        private Label label4;
        private ErrorProvider errorProvider1;
        private LinkLabel linkLabel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
