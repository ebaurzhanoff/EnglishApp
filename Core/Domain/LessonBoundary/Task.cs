namespace Domain.LessonBoundary;

public class Task
{
    public long Id { get; set; }
    public string Title { get; set; } = null!;
    public string? Text { get; set; }
    public string? ImageUrl { get; set; }
}
