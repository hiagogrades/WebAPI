#Inicia Projeto WebAPI - Balta.io
 - Remove os arquivos do template padrão
 
#Adiciona o Model, Data (DataContext), instala o Entity Framework
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

#Configura a Class Startup e adiciona o Controller
 - Adiciona o DBContext na Class Startup.cs
    - No método ConfigureServices, adiciona o código:
        ******Pesquisar mais sobre******
            //Dizendo que irei trabalhar com DbContext
            services.AddDbContext<DataContext>(opt => opt.UseInMemoryDatabase("DataBase"));
            //Gestão de dependência no Data Context
            services.AddScoped<DataContext, DataContext>();

 - Adiciona a pasta Controllers
    Cria a classe:
    - CategoryController.cs

#Adiciona a ProductController
 - Codifica a Classe CategoryController.cs
 - Adiciona e codifica a Classe ProductController.cs

   INFORMAÇÕES ADICIONAIS:
   - [Route("{id:int}")] //Adicionando um id na rota. E utilizando|| restrição de rota utilizando o :int, para ser aceito somente números inteiros.
   - .AsNoTracking() //Utilizar como boa prática para que o EF não crie proxys das buscas (versões do objeto) ****Utilizar somente para select****
