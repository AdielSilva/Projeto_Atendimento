using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Atendimento.Model
{
    class Senhas
    {
        int proxAtendimento;
        Queue<Senha> filaSenhas;

        public int ProxAtendimento { get { return this.proxAtendimento; } set { proxAtendimento = value; } }
        public Queue<Senha> FilaSenhas { get { return this.filaSenhas; } set { filaSenhas = value; } }

        public Senhas()
        {
            proxAtendimento = 1;
            filaSenhas = new Queue<Senha>();
        }

        public void gerar()
        {
            
            Senha senha = new Senha(proxAtendimento);
            this.proxAtendimento++;

            filaSenhas.Enqueue(senha);
        }
    }
}
