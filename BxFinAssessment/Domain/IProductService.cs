using System.Threading.Tasks;

namespace BxFinAssessment
{
    public interface IProductService
    {

        Task<int[]> ReverseProductIds(int[] productIds);

        Task<int[]> DeleteProduct(int position, int[] productIds);

    }
}
