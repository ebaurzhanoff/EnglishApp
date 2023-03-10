using MediatR;

namespace Application.Handlers.GrammarRequest.Command.CreateGrammar;

public class CreateGrammarCommand : IRequest<Guid>
{
    public CreateGrammarRequest Request { get; set; } = null!;
}


public class CreateGrammarCommandHandler : IRequestHandler<CreateGrammarCommand, Guid>
{
    public Task<Guid> Handle(CreateGrammarCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
