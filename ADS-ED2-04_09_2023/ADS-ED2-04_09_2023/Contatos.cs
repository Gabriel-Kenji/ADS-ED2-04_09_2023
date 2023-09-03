using System;
using System.Collections;
using System.Collections.Generic;

namespace ADS_ED2_04_09_2023
{
    public class Contatos : IEnumerable
    {
        public List<Contato> agenda = new List<Contato>();

        public bool adicionar(Contato c)
        {if (!agenda.Contains(c))
            {
                agenda.Add(c);
                return true;
            }
            return false;
        }

        public Contato pesquisar(string email)
        {
            return agenda.Find(c => c.email == email);
        }

        public bool alterar(Contato contatoModificado)
        { int index = agenda.FindIndex(item => item.email == contatoModificado.email);
            if (index != -1)
            {
                agenda[index] = contatoModificado;
                return true;
            }
            return false;
        }

        public bool remover(Contato c)
        { 
            return agenda.Remove(c);
        }

        public string listar()
        {
            string re = "";
            foreach (Contato c in agenda)
            {
                re += c + "\n";
            }

            return re;
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}