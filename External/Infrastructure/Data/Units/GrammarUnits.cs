using Domain.LessonBoundaryModel;
using Infrastructure.Data.Lessons;

namespace Infrastructure.Data.Units;

public static class GrammarUnits
{
    public static readonly Unit ToBe = new()
    {
        Id = 1,
        Title = "Present simple “to be”",
        SortOrder = 1,
        LessonId = GrammarLessons.Lesson_1.Id,
    };
    public static readonly Unit DoDoes = new()
    {
        Id = 2,
        Title = "Present simple “do/does”",
        SortOrder = 2,
        LessonId = GrammarLessons.Lesson_1.Id,
    };
    public static readonly Unit PresentContinuousRules = new()
    {
        Id = 3,
        Title = "Present Continuous. Rules",
        SortOrder = 1,
        LessonId = GrammarLessons.Lesson_2.Id,
    };
    public static readonly Unit PresentContinuousHowToUse = new()
    {
        Id = 4,
        Title = "Present Continuous. How to Use It",
        SortOrder = 2,
        LessonId = GrammarLessons.Lesson_2.Id,
    };
}
