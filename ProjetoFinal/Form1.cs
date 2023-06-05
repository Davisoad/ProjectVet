using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class Form1 : Form
    {
        List<Animal> Lista = new List<Animal>();
        Cachorro c = null;
        Gato g = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Cachorro_Click(object sender, EventArgs e)
        {
            c= new Cachorro();
            lblCaracteristica.Text = "Vacina";
            btn_AddG.Enabled = false;
            btn_AddC.Enabled = true;

        }

        private void btn_Gato_Click(object sender, EventArgs e)
        {
            g = new Gato();
            lblCaracteristica.Text = "Idade";
            btn_AddG.Enabled = true;
            btn_AddC.Enabled = false;
        }

        private void btn_AddC_Click(object sender, EventArgs e)
        {
            cadastro(c);
            c.Vacina = txtCaracteristica.Text;
            Lista.Add(c);
            btn_AddC.Enabled = false;
            LimpaTextos();
            panel1.Enabled = true;

        }

        private void btn_AddG_Click(object sender, EventArgs e)
        {
            cadastro(g);
            g.Idade = int.Parse(txtCaracteristica.Text);
            Lista.Add(g);
            btn_AddG.Enabled = false;
            LimpaTextos();
            panel1.Enabled = true;
        }

        private void cadastro(Animal a)
        {
            a.Nome = txtNome.Text;
            a.Raca = txtRaca.Text;
            a.Preco = double.Parse(txtPreco.Text);
        }

        private void LimpaTextos()
        {
            txtNome.Text = "";
            txtRaca.Text = "";
            txtPreco.Text = "";
            txtCaracteristica.Text = "";
        }


        private void btn_Pesquisa_Click(object sender, EventArgs e)
        {
            foreach (var item in Lista)
            {
                if (item.Nome == txtPesquisaNome.Text)
                    lblPesquisa.Text = item.MostraDados();
            }
        }
    }
}
