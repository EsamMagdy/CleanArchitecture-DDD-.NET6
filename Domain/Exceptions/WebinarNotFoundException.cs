using Domain.Exceptions.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class WebinarNotFoundException : NotFoundException
    {
        public WebinarNotFoundException(string message) : base(message )
        {

        }
    }
}
