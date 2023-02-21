namespace Domain.GrammarBoundary;

public class Grammar
{
    public long Id { get; set; }
    public string Name { get; set; }

    public List<Group> Groups { get; set; }
}
