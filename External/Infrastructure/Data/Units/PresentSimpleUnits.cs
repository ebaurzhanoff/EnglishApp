using Domain.LessonBoundaryModel;
using Infrastructure.Data.Lessons;

namespace Infrastructure.Data.Units;

public static class PresentSimpleUnits
{
    public static readonly Unit ToBe = new()
    {
        Id = 1,
        Title = "Present simple “to be”",
        SortOrder = 1,
        LessonId = PresentSimpleLessons.Lesson_1.Id,
    };
    public static readonly Unit DoDoes = new()
    {
        Id = 2,
        Title = "Present simple “do/does”",
        SortOrder = 2,
        LessonId = PresentSimpleLessons.Lesson_1.Id,
    };
}
