using TaskManagerApp.Models;

namespace TaskManagerApp.Entities
{
    internal class Tarefas
    {
        private DbTaskmanagerContext _context = new DbTaskmanagerContext();

        public Tarefas() { }

        public bool AdicionarTarefa(Tarefa tarefa)
        {
            try
            {
                _context.Add(tarefa);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível criar a tarefa na base de dados.\nErro: {ex.Message}", "Adicionar tarefa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}