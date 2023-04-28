using Application.Abstractions.Messaging;
using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Webinars.Commands.CreateWebinar
{
    internal sealed class CreateWebinarCommandHandler:ICommandHandler<CreateWebinarCommand,Guid>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateWebinarCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


    }
}
