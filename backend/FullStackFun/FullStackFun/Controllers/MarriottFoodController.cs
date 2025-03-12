using FullStackFun.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FullStackFun.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MarriottFoodController : ControllerBase
    {
        private FoodDbContext _foodContext;
        public MarriottFoodController(FoodDbContext temp)
        {
            _foodContext = temp;
        }

        [HttpGet(Name = "GetMarriottFood")]
        public IEnumerable<MarriottFood> Get()
        {
            IEnumerable<MarriottFood> foodList = _foodContext.Foods.ToList();

            return foodList;

        }
    }
}
