using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WorkShopAspnetCore.Controllers
{
    [Route("api/pessoas")]
    public class PessoasController : Controller
    {
        private readonly DataContext _dataContext;

        public PessoasController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetPessoas()
        {
            var pessoas = await _dataContext.Pessoas.ToListAsync();
            return Json(pessoas);
        }
    }
}
