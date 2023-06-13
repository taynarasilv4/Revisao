namespace Revisao
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void tx_Divisao_Click(object sender, EventArgs e)
        {
            Divisao dv = new Divisao();
            dv.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sexo = "";
            if(feminino.Checked )
            { 
                sexo = feminino.Text;
            }
            else
            {
                sexo= Masculino.Text;
            }
            MessageBox.Show(sexo);
        }
    }
}