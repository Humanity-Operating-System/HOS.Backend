using MediatR;

public sealed class GetClarityCommandHandler : IRequestHandler<GetClarityCommand, List<string>>
{
    private readonly IGoalProcessor _goalProcessor;
    public GetClarityCommandHandler(IGoalProcessor goalProcessor)
    {
        _goalProcessor = goalProcessor;
    }
    public async Task<List<string>> Handle(GetClarityCommand request, CancellationToken cancellationToken)
    {
        return await Task.Run(() =>  _goalProcessor.GenerateRoadmap(request.goal));
        
    }
}
