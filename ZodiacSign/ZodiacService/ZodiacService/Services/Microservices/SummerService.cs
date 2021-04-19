using Grpc.Core;
using System.Threading.Tasks;
using ZodiacService.DataAccess;

namespace ZodiacService.Services.MicroServices
{
    public class SummerService : SummerSeason.SummerSeasonBase
    {
        private const string FilePath = "./Resources/summerSigns.txt";

        public override Task<AddSummerResponse> AddSummer(AddSummerRequest request, ServerCallContext context)
        {
            var sign = ZodiacOperations.GetSign(request.SummerDate, FilePath);

            return Task.FromResult(new AddSummerResponse
            {
                Status = AddSummerResponse.Types.Status.Success,
                Sign = sign
            });
        }
    }
}