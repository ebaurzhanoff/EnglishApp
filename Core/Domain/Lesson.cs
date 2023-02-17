namespace Domain;

public class Lesson
{
    public long Id { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;

    public Content Content { get; set; } = null!;

    public Task Task { get; set; } = null!;
}

public class Task
{
    public long Id { get; set; }
    public string Title { get; set; } = null!;
    public string? Text { get; set; }
    public string? ImageUrl { get; set; }
}


public class Content
{
    public long Id { get; set; }
    public List<Unit> Units { get; set; } = null!;
}


public class Unit
{
    public long Id { get; set; }
    public int Order { get; set; }
    public string Source { get; set; } = null!;
}