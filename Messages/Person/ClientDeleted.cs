using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaService.Domain.Messages.Person
{
    public class ClientDeleted
    {
        public Guid Id { get; set; }
    }
}
