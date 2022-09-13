using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaService.Domain.Configuration
{
    public enum BrokerTypes
    {
        RabbitMQ,
        AzureServiceBus,
        InMemory,
        SQS
    }
}
