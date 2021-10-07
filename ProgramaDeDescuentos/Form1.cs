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
        public double PORC_NARANJA = 0.0;
        public double PORC_AMARILLA = 0.3;
        public double PORC_AZUL = 0.13;
        public double PORC_BLANCA = 1;
        public double PORC_NEGRA = 0.8;
        public double PORC_ROJA = 0.05;
        public double PORC_VERDE = 0.5;

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

        private void Btn_cargarValores_Click(object sender, EventArgs e)
        
        {
            decimal total_items = 0;
            decimal naranja = decimal.Parse(Spn_naranja.Text);
            decimal amarilla = decimal.Parse(Spn_amarilla.Text);
            decimal azul = decimal.Parse(Spn_azul.Text);
            decimal blanca = decimal.Parse(Spn_blanca.Text);
            decimal negra = decimal.Parse(Spn_negra.Text);
            decimal roja = decimal.Parse(Spn_roja.Text);
            decimal verde = decimal.Parse(Spn_verde.Text);

            total_items = naranja + amarilla + azul + blanca + negra + roja + verde;


            decimal res_naranja = naranja / total_items;
            decimal res_amarilla = amarilla / total_items;
            decimal res_azul = azul / total_items;
            decimal res_blanca = blanca / total_items;
            decimal res_negra = negra / total_items;
            decimal res_roja = roja / total_items;
            decimal res_verde = verde / total_items;

            txt_naranja.Text = decimal.Round(res_naranja * 100, 2).ToString();
            txt_amarilla.Text = decimal.Round(res_amarilla*100, 2).ToString();
            txt_azul.Text = decimal.Round(res_azul * 100, 2).ToString();
            txt_blanca.Text = decimal.Round(res_blanca * 100, 2).ToString();
            txt_negro.Text = decimal.Round(res_negra * 100, 2).ToString();
            txt_roja.Text = decimal.Round(res_roja * 100, 2).ToString();
            txt_verde.Text = decimal.Round(res_verde * 100, 2).ToString();


        }
    }
}
