using LOGINv4;

namespace aplicativoSA
{
    public partial class main : Form
    {
        public main()
        {
            
            InitializeComponent();
            scrollMain.Minimum = 0;
            scrollMain.Visible = false;

        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
 


        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            nav(new calcas(), content);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            nav(new camisas(), content);

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            nav(new mulher(), content);

        }

        private void linkHomem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            nav(new homem(), content);

        }

        private void AjustarScroll()
        {
            if (content.Controls.Count > 0)
            {
                var formAtivo = content.Controls[0];
                if (formAtivo.Height > content.Height)
                {
                    scrollMain.Maximum = formAtivo.Height - content.Height;
                    scrollMain.LargeChange = content.Height / 2;
                    scrollMain.SmallChange = 20;
                    scrollMain.Visible = true;
                }
                else
                {
                    scrollMain.Visible = false;
                }
            }
        }

        public void nav(Form form, Panel panel)
        {

            form.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
            AjustarScroll();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {



        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

            nav(new home(), content);

        }

        private void content_Paint(object sender, PaintEventArgs e)
        {



        }



        private void main_Load(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

            if (content.Controls.Count > 0)
            {
                var formAtivo = content.Controls[0];
                formAtivo.Top = -scrollMain.Value;
            }

        }
    }
}
