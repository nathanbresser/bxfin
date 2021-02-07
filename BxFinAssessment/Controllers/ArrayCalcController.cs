using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BxFinAssessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ArrayCalcController
    {
        private readonly IProductService _productService;

        public ArrayCalcController(
            IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("reverse")]
        public async Task<int[]> ReverseProductIds([FromQuery] int[] productIds)
        {
            var result = await _productService.ReverseProductIds(productIds);
            return result;
        }

        [HttpGet]
        [Route("deletepart")]
        public async Task<int[]> DeleteProduct([FromQuery] int position, [FromQuery] int[] productIds)
        {
            var result = await _productService.DeleteProduct(position, productIds);
            return result;
        }
    }
}
