using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusContatos.model
{
    public class Agenda
    {
        private List<Contato> contatos;

        public Agenda()
        {
            contatos = new List<Contato>();
        }

        public void Adicionar(Contato contato)
        {
            contatos.Add(contato);
        }
        public List<Contato> Buscar()
        {
            return contatos;
        }

        public List<Contato> BuscarPorNome(String nome)
        {
            List<Contato> retorno = new List<Contato>();
            foreach (Contato c in contatos)
            {
                if (c.Nome.Equals(nome))
                {
                    retorno.Add(c);
                }
            }
            return retorno;
        }
    }
}
