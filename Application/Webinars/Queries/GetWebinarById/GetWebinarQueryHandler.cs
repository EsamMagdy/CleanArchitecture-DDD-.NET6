using Application.Abstractions.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Webinars.Queries.GetWebinarById
{
    internal sealed class GetWebinarQueryHandler:IQueryHandler<GetWebinarByIdQuery,WebinarResponse>
    {
    }
}
