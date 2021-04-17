using System.Linq;
using ZodiacService.DataAccess;

namespace ZodiacService.Services.Microservices
{
    public class SpringService
    {
        public static string GetSign(Zodiac zodiac)
        {
            var zodiacs = ZodiacOperations.GetAllZodiacs();

            return (from variable in zodiacs

                    let startMonth = int.Parse(variable.Item1.Date.Substring(0, 2))
                    let startDay = int.Parse(variable.Item1.Date.Substring(3, 2))
                    let endMonth = int.Parse(variable.Item2.Date.Substring(0, 2))
                    let endDay = int.Parse(variable.Item2.Date.Substring(3, 2))

                    let thisMonth = int.Parse(zodiac.Date.Substring(0, 2))
                    let thisDay = int.Parse(zodiac.Date.Substring(3, 2))

                    where thisMonth == startMonth && thisDay >= startDay || thisMonth == endMonth && thisDay <= endDay
                    select variable.Item3).FirstOrDefault();
        }
    }
}