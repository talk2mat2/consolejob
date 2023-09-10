using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using testconsoleapp;

Host.CreateDefaultBuilder().ConfigureServices
    (services => services.AddHostedService<ConsoleWriter>())
    .Build().Run();