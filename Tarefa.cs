using System;
using System.Collections.Generic;
using System.Linq;

namespace To_do_list
{
    public class Tarefa
    {

        public int idTarefa = 1;



        public List<task> lista = new List<task>();



        public void adicionarTarefa()
        {
            Console.WriteLine("Qual o nome da sua tarefa?: ");
            string nome = Console.ReadLine();
            lista.Add(new task
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

                Console.WriteLine($"{cadaItem.idTarefa} - {cadaItem.nomeTarefa}");

                if (cadaItem.statusDaTarefa)
                {
                    Console.WriteLine("feito");
                    Console.WriteLine("-----------------");
                }
                else
                {
                    Console.WriteLine("Não feito");
                    Console.WriteLine("-----------------");
                }

            }

        }

        public void tarefasConcluidas()
        {
            Console.WriteLine("Me passa ai o ID da tarefa: ");
            int tarefasDone = Convert.ToInt32(Console.ReadLine());

            var resultado = lista.Where(x => x.idTarefa == tarefasDone).First();

            resultado.statusDaTarefa = true;

        }

    }
}