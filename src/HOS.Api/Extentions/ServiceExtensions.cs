public static class ServiceExtentions
{
    public static void ConfigureServiceExtentions(this IServiceCollection services)
    {
        services.AddScoped<IGoalProcessor, GoalProcessor>();
    }
}