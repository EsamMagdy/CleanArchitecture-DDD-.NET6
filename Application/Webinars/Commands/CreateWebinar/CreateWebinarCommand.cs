using Application.Abstractions.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Webinars.Commands.CreateWebinar
{
    public sealed record class CreateWebinarCommand(string Name, DateTime ScheduleOn) : ICommand<Guid>;
}
