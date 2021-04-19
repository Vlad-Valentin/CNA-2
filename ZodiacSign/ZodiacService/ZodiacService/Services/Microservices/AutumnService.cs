using Grpc.Core;
using System.Threading.Tasks;
using ZodiacService.DataAccess;

namespace ZodiacService.Services.MicroServices
{
    public class AutumnService : AutumnSeason.AutumnSeasonBase
    {
        private const string FilePath = "./Resources/autumnSigns.txt";

        public override Task<AddAutumnResponse> AddAutumn(AddAutumnRequest request, ServerCallContext context)
        {
            var sign = ZodiacOperations.GetSign(request.AutumnDate, FilePath);

            return Task.FromResult(new AddAutumnResponse
            {
                Status = AddAutumnResponse.Types.Status.Success,
                Sign = sign
            });
        }
    }
}