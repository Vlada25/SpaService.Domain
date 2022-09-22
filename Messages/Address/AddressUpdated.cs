using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaService.Domain.Messages.Address
{
    public class AddressUpdated
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
    }
}
