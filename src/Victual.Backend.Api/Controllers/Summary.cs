using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Victual.Backend.Api.Controllers;

[ApiController]
[Route("/api/summary")]
public class Summary
{
    private IMediator _mediator;
    private IMapper _mapper;

    public Summary(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult> Get(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}