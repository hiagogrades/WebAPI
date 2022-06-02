using System.Collections.Generic;
using System.Threading.Tasks; //Para trabalhar de maneira asincrona 
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("v1/categories")] //Definindo uma rota e vercionando como v1 (Versão 1)
    //herdando as propriedades da classe ControllerBase
    public class CategoryController : ControllerBase
    {
        [HttpGet] //Adicionando o primeito método
        [Route("")] //Adicionando a rota vazia ("") => significa que ele irá concatenar tudo a v1/categories...
        //Retorna de maneira asincrona uma task e, o resultado de uma lista de Categorias
        public async Task<ActionResult<List<Category>>> Get(
            //Utiliza o FromServices para capturar o data context que está na memória
            //DataContext é utilizado como parâmetro para acesso ao código
            [FromServices] DataContext context)
        {
            //Utiliza o método async AWAIT para executar
            //Busta todas as categorias
            var categories = await context.Categories.ToListAsync();
            return categories;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Category>> Post(
            [FromServices] DataContext context, //recebe do serviço o DataContext para ser injetado
            [FromBody] Category model) //Recebe do corpo da requisição a categoria
        {
            //Verifica se possui todos os requisitos da Category
            if (ModelState.IsValid)
            {
                context.Categories.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}