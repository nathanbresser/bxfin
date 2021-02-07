using System.Threading.Tasks;

namespace BxFinAssessment.Services
{
    public class ProductService : IProductService
    {

        public async Task<int[]> ReverseProductIds(int[] productIds)
        {
            int x = 0;
            int y = productIds.Length - 1;

            while (x < y)
            {
                var tmp = productIds[y];
                productIds[x] = productIds[y];
                productIds[y] = tmp;
                x++;
                y--;
            }
            return productIds;
        }

        public async Task<int[]> DeleteProduct(int position, int[] productIds)
        {
            int[] newProductIds = new int[(productIds.Length)-1];
            int newIndex = 0;

            for (int i = 0; i < productIds.Length; i++)
            {
                if (i < position-1 || i > position-1)
                {
                    newProductIds[newIndex] = productIds[i];
                    newIndex++;
                }
            }
            return newProductIds;
        }
    }
}
