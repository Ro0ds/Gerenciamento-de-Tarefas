using System.Data;
using TaskManagerApp.Models;

namespace TaskManagerApp.TelasAdministrador
{
    public partial class ExcluirUsuario : Form
    {
        private DbTaskmanagerContext _context = new DbTaskmanagerContext();
        private int CodUsuario;

        public ExcluirUsuario()
        {
            InitializeComponent();
            ListarUsuariosNoGrid();
        }

        private void ListarUsuariosNoGrid()
        {
            List<Usuario> usuarios = _context.Usuarios.ToList();

            DataTable tabela = new DataTable();
            tabela.Columns.Add("CÓDIGO USUÁRIO", typeof(int));
            tabela.Columns.Add("NOME COMPLETO", typeof(string));
            tabela.Columns.Add("NOME USUÁRIO", typeof(string));
            tabela.Columns.Add("GRUPO PERMISSÃO", typeof(string));
            tabela.Columns.Add("USUÁRIO ATIVO", typeof(bool));

            foreach(Usuario usuario in usuarios)
            {
                tabela.Rows.Add(usuario.CodUsuario, usuario.NomeCompleto, usuario.NomeUsuario, usuario.GrupoPermissao, usuario.UsuarioAtivo);
            }

            gridUsuarios.DataSource = tabela;
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            CodUsuario = int.Parse(txt_codUsuario.Text);

            Usuario usuario = _context.Usuarios.Find(CodUsuario);

            if(usuario != null)
            {
                if(!UsuarioPossuiPendencias(usuario))
                {
                    try
                    {
                        _context.Remove(usuario);
                        _context.SaveChanges();

                        MessageBox.Show($"Usuário {CodUsuario} removido com sucesso!", "Remover Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"Não foi possível remover o usuário.\nErro: {ex.Message}", "Remover Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("Usuário possui tarefas cadastradas, deseja remover todas?", "Usuário com pendencias", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(resultado == DialogResult.Yes)
                    {
                        var tarefas = _context.Tarefas.Where(t => t.CodUsuario == CodUsuario).ToList();

                        try
                        {

                            _context.Tarefas.RemoveRange(tarefas);


                            MessageBox.Show("Tarefas removidas com sucesso!", "Removação de tarefas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show($"Não foi possível remover as pendencias do usuário.\nErro: {ex.Message}", "Remover Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Operação cancelada", "Removação de tarefas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            ListarUsuariosNoGrid();
        }

        private bool UsuarioPossuiPendencias(Usuario usuario)
        {
            return _context.Tarefas.Any(t => t.CodUsuario == usuario.CodUsuario);
        }
    }
}
