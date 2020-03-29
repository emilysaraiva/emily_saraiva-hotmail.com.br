using System;

namespace To_do_list
{
    public class Menu
    {
            Tarefa n = new Tarefa();

        public void menuPrincipal()
        {
            Console.WriteLine("To-Do List");
            Console.WriteLine("Escolha uma ação");
            Console.WriteLine("1- Adicionar uma nova tarefa");
            Console.WriteLine("2- Ver sua lista de tarefas");
            Console.WriteLine("3- Concluir uma tarefa");
            Console.WriteLine("0- Sair");

             int escolhaDoUsuario = int.Parse(Console.ReadLine());

             switch (escolhaDoUsuario)
            {
                case 0:
                    Console.WriteLine("Programa Finalizado!");
                break;

                case 1:
                    Console.WriteLine("Voce escolheu a opção 1");
                     
                     n.adicionarTarefa();
                     menuPrincipal();

                    break;

                case 2:
                    Console.WriteLine("Tarefas a serem concluidas:");

                    n.listarTarefas();
                    menuPrincipal();

                    break;

                case 3:
                    Console.WriteLine("Voce escolheu a opção 3");
                    n.tarefasConcluidas();
                    menuPrincipal();
                    break;

                default:
                  Console.WriteLine("Valor inválido");
                  break;


            }
        }

    }
}