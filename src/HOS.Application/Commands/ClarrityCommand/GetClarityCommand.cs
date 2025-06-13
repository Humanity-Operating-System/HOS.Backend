using MediatR;

public record GetClarityCommand(string goal): IRequest<List<string>>;