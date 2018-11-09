using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Atendimento.Model
{
    class Senha
    {
        private int id;
        private DateTime dataGeracao;
        private DateTime horaGeracao;
        private DateTime dataAtendimento;
        private DateTime horaAtendimento;

        public int Id { get { return this.id; } set { id = value; } }
        public DateTime DataGeracao { get { return this.dataGeracao; } set { dataGeracao = value; } }
        public DateTime HoraGeracao { get { return this.horaGeracao; } set { horaGeracao = value; } }
        public DateTime DataAtendimento { get { return this.dataAtendimento; } set { dataAtendimento = value; } }
        public DateTime HoraAtendimento { get { return this.horaAtendimento; } set { horaAtendimento = value; } }

        public Senha (int id)
        {
            this.id = id;
            this.dataGeracao = DateTime.Now;
            this.horaGeracao = DateTime.Now;
        }

        public string dadosParciais()
        {
            return this.id + " - " + this.dataGeracao + "-" + this.horaGeracao;
        }

        public string dadosCompletos()
        {         
            return this.id + " - " + this.dataGeracao.Date + " - " + this.horaGeracao.Hour + " - "
                + this.dataAtendimento.ToString("dd/mm/yyyy")+ " - " + this.horaAtendimento.ToString("hh:mm");
        }
    }
}
