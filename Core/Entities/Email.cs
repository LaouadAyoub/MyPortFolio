using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Email: EntityBase
    {
        public string Name { get; set; }
        public string Emaill { get; set; }
        public string Number { get; set; }
        public string Message { get; set; }
    }
}
