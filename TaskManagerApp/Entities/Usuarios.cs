using Microsoft.EntityFrameworkCore;
using TaskManagerApp.Models;
using TaskManagerApp.Seguranca;

namespace TaskManagerApp.Entities
{
    internal class Usuarios
    {
        private DbTaskmanagerContext _context = new DbTaskmanagerContext();
        //string? dicaDaSenha = _context.Usuarios.Where(u => u.NomeUsuario == usuario).Select(u => u.DicaSenha).FirstOrDefault();

        public Usuarios() { }

        public void AdicionarNovoUsuario(Usuario usuario)
        {
            _context.Add(usuario);
            _context.SaveChanges();
        }

        public bool LogarUsuario(string usuario, string senha)
        {
            if(UsuarioExiste(usuario))
            {
                if(SenhaEstaCorreta(usuario, senha))
                {
                    if(UsuarioAtivo(usuario))
                    {
                        string? nomeCompleto = _context.Usuarios.Where(u => u.NomeUsuario == usuario).Select(u => u.NomeCompleto).FirstOrDefault();
                        int idUsuario = _context.Usuarios.Where(u => u.NomeUsuario == usuario).Select(u => u.CodUsuario).FirstOrDefault();

                        MessageBox.Show($"Bem vindo(a) {nomeCompleto}!", "Login realizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        TelaPrincipal.UsuarioAdministrador(_context.Usuarios.Where(u => u.NomeUsuario == usuario).Select(u => u.GrupoPermissao == "ADMINISTRADOR").FirstOrDefault());
                        TelaPrincipal.InformacoesDeUsuario(nomeCompleto, idUsuario);

                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Usuário está inativo, entre em contato com o administrador do sistema.", "Usuário inativo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show($"Senha incorreta.", "Senha incorreta", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Usuário não localizado na base de dados.", "Usuário não localizado!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool UsuarioExiste(string usuario)
        {
            return _context.Usuarios.Any(u => u.NomeUsuario == usuario);
        }

        private bool SenhaEstaCorreta(string usuario, string senha)
        {
            Senhas instanciaSenha = new Senhas();

            instanciaSenha.RegistraSenha(senha);
            string? senhaDoBanco = _context.Usuarios.Where(u => u.NomeUsuario == usuario).Select(u => u.SenhaUsuario).FirstOrDefault();
            byte[]? saltSenhaDoBanco = _context.Usuarios.Where(u => u.NomeUsuario == usuario).Select(u => u.SaltSenhaUsuario).FirstOrDefault();

            return instanciaSenha.VerificarSenha(senha, senhaDoBanco, saltSenhaDoBanco);
        }

        private bool UsuarioAtivo(string usuario)
        {
            return _context.Usuarios.Where(u => u.NomeUsuario == usuario).Any(u => u.UsuarioAtivo == true);
        }
    }
}
