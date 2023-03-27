using Domain.LessonBoundaryModel;
using Infrastructure.Data.Groups;

namespace Infrastructure.Data.Lessons;

public static class GrammarLessons
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
    public static readonly Lesson Lesson_2 = new()
    {
        Id = 2,
        Title = nameof(Lesson),
        GroupToken = $"{Courses.Grammar.Name}_{nameof(GrammarGroups.PresentContinuous)}",
        LevelId = Levels.A1.Id,
        SortOrder = 2,
        Description = $"Present Continuous {nameof(Lesson)} - {Levels.A1.Code}"
    };
}
