# Gerenciamento de Tarefas

Um app simples para gerenciamento de tarefas sendo contruído para fins de estudos!

* Linguagem: C# + Windows Forms
* EntityFrameworkCore
* Banco de Dados: MySQL

## TODO

* Tela de recuperação de senha com confirmação por e-mail e/ou alguma outra autenticação
* Edição de tarefas
* Exclusão de tarefas
* Inativação/Exclusão de usuários
* Perfil de usuário
* Listagem de tarefas por status
* Configurações sobre banco de dados (possibilidade de usar o sistema em rede?)

## Desenvolvimento

Caso queira fazer parte do desenvolvimento e/ou apenas clonar o aplicativo, modifique a seguinte linha com algum login desejável do MySQL:

* Models
  * DbTaskmanagerContext.cs-
```
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseMySql("server=localhost;database=DB_TASKMANAGER;uid=<usuario>;pwd=<senha>", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.23-mysql"));
}
```
