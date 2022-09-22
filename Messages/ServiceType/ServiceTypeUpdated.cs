using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaService.Domain.Messages.ServiceType
{
    public class ServiceTypeUpdated
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
