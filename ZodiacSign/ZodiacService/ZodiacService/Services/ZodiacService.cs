using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using ZodiacService.DataAccess;
using ZodiacService.Services.Microservices;

namespace ZodiacService.Services
{
    public class ZodiacService : Horoscope.HoroscopeBase
    {
        private readonly ZodiacOperations _zodiacOperations = new ZodiacOperations();

        private readonly ILogger<ZodiacService> _logger;
        public ZodiacService(ILogger<ZodiacService> logger)
        {
            _logger = logger;
        }

        public override Task<AddZodiacResponse> AddZodiac(AddZodiacRequest request, ServerCallContext context)
        {
            var zodiac = request.Zodiac;

            if (zodiac.Date.Equals("Invalid Date"))
            {
                Console.WriteLine("\nDate Is Blank!");
                return Task.FromResult(new AddZodiacResponse()
                { Status = AddZodiacResponse.Types.Status.Error, Sign = "Invalid Sign" });
            }

            Console.Write($"\nSign: ");

            var date = zodiac.Date.Split("/");
            var thisYear = int.Parse(date[2]);
            var thisMonth = int.Parse(date[0]);
            var thisDay = int.Parse(date[1]);

            var dateTime = new DateTime(thisYear, thisMonth, thisDay);

            var sign = dateTime switch
            {
                { } when (dateTime >= new DateTime(1000, 3, 1) && dateTime <= new DateTime(3000, 5, 31)) =>
                    SpringService.GetSign(zodiac),
                { } when (dateTime >= new DateTime(1000, 6, 1) && dateTime <= new DateTime(3000, 8, 31)) =>
                    SummerService.GetSign(zodiac),
                { } when (dateTime >= new DateTime(1000, 9, 1) && dateTime <= new DateTime(3000, 11, 30)) =>
                    AutumnService.GetSign(zodiac),
                _ => WinterService.GetSign(zodiac)
            };

            Console.Write($"{sign}\n\n");

            return Task.FromResult(new AddZodiacResponse()
            {
                Status = AddZodiacResponse.Types.Status.Success,
                Sign = sign
            });
        }
    }
}