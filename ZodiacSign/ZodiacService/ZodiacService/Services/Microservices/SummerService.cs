using System.Linq;
using ZodiacService.DataAccess;

namespace ZodiacService.Services.Microservices
{
    public class SummerService
    {
        public static string GetSign(Zodiac zodiac)
        {
            var zodiacs = ZodiacOperations.GetAllZodiacs();

            return (from variable in zodiacs

                    let startMonth = int.Parse(variable.Item1.Date.Substring(0, 2))
                    let startDay = int.Parse(variable.Item1.Date.Substring(3, 2))
                    let endMonth = int.Parse(variable.Item2.Date.Substring(0, 2))
                    let endDay = int.Parse(variable.Item2.Date.Substring(3, 2))

                    let date = zodiac.Date.Split("/")
                    let thisMonth = int.Parse(date[0])
                    let thisDay = int.Parse(date[1])

                    //where startMonth >= 6 && startMonth <= 8 && endMonth >= 6 && endMonth <= 8
                    where thisMonth == startMonth && thisDay >= startDay || thisMonth == endMonth && thisDay <= endDay
                    select variable.Item3).FirstOrDefault();
        }
    }
}