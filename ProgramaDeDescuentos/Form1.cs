using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaDeDescuentos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            Spn_naranja.Enabled = false;
            Spn_amarilla.Enabled = false;
            Spn_azul.Enabled = false;
            Spn_blanca.Enabled = false;
            Spn_negra.Enabled=false;
            Spn_roja.Enabled = false;
            Spn_verde.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Btn_editNaranja_Click(object sender, EventArgs e)
        {
            Spn_naranja.Enabled=true;
        }

        private void Btn_saveNaranja_Click(object sender, EventArgs e)
        {
            int valnaranja = (int) Spn_naranja.Value;
            Spn_naranja.Enabled = false;
        }

        private void Btn_editRoja_Click(object sender, EventArgs e)
        {
            Spn_roja.Enabled = true;
        }

        private void Btn_saveRoja_Click(object sender, EventArgs e)
        {
            int valroja = (int)Spn_roja.Value;
            Spn_roja.Enabled = false;
        }

        private void Btn_editAzul_Click(object sender, EventArgs e)
        {
            Spn_azul.Enabled = true;
        }

        private void Btn_saveAzul_Click(object sender, EventArgs e)
        {
            int valazul = (int)Spn_azul.Value;
            Spn_azul.Enabled = false;
        }

        private void Btn_editAmarilla_Click(object sender, EventArgs e)
        {
            Spn_amarilla.Enabled = true;
        }

        private void Btn_saveAmarilla_Click(object sender, EventArgs e)
        {
            int valamarilla = (int)Spn_amarilla.Value;
            Spn_amarilla.Enabled = false;
        }

        private void Btn_editVerde_Click(object sender, EventArgs e)
        {
            Spn_verde.Enabled = true;
        }

        private void Btn_saveVerde_Click(object sender, EventArgs e)
        {
            int valverde = (int)Spn_verde.Value;
            Spn_verde.Enabled = false;
        }

        private void Btn_editNegra_Click(object sender, EventArgs e)
        {
            Spn_negra.Enabled = true;
        }

        private void Btn_saveNegra_Click(object sender, EventArgs e)
        {
            int valnegra = (int)Spn_negra.Value;
            Spn_negra.Enabled = false;
        }

        private void Btn_editBlanca_Click(object sender, EventArgs e)
        {
            Spn_blanca.Enabled = true;
        }

        private void Btn_saveBlanca_Click(object sender, EventArgs e)
        {
            int valblanca = (int)Spn_blanca.Value;
            Spn_blanca.Enabled = false;
        }
    }
}
