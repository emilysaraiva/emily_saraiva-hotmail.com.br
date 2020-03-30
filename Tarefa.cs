using System;
using System.Collections.Generic;
using System.Linq;

namespace To_do_list
{
    public class Tarefa
    {
        public string nomeTarefa;
        public int idTarefa = 1;

        public bool statusDaTarefa;



        public List<Tarefa> lista = new List<Tarefa>();



        public void adicionarTarefa()
        {
            Console.WriteLine("Dê um nome para sua tarefa: ");
            string nome = Console.ReadLine();
            lista.Add(new Tarefa
            {
                nomeTarefa = nome,
                idTarefa = idTarefa++,
                statusDaTarefa = false,
            });

        }

        public void listarTarefas()
        {
            foreach (var cadaItem in lista)
            {

                Console.WriteLine($"{cadaItem.idTarefa} - {cadaItem.nomeTarefa} - {statusDaTarefa}");



            }

        }

        public void tarefasConcluidas()
        {
            Console.WriteLine("Me passa ai o ID da tarefa: ");
            int tarefasDone = Convert.ToInt32(Console.ReadLine());

            var resultado = lista.Where(x => x.idTarefa == tarefasDone);

            statusDaTarefa = true;

        }

    }
}