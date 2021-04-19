using Grpc.Core;
using Grpc.Net.Client;
using System;
using System.Threading.Tasks;

namespace ZodiacService.Services
{
    public class ZodiacService : Horoscope.HoroscopeBase
    {
        public override Task<AddZodiacResponse> AddZodiac(AddZodiacRequest request, ServerCallContext context)
        {
            var zodiac = request.Zodiac;

            if (zodiac.Date.Equals("Invalid Date"))
            {
                Console.WriteLine("\nDate Is Blank!");
                return Task.FromResult(new AddZodiacResponse()
                { Status = AddZodiacResponse.Types.Status.Error, Sign = "Invalid Sign" });
            }

            using var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var date = zodiac.Date.Split("/");
            var thisYear = int.Parse(date[2]);
            var thisMonth = int.Parse(date[0]);
            var thisDay = int.Parse(date[1]);

            var dateTime = new DateTime(thisYear, thisMonth, thisDay);
            string sign;

            switch (dateTime)
            {
                case { } when dateTime >= new DateTime(thisYear, 3, 1) && dateTime <= new DateTime(thisYear, 5, 31):
                    var springClient = new SpringSeason.SpringSeasonClient(channel);
                    var springResponse = springClient.AddSpring(new AddSpringRequest() { SpringDate = zodiac.Date });
                    sign = springResponse.Sign;
                    break;
                case { } when dateTime >= new DateTime(thisYear, 6, 1) && dateTime <= new DateTime(thisYear, 8, 31):
                    var summerClient = new SummerSeason.SummerSeasonClient(channel);
                    var summerResponse = summerClient.AddSummer(new AddSummerRequest() { SummerDate = zodiac.Date });
                    sign = summerResponse.Sign;
                    break;
                case { } when dateTime >= new DateTime(thisYear, 9, 1) && dateTime <= new DateTime(thisYear, 11, 30):
                    var autumnClient = new AutumnSeason.AutumnSeasonClient(channel);
                    var autumnResponse = autumnClient.AddAutumn(new AddAutumnRequest() { AutumnDate = zodiac.Date });
                    sign = autumnResponse.Sign;
                    break;
                default:
                    var winterClient = new WinterSeason.WinterSeasonClient(channel);
                    var winterResponse = winterClient.AddWinter(new AddWinterRequest() { WinterDate = zodiac.Date });
                    sign = winterResponse.Sign;
                    break;
            }

            Console.WriteLine($"\nSign: {sign}\n");

            return Task.FromResult(new AddZodiacResponse()
            { Status = AddZodiacResponse.Types.Status.Success, Sign = sign });
        }
    }
}