using Grpc.Core;
using System.Threading.Tasks;
using ZodiacService.DataAccess;

namespace ZodiacService.Services.MicroServices
{
    public class SpringService : SpringSeason.SpringSeasonBase
    {
        private const string FilePath = "./Resources/springSigns.txt";

        public override Task<AddSpringResponse> AddSpring(AddSpringRequest request, ServerCallContext context)
        {
            var sign = ZodiacOperations.GetSign(request.SpringDate, FilePath);

            return Task.FromResult(new AddSpringResponse
            {
                Status = AddSpringResponse.Types.Status.Success,
                Sign = sign
            });
        }
    }
}