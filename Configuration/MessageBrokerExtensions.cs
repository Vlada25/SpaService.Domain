using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaService.Domain.Configuration
{
    public static class MessageBrokerExtensions
    {
        public static void ConfigureMessageBroker(this IServiceCollection services, 
            IConfiguration configuration,
            Action<IBusRegistrationConfigurator> consumersConfig)
        {
            var messagingConfig = configuration.GetSection("Messaging");

            if (!Enum.TryParse(messagingConfig["MessageBrokerType"], true, out MessageBrokerType type))
            {
                throw new Exception($"Broker \"{messagingConfig["MessageBrokerType"]}\" is not supported");
            }

            services.AddMassTransit(x =>
            {
                consumersConfig?.Invoke(x);

                switch (type)
                {
                    case MessageBrokerType.RabbitMQ:
                        x.UsingRabbitMq((context, cfg) =>
                        {
                            cfg.Host(messagingConfig["Host"], "/", h => {
                                h.Username(messagingConfig["UserName"]);
                                h.Password(messagingConfig["Password"]);
                            });

                            cfg.ConfigureEndpoints(context);
                        });
                        break;
                    case MessageBrokerType.AzureServiceBus:
                        x.UsingAzureServiceBus((context, cfg) =>
                        {
                            cfg.Host(messagingConfig["Host"]);
                            cfg.ConfigureEndpoints(context);
                        });
                        break;
                }
            });
        }
    }
}
