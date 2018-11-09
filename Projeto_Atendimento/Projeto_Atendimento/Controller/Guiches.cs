using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Atendimento.Model
{
    class Guiches
    {
        private List<Guiche> listaGuiches;

        public List<Guiche> ListaGuiches { get { return this.listaGuiches; } set { listaGuiches = value; } }

        public Guiches()
        {
            listaGuiches = new List<Guiche>();

        }

        public void adicionar(Guiche guiche)
        {
            listaGuiches.Add(guiche);
        }
    }
}
