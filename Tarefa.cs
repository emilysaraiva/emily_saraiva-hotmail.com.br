using System;
using System.Collections.Generic;

namespace To_do_list
{
    public class Tarefa
    {
        public string nomeTarefa;
        public int idTarefa = 1;



        public List<Tarefa> lista = new List<Tarefa>();



        public void adicionarTarefa()
        {
            Console.WriteLine("Dê um nome para sua tarefa: ");
            string nome = Console.ReadLine();
            lista.Add(new Tarefa
            {
                nomeTarefa = nome,
                idTarefa = idTarefa++,
            });

        }

        public void listarTarefas()
        {
            foreach (var cadaItem in lista)
            {

                Console.WriteLine($"0{cadaItem.idTarefa} - {cadaItem.nomeTarefa}");
            }

        }

        public void tarefasConcluidas()
        {
            Console.WriteLine("Me passa ai o ID da tarefa: ");
            int tarefasDone = int.Parse(Console.ReadLine());

            var teste = lista.Find(x => x.idTarefa == tarefasDone);

            if (teste != null)
            {
                Console.WriteLine($"{idTarefa} - {nomeTarefa} - Feita");
            }else{
                Console.WriteLine("Tarefa não encontrada");
            }


        }

    }
}