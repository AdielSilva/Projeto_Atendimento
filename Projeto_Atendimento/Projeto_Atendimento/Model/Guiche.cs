using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Atendimento.Model

{
    class Guiche
    {
        private int id;
        private Queue<Senha> atendimentos;

        public int Id { get { return id; } set { this.id = value; } }
        public Queue<Senha> Atendimentos { get { return atendimentos; } }


        public Guiche()
        {
            atendimentos = new Queue<Senha>();
            this.id = 0;
        }

        public Guiche(int id)
        {
            atendimentos = new Queue<Senha>();
            this.id = id;
        }

        public bool chamar(Queue<Senha>filaSenha)
        {
            if (filaSenha.Count == 0)
                return false;

            Senha senha = filaSenha.Dequeue();

            senha.DataGeracao = DateTime.Now;
            senha.HoraGeracao = DateTime.Now;

            atendimentos.Enqueue(senha);
            return true;
              
        }

    }
}
