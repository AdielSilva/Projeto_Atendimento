using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Atendimento.Model;

namespace Projeto_Atendimento
{
    public partial class Atendimento : Form
    {
        Guiches guiches;
        Senhas senhas;
        public Atendimento()
        {
            InitializeComponent();
            guiches = new Guiches();
            senhas = new Senhas();
        }

        private void buttonClickGerarSenha(object sender, EventArgs e)
        {
            senhas.gerar();
        }

        private void cliqueButtonAdicionarGuiche(object sender, EventArgs e)
        {
            guiches.adicionar(new Guiche());
            labelNumQtdGuiche.Text = guiches.ListaGuiches.Count.ToString();
        }

        private void clickButtonChamarSenha(object sender, EventArgs e)
        {
            int indice = int.Parse(textGuiche.Text);
            
            guiches.ListaGuiches[indice-1].chamar(senhas.FilaSenhas);
        }

        private void clickButtonListarSenha(object sender, EventArgs e)
        {
            listSenhas.Items.Clear();
           foreach (Senha senha in senhas.FilaSenhas)
           {               
                listSenhas.Items.Add(senha.dadosParciais());
           }
        }

        private void clickButtonListarAtendimento(object sender, EventArgs e)
        {
            listAtendimentos.Items.Clear();
            int indice = int.Parse(textGuiche.Text)-1;
            foreach(Senha senha in guiches.ListaGuiches[indice].Atendimentos)
            {
                listAtendimentos.Items.Add(senha.dadosCompletos());
            }
        }
    }
}
