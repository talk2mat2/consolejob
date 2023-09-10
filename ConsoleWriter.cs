using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testconsoleapp
{
    internal class ConsoleWriter : IHostedService
    {
        public async Task StartAsync(CancellationToken cancellationToken)
        {
            while(!cancellationToken.IsCancellationRequested)
            {
                Console.WriteLine("hello martins");
                await Delay(432000000000);
                
            }
          
        }
        static async Task Delay(long delay)
        {
            while (delay > 0)
            {
                var currentDelay = delay > int.MaxValue ? int.MaxValue : (int)delay;
                await Task.Delay(currentDelay);
                delay -= currentDelay;
            }
        }
        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
