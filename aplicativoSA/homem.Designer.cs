using System.ComponentModel;

namespace aplicativoSA;

partial class homem
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        label3 = new Label();
        pictureBox2 = new PictureBox();
        panel2 = new Panel();
        label1 = new Label();
        pictureBox3 = new PictureBox();
        panel3 = new Panel();
        label2 = new Label();
        pictureBox1 = new PictureBox();
        label10 = new Label();
        panel4 = new Panel();
        button2 = new Button();
        label7 = new Label();
        label8 = new Label();
        label9 = new Label();
        pictureBox4 = new PictureBox();
        panel5 = new Panel();
        button4 = new Button();
        label5 = new Label();
        label4 = new Label();
        label6 = new Label();
        pictureBox5 = new PictureBox();
        panel6 = new Panel();
        button3 = new Button();
        label11 = new Label();
        label12 = new Label();
        label13 = new Label();
        pictureBox6 = new PictureBox();
        vScrollBarHomem = new VScrollBar();
        panel1.SuspendLayout();
        ((ISupportInitialize)pictureBox2).BeginInit();
        panel2.SuspendLayout();
        ((ISupportInitialize)pictureBox3).BeginInit();
        panel3.SuspendLayout();
        ((ISupportInitialize)pictureBox1).BeginInit();
        panel4.SuspendLayout();
        ((ISupportInitialize)pictureBox4).BeginInit();
        panel5.SuspendLayout();
        ((ISupportInitialize)pictureBox5).BeginInit();
        panel6.SuspendLayout();
        ((ISupportInitialize)pictureBox6).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.White;
        panel1.Controls.Add(label3);
        panel1.Controls.Add(pictureBox2);
        panel1.Cursor = Cursors.Hand;
        panel1.Location = new Point(506, 82);
        panel1.Name = "panel1";
        panel1.Size = new Size(201, 306);
        panel1.TabIndex = 4;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.BackColor = Color.Transparent;
        label3.Font = new Font("Sitka Text", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        label3.ForeColor = Color.Black;
        label3.ImageAlign = ContentAlignment.BottomCenter;
        label3.Location = new Point(72, 284);
        label3.Name = "label3";
        label3.Size = new Size(57, 18);
        label3.TabIndex = 4;
        label3.Text = "Camisas";
        label3.TextAlign = ContentAlignment.MiddleCenter;
        label3.Click += label3_Click;
        // 
        // pictureBox2
        // 
        pictureBox2.Image = Properties.Resources.polo_bege;
        pictureBox2.Location = new Point(1, 3);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(199, 279);
        pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
        pictureBox2.TabIndex = 0;
        pictureBox2.TabStop = false;
        // 
        // panel2
        // 
        panel2.BackColor = SystemColors.ButtonHighlight;
        panel2.Controls.Add(label1);
        panel2.Controls.Add(pictureBox3);
        panel2.Cursor = Cursors.Hand;
        panel2.Location = new Point(300, 41);
        panel2.Name = "panel2";
        panel2.Size = new Size(155, 255);
        panel2.TabIndex = 5;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.BackColor = Color.Transparent;
        label1.Font = new Font("Sitka Text", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        label1.ForeColor = Color.Black;
        label1.ImageAlign = ContentAlignment.BottomLeft;
        label1.Location = new Point(55, 228);
        label1.Name = "label1";
        label1.Size = new Size(46, 18);
        label1.TabIndex = 5;
        label1.Text = "Calças";
        label1.Click += label1_Click;
        // 
        // pictureBox3
        // 
        pictureBox3.Image = Properties.Resources.calca_social_bege;
        pictureBox3.Location = new Point(0, -72);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Size = new Size(155, 297);
        pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
        pictureBox3.TabIndex = 0;
        pictureBox3.TabStop = false;
        pictureBox3.Click += pictureBox3_Click;
        // 
        // panel3
        // 
        panel3.BackColor = SystemColors.ButtonHighlight;
        panel3.Controls.Add(label2);
        panel3.Controls.Add(pictureBox1);
        panel3.Cursor = Cursors.Hand;
        panel3.Location = new Point(76, 82);
        panel3.Name = "panel3";
        panel3.Size = new Size(155, 255);
        panel3.TabIndex = 6;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.BackColor = Color.Transparent;
        label2.Font = new Font("Sitka Text", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        label2.ForeColor = Color.Black;
        label2.ImageAlign = ContentAlignment.BottomLeft;
        label2.Location = new Point(52, 228);
        label2.Name = "label2";
        label2.Size = new Size(46, 18);
        label2.TabIndex = 5;
        label2.Text = "Cintos";
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.cinto;
        pictureBox1.Location = new Point(0, -16);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(155, 241);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Font = new Font("Javanese Text", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        label10.Location = new Point(300, 429);
        label10.Name = "label10";
        label10.Size = new Size(169, 27);
        label10.TabIndex = 10;
        label10.Text = "PRODUTOS POPULARES";
        label10.Click += label10_Click;
        // 
        // panel4
        // 
        panel4.BackColor = SystemColors.ButtonHighlight;
        panel4.Controls.Add(button2);
        panel4.Controls.Add(label7);
        panel4.Controls.Add(label8);
        panel4.Controls.Add(label9);
        panel4.Controls.Add(pictureBox4);
        panel4.Cursor = Cursors.Hand;
        panel4.Location = new Point(118, 470);
        panel4.Name = "panel4";
        panel4.Size = new Size(155, 306);
        panel4.TabIndex = 9;
        // 
        // button2
        // 
        button2.BackColor = Color.FromArgb(123, 126, 91);
        button2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        button2.ForeColor = Color.FromArgb(221, 223, 203);
        button2.Location = new Point(8, 261);
        button2.Name = "button2";
        button2.Size = new Size(137, 38);
        button2.TabIndex = 7;
        button2.Text = "Comprar";
        button2.UseVisualStyleBackColor = false;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Sitka Text", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        label7.ForeColor = Color.Black;
        label7.ImageAlign = ContentAlignment.BottomLeft;
        label7.Location = new Point(92, 241);
        label7.Name = "label7";
        label7.Size = new Size(61, 18);
        label7.TabIndex = 5;
        label7.Text = "R$ 49,00";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Font = new Font("Sitka Text", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        label8.ForeColor = Color.Black;
        label8.ImageAlign = ContentAlignment.BottomLeft;
        label8.Location = new Point(6, 228);
        label8.Name = "label8";
        label8.Size = new Size(46, 18);
        label8.TabIndex = 4;
        label8.Text = "Calças";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Font = new Font("Georgia", 9F);
        label9.ForeColor = Color.Black;
        label9.Location = new Point(6, 198);
        label9.Name = "label9";
        label9.Size = new Size(103, 30);
        label9.TabIndex = 3;
        label9.Text = "Calça social bege\r\nElegante";
        // 
        // pictureBox4
        // 
        pictureBox4.Image = Properties.Resources.calca_social_bege;
        pictureBox4.Location = new Point(-1, -1);
        pictureBox4.Name = "pictureBox4";
        pictureBox4.Size = new Size(155, 193);
        pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox4.TabIndex = 0;
        pictureBox4.TabStop = false;
        // 
        // panel5
        // 
        panel5.BackColor = Color.White;
        panel5.Controls.Add(button4);
        panel5.Controls.Add(label5);
        panel5.Controls.Add(label4);
        panel5.Controls.Add(label6);
        panel5.Controls.Add(pictureBox5);
        panel5.Cursor = Cursors.Hand;
        panel5.Location = new Point(491, 470);
        panel5.Name = "panel5";
        panel5.Size = new Size(155, 306);
        panel5.TabIndex = 8;
        // 
        // button4
        // 
        button4.BackColor = Color.FromArgb(123, 126, 91);
        button4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        button4.ForeColor = Color.FromArgb(221, 223, 203);
        button4.Location = new Point(9, 262);
        button4.Name = "button4";
        button4.Size = new Size(137, 38);
        button4.TabIndex = 7;
        button4.Text = "Comprar";
        button4.UseVisualStyleBackColor = false;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Sitka Text", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        label5.ForeColor = Color.Black;
        label5.ImageAlign = ContentAlignment.BottomLeft;
        label5.Location = new Point(92, 242);
        label5.Name = "label5";
        label5.Size = new Size(61, 18);
        label5.TabIndex = 5;
        label5.Text = "R$ 69,00";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Sitka Text", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        label4.ForeColor = Color.Black;
        label4.ImageAlign = ContentAlignment.BottomLeft;
        label4.Location = new Point(9, 228);
        label4.Name = "label4";
        label4.Size = new Size(57, 18);
        label4.TabIndex = 4;
        label4.Text = "Camisas";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Georgia", 9F);
        label6.ForeColor = Color.Black;
        label6.Location = new Point(7, 198);
        label6.Name = "label6";
        label6.Size = new Size(117, 30);
        label6.TabIndex = 3;
        label6.Text = "Camisa social bege \r\nElegante";
        // 
        // pictureBox5
        // 
        pictureBox5.Image = Properties.Resources.polo_bege;
        pictureBox5.Location = new Point(-1, -1);
        pictureBox5.Name = "pictureBox5";
        pictureBox5.Size = new Size(155, 193);
        pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox5.TabIndex = 0;
        pictureBox5.TabStop = false;
        // 
        // panel6
        // 
        panel6.BackColor = Color.White;
        panel6.Controls.Add(button3);
        panel6.Controls.Add(label11);
        panel6.Controls.Add(label12);
        panel6.Controls.Add(label13);
        panel6.Controls.Add(pictureBox6);
        panel6.Cursor = Cursors.Hand;
        panel6.Location = new Point(305, 470);
        panel6.Name = "panel6";
        panel6.Size = new Size(155, 306);
        panel6.TabIndex = 7;
        // 
        // button3
        // 
        button3.BackColor = Color.FromArgb(123, 126, 91);
        button3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        button3.ForeColor = Color.FromArgb(221, 223, 203);
        button3.Location = new Point(7, 261);
        button3.Name = "button3";
        button3.Size = new Size(137, 38);
        button3.TabIndex = 7;
        button3.Text = "Comprar";
        button3.UseVisualStyleBackColor = false;
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Font = new Font("Sitka Text", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        label11.ForeColor = Color.Black;
        label11.ImageAlign = ContentAlignment.BottomLeft;
        label11.Location = new Point(89, 242);
        label11.Name = "label11";
        label11.Size = new Size(61, 18);
        label11.TabIndex = 6;
        label11.Text = "R$ 69,00";
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Font = new Font("Sitka Text", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        label12.ImageAlign = ContentAlignment.BottomLeft;
        label12.Location = new Point(5, 228);
        label12.Name = "label12";
        label12.Size = new Size(57, 18);
        label12.TabIndex = 2;
        label12.Text = "Camisas";
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Font = new Font("Georgia", 9F);
        label13.Location = new Point(6, 198);
        label13.Name = "label13";
        label13.Size = new Size(114, 30);
        label13.TabIndex = 1;
        label13.Text = "Roupa Social Preta\r\nBusiness";
        // 
        // pictureBox6
        // 
        pictureBox6.Image = Properties.Resources.social_preta;
        pictureBox6.Location = new Point(-1, -1);
        pictureBox6.Name = "pictureBox6";
        pictureBox6.Size = new Size(155, 196);
        pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox6.TabIndex = 0;
        pictureBox6.TabStop = false;
        // 
        // vScrollBarHomem
        // 
        vScrollBarHomem.Dock = DockStyle.Right;
        vScrollBarHomem.Location = new Point(746, 0);
        vScrollBarHomem.Name = "vScrollBarHomem";
        vScrollBarHomem.Size = new Size(17, 788);
        vScrollBarHomem.TabIndex = 0;
        vScrollBarHomem.Scroll += vScrollBarHomem_Scroll;
        // 
        // homem
        // 
        ClientSize = new Size(763, 788);
        Controls.Add(vScrollBarHomem);
        Controls.Add(label10);
        Controls.Add(panel4);
        Controls.Add(panel5);
        Controls.Add(panel6);
        Controls.Add(panel3);
        Controls.Add(panel2);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "homem";
        Load += homem_Load;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((ISupportInitialize)pictureBox2).EndInit();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ((ISupportInitialize)pictureBox3).EndInit();
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        ((ISupportInitialize)pictureBox1).EndInit();
        panel4.ResumeLayout(false);
        panel4.PerformLayout();
        ((ISupportInitialize)pictureBox4).EndInit();
        panel5.ResumeLayout(false);
        panel5.PerformLayout();
        ((ISupportInitialize)pictureBox5).EndInit();
        panel6.ResumeLayout(false);
        panel6.PerformLayout();
        ((ISupportInitialize)pictureBox6).EndInit();
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private Panel panel1;
    private Label label3;
    private PictureBox pictureBox2;
    private Panel panel2;
    private PictureBox pictureBox3;
    private Label label1;
    private Panel panel3;
    private Label label2;
    private PictureBox pictureBox1;
    private Label label10;
    private Panel panel4;
    private Button button2;
    private Label label7;
    private Label label8;
    private Label label9;
    private PictureBox pictureBox4;
    private Panel panel5;
    private Button button4;
    private Label label5;
    private Label label4;
    private Label label6;
    private PictureBox pictureBox5;
    private Panel panel6;
    private Button button3;
    private Label label11;
    private Label label12;
    private Label label13;
    private PictureBox pictureBox6;
    private VScrollBar vScrollBarHomem;
}