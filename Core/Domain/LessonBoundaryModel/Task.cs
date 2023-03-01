using Domain.Common;

namespace Domain.LessonBoundaryModel;

public class UnitTask : Entity
{
    public string Title { get; set; } = null!;
    public string? Text { get; set; }
    public string? ImageUrl { get; set; }
}
