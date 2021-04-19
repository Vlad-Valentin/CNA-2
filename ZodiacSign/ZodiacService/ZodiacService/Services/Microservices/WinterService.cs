using Grpc.Core;
using System.Threading.Tasks;
using ZodiacService.DataAccess;

namespace ZodiacService.Services.MicroServices
{
    public class WinterService : WinterSeason.WinterSeasonBase
    {
        private const string FilePath = "./Resources/winterSigns.txt";

        public override Task<AddWinterResponse> AddWinter(AddWinterRequest request, ServerCallContext context)
        {
            var sign = ZodiacOperations.GetSign(request.WinterDate, FilePath);

            return Task.FromResult(new AddWinterResponse
            {
                Status = AddWinterResponse.Types.Status.Success,
                Sign = sign
            });
        }
    }
}