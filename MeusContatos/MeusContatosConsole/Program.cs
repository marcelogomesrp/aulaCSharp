﻿using MeusContatos.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusContatosConsole
{
    public class Program
    {
        private Agenda agenda;
        public Program()
        {
            agenda = new Agenda();
        }
        public void menuPrincipal()
        {
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine(" *** Menu ***");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Incluir");
                Console.WriteLine("2 - Listar todos");
                Console.WriteLine("3 - Buscar por nome");
                Console.WriteLine("Entre com a opcao desejada: ");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 0: bye(); break;
                    case 1: incluir(); break;
                    case 2: buscar(); break;
                    case 3: buscarPorNome(); break;
                    default: opcaoInvalida(); break;
                }
            } while (op != 0);
        }

        private void opcaoInvalida()
        {
            Console.Clear();
            Console.WriteLine("Opcao invalida.");
            Console.WriteLine("Pressione uma tecla para retornar");
            Console.ReadKey();
        }
        private void buscarPorNome()
        {
            Console.Clear();
            Console.WriteLine("*** Buscar por nome *** ");
            Console.WriteLine("Entre com  o nome: ");
            String nome = Console.ReadLine();
            List<Contato> contatos = agenda.BuscarPorNome(nome);
            if (contatos.Count == 0)
            {
                Console.WriteLine("Nome nao encontrado.");
            }
            else
            {
                Console.WriteLine("Nome\tFone");
                foreach (Contato c in contatos)
                {
                    Console.WriteLine("{0}\t{1}", c.Nome, c.Telefone);
                }
                
            }
            Console.WriteLine("Pressione uma tecla para retornar");
            Console.ReadKey();
        }
        private void buscar()
        {
            Console.Clear();
            Console.WriteLine("*** Todos *** ");
            Console.WriteLine("Nome\tFone");
            foreach (Contato c in agenda.Buscar())
            {
                Console.WriteLine("{0}\t{1}", c.Nome, c.Telefone);
            }
            Console.WriteLine("Pressione uma tecla para retornar");
            Console.ReadKey();
        }
        private void incluir()
        {
            Console.Clear();
            Contato contato = new Contato();
            Console.WriteLine("*** Incluir novo contato ***");
            Console.WriteLine("Entre com o nome: ");
            contato.Nome = Console.ReadLine();
            Console.WriteLine("Entre com o telefone: ");
            contato.Telefone = Console.ReadLine();
            agenda.Adicionar(contato);
            Console.WriteLine("Contato adicionado com sucesso, pressione uma tecla para retornar");
            Console.ReadKey();
        }
        private void bye()
        {
            Console.Clear();
            Console.WriteLine("Bye bye...");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.menuPrincipal();

        }
    }
}
