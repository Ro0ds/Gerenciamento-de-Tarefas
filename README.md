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

* Configuração inicial do ambiente
```
mkdir TaskManagerApp
cd TaskManagerApp
git clone https://github.com/<seu-usuário>/Gerenciamento-de-Tarefas
```

* Pacotes Necessários
```
"Microsoft.EntityFrameworkCore", "Microsoft.EntityFrameworkCore.Design", "Microsoft.EntityFrameworkCore.Tools", "Pomelo.EntityFrameworkCore.MySql" | foreach {Install-Package $_}
```
* Configuração do banco de dados

Por enquanto, o banco de dados está definido diretamente no código, para isso siga as seguintes pastas e edite o método OnConfiguring

* Models
  * DbTaskmanagerContext.cs-
```
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseMySql("server=localhost;database=DB_TASKMANAGER;uid=<usuario>;pwd=<senha>", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.23-mysql"));
}
```

Para buildar e rodar, na pasta do projeto abra um terminal e rode o comando
```
Update-Database
```

* O banco de dados será criado e um usuário padrão já será inserido.
    * User: admin
    * Password: admin
