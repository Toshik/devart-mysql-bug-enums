using System;
using System.Linq;

namespace DevartBug
{
	internal static class Program
	{
		private const int Times = 12;

        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            try
            {
                var dbContext = NewDbContext();
                var result1 = dbContext.Set<Record>().Select(x => x.EnumValue ?? SomeEnum.One).ToList();
                var result2 = dbContext.Set<Record>().Select(x => x.EnumValue == SomeEnum.Zero ? true : false).ToList();
                var result3 = dbContext.Set<Record>().Select(x => x.EnumValue == SomeEnum.Zero ? SomeEnum.One : x.EnumValue).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Finish!");
            Console.ReadKey();
        }

        private static MyDbContext NewDbContext()
           => new MyDbContext($"Server=localhost; Port=3306; Database=test; Uid=root; Pwd=xxx; CharSet=utf8; License Key={LicenseKey};");

        private const string LicenseKey =
            "";
    }
}
