using Grpc.Net.Client;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ZodiacClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Horoscope.HoroscopeClient(channel);

            var cancellationToken = new CancellationTokenSource(Timeout.Infinite);

            while (!cancellationToken.IsCancellationRequested)
            {
                string date = default;

                do
                {
                    Console.Write("Enter Date: ");
                    date = Console.ReadLine();

                } while (!ValidateDate(date));

                var zodiacToBeAdded = new Zodiac()
                { Date = date != null && date.Trim().Length > 0 ? date : "Invalid Date" };
                var response = await client.AddZodiacAsync(new AddZodiacRequest { Zodiac = zodiacToBeAdded });

                switch (response.Status)
                {
                    case AddZodiacResponse.Types.Status.Success:
                        Console.WriteLine($"\nResponse Status: {response.Status}\n\nSign: {response.Sign}\n\n");
                        break;
                    case AddZodiacResponse.Types.Status.Error:
                        Console.WriteLine($"\nResponse Status: {response.Status}\n\nInvalid Date!");
                        break;
                    default:
                        Console.WriteLine($"\nResponse Status: {response.Status}\n\nSomething Went Wrong!");
                        break;
                }
            }
        }

        public static bool ValidateDate(string date)
        {
            try
            {
                var dateString = date.Split("/");

                var dateTime = new DateTime(
                    int.Parse(dateString[2]),
                    int.Parse(dateString[0]),
                    int.Parse(dateString[1]));
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid Date - Does Not Exist!\n");
                return false;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid Date!\n");
                return false;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Date!\n");
                return false;
            }

            return true;
        }
    }
}