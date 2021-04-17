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

            Console.WriteLine($"\nSign: ");

            string sign = default;

            var thisYear = int.Parse(zodiac.Date.Substring(6, 4));
            var thisMonth = int.Parse(zodiac.Date.Substring(0, 2));
            var thisDay = int.Parse(zodiac.Date.Substring(3, 2));

            var dateTime = new DateTime(thisYear, thisMonth, thisDay);

            switch (dateTime)
            {
                case { } when
                    (dateTime >= new DateTime(1000, 3, 1) &&
                     dateTime <= new DateTime(3000, 5, 31)):
                    {
                        sign = SpringService.GetSign(zodiac);
                        break;
                    }
                case { } when
                    (dateTime >= new DateTime(1000, 6, 1) &&
                     dateTime <= new DateTime(3000, 8, 31)):
                    {
                        sign = SummerService.GetSign(zodiac);
                        break;
                    }
                case { } when
                    (dateTime >= new DateTime(1000, 9, 1) &&
                     dateTime <= new DateTime(3000, 11, 30)):
                    {
                        sign = AutumnService.GetSign(zodiac);
                        break;
                    }

                default:
                    {
                        sign = WinterService.GetSign(zodiac);
                        break;
                    }
            }

            return Task.FromResult(new AddZodiacResponse()
            {
                Status = AddZodiacResponse.Types.Status.Success,
                Sign = sign
            });
        }
    }
}