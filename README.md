#Inicia Projeto WebAPI - Balta.io
 - Remove os arquivos do template padrão
 - Adiciona a pasta MODELS
    Cria as classes:
     - Category.cs 
     - Produto.cs
 - Adicona a pasta Data
    Cria a classe:
     - DataContext.cs

    Instala o package do Entity Framework para utilizar a herança do DBContext
     - dotnet add package Microsoft.EntityFrameWorkCore.InMemory -v 5.0
     (
         InMemory => "O Banco será utilizado em memória";
         -v => Foraçando utilizar a versão 5.0, compatível com a versão do projeto
    )
