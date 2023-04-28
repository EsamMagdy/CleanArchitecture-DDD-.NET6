using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseApiController: ControllerBase
    {
        protected readonly IMediator Sender;
        public BaseApiController(IMediator sender)
        {
            Sender = sender;
        }
        public BaseApiController()
        {

        }
    }
}
