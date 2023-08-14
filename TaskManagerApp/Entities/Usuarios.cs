using TaskManagerApp.Models;

namespace TaskManagerApp.Entities
{
    internal class Usuarios
    {
        private DbTaskmanagerContext _context = new DbTaskmanagerContext();

        public Usuarios() { }

     
        public void AdicionarNovoUsuario(Usuario usuario)
        {
            _context.Add(usuario);
            _context.SaveChanges();
        }
    }
}
