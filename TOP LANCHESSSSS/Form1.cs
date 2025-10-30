namespace TOP_LANCHESSSSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBoxHamburguer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHamburguer.Checked == true)
            {
                numericHamburguer.Enabled = true;
                textBoxHamburguer.Enabled = true;
                numericHamburguer.Value = 1;
            }
            else
            {
                numericHamburguer.Enabled = false;
                textBoxHamburguer.Enabled = false;
                numericHamburguer.Value = 0;
                textBoxHamburguer.Text = "0,00";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBoxOvo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOvo.Checked == true)
            {
                numericOvo.Enabled = true;
                textBoxOvo.Enabled = true;
                numericOvo.Value = 1;
            }
            else
            {
                numericOvo.Enabled = false;
                textBoxOvo.Enabled = false;
                numericOvo.Value = 0;
                textBoxOvo.Text = "0,00";
            }
        }

        private void checkBoxPresunto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPresunto.Checked == true)
            {
                numericPresunto.Enabled = true;
                textBoxPresunto.Enabled = true;
                numericPresunto.Value = 1;
            }
            else
            {
                numericPresunto.Enabled = false;
                textBoxPresunto.Enabled = false;
                numericPresunto.Value = 0;
                textBoxPresunto.Text = "0,00";
            }
        }

        private void checkBoxMussarela_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMussarela.Checked == true)
            {
                numericMussarela.Enabled = true;
                textBoxMussarela.Enabled = true;
                numericMussarela.Value = 1;
            }
            else
            {
                numericMussarela.Enabled = false;
                textBoxMussarela.Enabled = false;
                numericMussarela.Value = 0;
                textBoxMussarela.Text = "0,00";
            }
        }

        private void checkBoxBacon_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBacon.Checked == true)
            {
                numericBacon.Enabled = true;
                textBoxBacon.Enabled = true;
                numericBacon.Value = 1;
            }
            else
            {
                numericBacon.Enabled = false;
                textBoxBacon.Enabled = false;
                numericBacon.Value = 0;
                textBoxBacon.Text = "0,00";
            }
        }

        private void checkBoxFrango_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFrango.Checked == true)
            {
                numericFrango.Enabled = true;
                textBoxFrango.Enabled = true;
                numericFrango.Value = 1;
            }
            else
            {
                numericFrango.Enabled = false;
                textBoxFrango.Enabled = false;
                numericFrango.Value = 0;
                textBoxFrango.Text = "0,00";
            }
        }

        private void checkBoxAlface_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAlface.Checked == true)
            {
                numericAlface.Enabled = true;
                textBoxAlface.Enabled = true;
                numericAlface.Value = 1;
            }
            else
            {
                numericAlface.Enabled = false;
                textBoxAlface.Enabled = false;
                numericAlface.Value = 0;
                textBoxAlface.Text = "0,00";
            }
        }

        private void checkBoxTomate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTomate.Checked == true)
            {
                numericTomate.Enabled = true;
                textBoxTomate.Enabled = true;
                numericTomate.Value = 1;
            }
            else
            {
                numericTomate.Enabled = false;
                textBoxTomate.Enabled = false;
                numericTomate.Value = 0;
                textBoxTomate.Text = "0,00";
            }
        }

        private void checkBoxMilhoverde_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMilhoverde.Checked == true)
            {
                numericMilhoVerde.Enabled = true;
                textBoxMilhoverde.Enabled = true;
                numericMilhoVerde.Value = 1;
            }
            else
            {
                numericMilhoVerde.Enabled = false;
                textBoxMilhoverde.Enabled = false;
                numericMilhoVerde.Value = 0;
                textBoxMilhoverde.Text = "0,00";
            }
        }

        private void checkBoxErvilha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxErvilha.Checked == true)
            {
                numericErvilha.Enabled = true;
                textBoxErvilha.Enabled = true;
                numericErvilha.Value = 1;
            }
            else
            {
                numericErvilha.Enabled = false;
                textBoxErvilha.Enabled = false;
                numericErvilha.Value = 0;
                textBoxErvilha.Text = "0,00";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}