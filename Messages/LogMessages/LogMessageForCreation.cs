using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaService.Domain.Messages.Logs
{
    public class LogMessageForCreation
    {
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime DateTime { get; set; }
        public string Severity { get; set; }
    }
}
