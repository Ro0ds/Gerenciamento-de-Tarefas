using TaskManagerApp.Formularios;
using TaskManagerApp.Models;
using TaskManagerApp.Seguranca;

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

        public bool LogarUsuario(string usuario, string senha)
        {
            Senhas senhas = new Senhas();

            // Verificar se usuario existe
            bool usuarioExiste = _context.Usuarios.Any(u => u.NomeUsuario == usuario);

            if(usuarioExiste)
            {
                // Verifica se a senha digitada está correta
                senhas.RegistraSenha(senha);
                string? senhaDigitada = senhas.CriptografarSenha(senha, out var salt);
                string? senhaDoBanco = _context.Usuarios.Where(u => u.NomeUsuario == usuario).Select(u => u.SenhaUsuario).FirstOrDefault();
                byte[]? saltSenhaDoBanco = _context.Usuarios.Where(u => u.NomeUsuario == usuario).Select(u => u.SaltSenhaUsuario).FirstOrDefault();

                bool senhaEstaCorreta = senhas.VerificarSenha(senha, senhaDoBanco, saltSenhaDoBanco);

                if(senhaEstaCorreta)
                {
                    string? nomeCompleto = _context.Usuarios.Where(u => u.NomeUsuario == usuario).Select(u => u.NomeCompleto).FirstOrDefault();

                    MessageBox.Show($"Bem vindo(a) {nomeCompleto}!", "Login realizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    string? dicaDaSenha = _context.Usuarios.Where(u => u.NomeUsuario == usuario).Select(u => u.DicaSenha).FirstOrDefault();
                    MessageBox.Show($"Senha incorreta.\nDica da senha: {dicaDaSenha}", "Senha incorreta", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Usuário não localizado na base de dados.", "Usuário não localizado!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
