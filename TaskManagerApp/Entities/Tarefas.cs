using TaskManagerApp.Models;

namespace TaskManagerApp.Entities
{
    internal class Tarefas
    {
        private DbTaskmanagerContext _context = new DbTaskmanagerContext();

        public Tarefas() { }

        public void AdicionarTarefa(Tarefa tarefa)
        {
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();
        }
    }
}