using System.Threading.Tasks;

namespace BxFinAssessment.Services
{
    public class ProductService : IProductService
    {

        public Task<int[]> ReverseProductIds(int[] productIds)
        {
            int x = 0;
            int y = productIds.Length - 1;

            while (x < y)
            {
                var tmp = productIds[x];
                productIds[x] = productIds[y];
                productIds[y] = tmp;
                x++;
                y--;
            }
            return Task.FromResult(productIds);
        }

        public Task<int[]> DeleteProduct(int position, int[] productIds)
        {
            int[] updatedProductIds = new int[(productIds.Length)-1];
            int updatedIndex = 0;

            for (int i = 0; i < productIds.Length; i++)
            {
                if (i < position-1 || i > position-1)
                {
                    updatedProductIds[updatedIndex] = productIds[i];
                    updatedIndex++;
                }
            }
            return Task.FromResult(updatedProductIds);
        }
    }
}
