using aplicativoSA;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace LOGINv4
{
    public partial class login : Form
    {




        public void logar(string email, string senha)
        {
            try
            {

                if (email.Equals("admin") && senha.Equals("admin"))
                {
                    this.Visible = false;
                    main main = new main();
                    main.Show();
                    
                    
                    

                }
                else
                {

                    if (senha.Length >= 8)
                    {

                        if (cadastro.contas.ContainsKey(email))
                        {

                            if (cadastro.contas[email] == senha)
                            {

                                main main = new main();
                                main.Show();
                                this.Visible = false;
                            }
                            else
                            {

                                MessageBox.Show(
                                    "Senha incorreta!",
                                    "Erro",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                );
                            }
                        }
                        else
                        {

                            MessageBox.Show(
                                "Esse usuário não existe!",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "Esse usuário não existe ou a senha está incorreta!",
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocorreu um erro ao tentar realizar o login: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        public login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            try
            {

                cadastro cadastro = new cadastro();

                cadastro.Show();

                this.Visible = false;



            }
            catch (Exception ex)
            {

            }

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {



            try
            {


                logar(inputEmail.Text, inputSenha.Text);





            }
            catch (Exception ex)
            {

            }





        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        
    }
}
