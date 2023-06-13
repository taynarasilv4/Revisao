using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revisao
{
    public partial class Divisao : Form
    {
        public Divisao()
        {
            InitializeComponent();
            tx_Resultado.Text = "";
        }

        private void tx_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(tx_valor1.Text);
                int b = Convert.ToInt32(tx_valor2.Text);

                int c = a / b;
                MessageBox.Show(c.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao Dividir!");
            }
            finally
            {
                MessageBox.Show("Vai executar de qualquer forma!");
            }
            

        }
    }
}
