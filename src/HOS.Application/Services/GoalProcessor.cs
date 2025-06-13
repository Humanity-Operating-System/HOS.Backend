
public sealed class GoalProcessor : IGoalProcessor
{
    public List<string> GenerateRoadmap(string goal)
{
    if (goal.ToLower().Contains("buy a house"))
    {
        return new List<string>
        {
            "1. Check your current credit score and savings.",
            "2. Research average house prices in your area.",
            "3. Find out how much you can borrow (mortgage calculator).",
            "4. Cut unnecessary expenses to increase savings.",
            "5. Build or stabilize income (freelance or side work).",
            "6. Contact a mortgage advisor."
        };
    }
    else if (goal.ToLower().Contains("make more money"))
    {
        return new List<string>
        {
            "1. List your current skills and experience.",
            "2. Research high-demand, remote-friendly jobs or freelance gigs.",
            "3. Learn one high-impact skill (e.g., copywriting, data analysis).",
            "4. Build a quick portfolio (even with mock projects).",
            "5. Apply to 5–10 gigs per week.",
            "6. Track earnings and reinvest in skill growth."
        };
    }
    else
    {
        return new List<string> { "I'm still learning how to help with that. Try rephrasing your goal." };
    }
}

}