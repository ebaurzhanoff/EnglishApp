namespace Domain.LessonBoundary;

public class Lesson
{
    public long Id { get; set; }

    public string GroupToken { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;

    public Content Content { get; set; } = null!;

    public Task Task { get; set; } = null!;
}