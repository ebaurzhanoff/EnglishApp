using Domain.Common;

namespace Domain.LessonBoundaryModel;

public class Source : Entity, ISortable
{
    public int SortOrder { get; set; }
    public string Content { get; set; } = null!;
}
