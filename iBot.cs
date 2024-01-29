using Microsoft.Extensions.DependencyInjection;
using System;
namespace MyDiscordBot
{
    public interface IBot
    {
        Task StartAsync(ServiceProvider services);

        Task StopAsync();
    }
}