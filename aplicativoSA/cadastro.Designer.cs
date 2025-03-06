

namespace aplicativoSA
{
    partial class cadastro
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
            panel1 = new Panel();
            linkVoltarLogin = new LinkLabel();
            cadastrarButton = new Button();
            lblCadastro = new Label();
            inputSenhaCadastro = new TextBox();
            inputEmailCadastro = new TextBox();
            label2 = new Label();
            label4 = new Label();
            linkBackLogin = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(123, 126, 91);
            panel1.Controls.Add(linkBackLogin);
            panel1.Controls.Add(linkVoltarLogin);
            panel1.Controls.Add(cadastrarButton);
            panel1.Controls.Add(lblCadastro);
            panel1.Controls.Add(inputSenhaCadastro);
            panel1.Controls.Add(inputEmailCadastro);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(200, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(407, 409);
            panel1.TabIndex = 28;
            // 
            // linkVoltarLogin
            // 
            linkVoltarLogin.Location = new Point(0, 0);
            linkVoltarLogin.Name = "linkVoltarLogin";
            linkVoltarLogin.Size = new Size(100, 23);
            linkVoltarLogin.TabIndex = 0;
            // 
            // cadastrarButton
            // 
            cadastrarButton.BackColor = Color.FromArgb(123, 126, 91);
            cadastrarButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cadastrarButton.ForeColor = Color.White;
            cadastrarButton.Location = new Point(123, 298);
            cadastrarButton.Name = "cadastrarButton";
            cadastrarButton.Size = new Size(163, 46);
            cadastrarButton.TabIndex = 34;
            cadastrarButton.Text = "Cadastrar";
            cadastrarButton.UseVisualStyleBackColor = false;
            cadastrarButton.Click += cadastrarButton_Click;
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.Font = new Font("Palatino Linotype", 14.25F);
            lblCadastro.ForeColor = Color.FromArgb(221, 222, 203);
            lblCadastro.Location = new Point(155, 40);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(119, 26);
            lblCadastro.TabIndex = 33;
            lblCadastro.Text = "CADASTRO";
            // 
            // inputSenhaCadastro
            // 
            inputSenhaCadastro.BackColor = Color.FromArgb(221, 223, 203);
            inputSenhaCadastro.Location = new Point(85, 226);
            inputSenhaCadastro.MinimumSize = new Size(240, 40);
            inputSenhaCadastro.Name = "inputSenhaCadastro";
            inputSenhaCadastro.Size = new Size(240, 40);
            inputSenhaCadastro.TabIndex = 31;
            inputSenhaCadastro.TextChanged += inputSenhaCadastro_TextChanged;
            // 
            // inputEmailCadastro
            // 
            inputEmailCadastro.BackColor = Color.FromArgb(221, 223, 203);
            inputEmailCadastro.Location = new Point(85, 125);
            inputEmailCadastro.MinimumSize = new Size(240, 40);
            inputEmailCadastro.Name = "inputEmailCadastro";
            inputEmailCadastro.Size = new Size(240, 40);
            inputEmailCadastro.TabIndex = 29;
            inputEmailCadastro.TextChanged += inputEmailCadastro_TextChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(221, 222, 203);
            label2.Location = new Point(81, 103);
            label2.Name = "label2";
            label2.Size = new Size(45, 23);
            label2.TabIndex = 30;
            label2.Text = "Email";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.FromArgb(221, 222, 203);
            label4.Location = new Point(82, 204);
            label4.Name = "label4";
            label4.Size = new Size(49, 23);
            label4.TabIndex = 32;
            label4.Text = "Senha";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkBackLogin
            // 
            linkBackLogin.AutoSize = true;
            linkBackLogin.Location = new Point(155, 370);
            linkBackLogin.Name = "linkBackLogin";
            linkBackLogin.Size = new Size(103, 15);
            linkBackLogin.TabIndex = 35;
            linkBackLogin.TabStop = true;
            linkBackLogin.Text = "Voltar para o login";
            linkBackLogin.LinkClicked += linkBackLogin_LinkClicked;
            // 
            // cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "cadastro";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }





        #endregion
        private Panel panel1;
        private Label lblCadastro;
        private TextBox inputSenhaCadastro;
        private TextBox inputEmailCadastro;
        private Label label2;
        private Label label4;
        private Button cadastrarButton;
        private LinkLabel linkVoltarLogin;
        private LinkLabel linkBackLogin;
    }
}