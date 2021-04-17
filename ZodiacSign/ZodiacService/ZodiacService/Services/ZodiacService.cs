using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Microsoft.Extensions.Logging;
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

        //public override Task<GetAllZodiacsResponse> GetAllZodiacs(Empty request, ServerCallContext context)
        //{
        //    _logger.Log(LogLevel.Information, "GetAllZodiacs called");

        //    var zodiacs = _zodiacOperations.GetAllZodiacs();

        //    var response = new GetAllZodiacsResponse();
        //     //response.Zodiacs.AddRange(zodiacs);

        //    return Task.FromResult(response);
        //}

        //public string GetSign(Zodiac zodiac)
        //{
        //    var zodiacs = _zodiacOperations.GetAllZodiacs();

        //    return (from variable in zodiacs

        //            let startMonth = int.Parse(variable.Item1.Date.Substring(0, 2))
        //            let startDay = int.Parse(variable.Item1.Date.Substring(3, 2))
        //            let endMonth = int.Parse(variable.Item2.Date.Substring(0, 2))
        //            let endDay = int.Parse(variable.Item2.Date.Substring(3, 2))

        //            let thisMonth = int.Parse(zodiac.Date.Substring(0, 2))
        //            let thisDay = int.Parse(zodiac.Date.Substring(3, 2))

        //            where thisMonth == startMonth && thisDay <= startDay || thisMonth == endMonth && thisDay <= endDay
        //            select variable.Item3).FirstOrDefault();
        //}

        public override Task<AddZodiacResponse> AddZodiac(AddZodiacRequest request, ServerCallContext context)
        {
            var zodiac = request.Zodiac;

            if (zodiac.Date.Equals("Invalid Date"))
            {
                Console.WriteLine("\nDate Is Blank!");
                return Task.FromResult(new AddZodiacResponse()
                { Status = AddZodiacResponse.Types.Status.Error, Sign = "Invalid Sign" });
            }

            //if (!ValidateDate(zodiac.Date))
            //{
            //    Console.WriteLine("\nDate Is Invalid!");
            //    return Task.FromResult(new AddZodiacResponse()
            //    { Status = AddZodiacResponse.Types.Status.Error, Sign = "Invalid Sign" });
            //}

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


            //var sign = GetSign(zodiac);

            return Task.FromResult(new AddZodiacResponse()
            {
                Status = AddZodiacResponse.Types.Status.Success,
                Sign = sign
            });
        }

        //public static bool ValidateDate(string date)
        //{
        //    var month = int.Parse(date.Substring(0, 2));
        //    var day = int.Parse(date.Substring(3, 2));
        //    var year = int.Parse(date.Substring(6, 4));

        //    try
        //    {
        //        var dateTime = new DateTime(year, month, day);
        //    }
        //    catch (ArgumentOutOfRangeException)
        //    {
        //        Console.WriteLine("Invalid Date - Does Not Exist!\n");
        //        return false;
        //    }

        //    var regex = new Regex("([0-9]{2})/([0-9]{2})/([0-9]{4})");
        //    var match = regex.Match(date);

        //    return match.Success;
        //}
    }
}

/*Determine the zodiac sign that corresponds to a valid calendar date entered.

    The assignment involves entering a calendar date (month/day/year) on the client side. Here, the entered date will be validated in accordance to the following criteria: 

The format must be month/day/year (e.g. 01/01/1999 but also 1/1/1999)
The message should only contain numbers and the "/" sign, correctly placed 
The date has to be valid (pay attention to leap years)

If and only if the input is valid, it will be sent to the server. 

    The server will get the zodiac intervals from a file and determine the right zodiac sign.
    As a response, the zodiac sign’s name will be sent back to the client. 
    If the input is not valid, no zodiac sign will be sent and the errors should be handled ACCORDINGLY.

    The zodiac signs will be grouped based on their season. Each season will be handled by a microservice.

    Scoring Details
1.5 points - ex officio (test with 3 theoretical questions)
3 points - “basic” components(well structured proto methods + server basic implementation + client connection)
1 point - client validations(+leap year)
1 point - server implementation(read the intervals from a file and determine the zodiac sign)
1.5 points - clean code
1 point - proper error handling on both server and client
1 point - using microservices, group the zodiac signs based on the season

Obs! Mandatory repository with minimum 10 commits.*/
