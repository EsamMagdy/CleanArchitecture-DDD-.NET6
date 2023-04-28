using Application.Webinars.Queries.GetWebinarById;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Webinars.Commands.CreateWebinar;

namespace Presentation.Controllers;
public sealed class WebinarsController : BaseApiController
{
    [HttpGet("{webinarId:guid}")]
    [ProducesResponseType(typeof(WebinarResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetWebinar(Guid webinarId, CancellationToken cancellationToken = default)
    {
        var query = new GetWebinarByIdQuery(webinarId);

        var webinar = await Sender.Send(query, cancellationToken);

        return Ok(webinar);
    }

    [HttpPost]
    [ProducesResponseType(typeof(Guid), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateWebinar([FromBody] CreateWebinarRequest request, CancellationToken cancellationToken = default)
    {
        var command = request.Adapt<CreateWebinarCommand>;

        var webinarId = await Sender.Send(command, cancellationToken);

        return CreatedAtAction(nameof(GetWebinar), new { webinarId }, webinarId);
    }
}
