using Domain.LessonBoundaryModel;
using Infrastructure.Data.Groups;

namespace Infrastructure.Data.Lessons;

public static class PresentSimpleLessons
{
    public static readonly Lesson Lesson_1 = new()
    {
        Id = 1,
        Title = nameof(Lesson),
        GroupToken = $"{Courses.Grammar.Name}_{nameof(GrammarGroups.PresentSimple)}",
        LevelId = Levels.A1.Id,
        SortOrder = 1,
        Description = $"Present Simple {nameof(Lesson)} - {Levels.A1.Code}"
    };
}
