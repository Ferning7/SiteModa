using LOGINv4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicativoSA
{
    public partial class cadastro : Form
    {

        // Dicionário para armazenar as contas
        public static Dictionary<string, string> contas = new Dictionary<string, string>();


        // Método para cadastrar a conta
        public void Cadastrar()
        {
            string email = inputEmailCadastro.Text;   // Pega o email do campo de texto
            string senha = inputSenhaCadastro.Text;   // Pega a senha do campo de texto

            if (!contas.ContainsKey(email))  // Verifica se o email já existe no dicionário
            {
                contas.Add(email, senha);  // Adiciona a conta ao dicionário
            }
            else
            {
                MessageBox.Show("Este email já está cadastrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public cadastro()
        {
            InitializeComponent();
        }

        private void inputEmailCadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputSenhaCadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadastrarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputSenhaCadastro.Text.Count() >= 8)
                {
                    Cadastrar();  // Chama o método sem parâmetros, pois ele pega os valores diretamente

                    login login = new login();
                    login.Show();

                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show(
                        "A senha deve ter pelo menos 8 caracteres!",
                        "Atenção",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                // Tratar exceção (se necessário)
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void linkBackLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            login login = new login();
            this.Close();
            login.Show();
            
        }
    }
}
