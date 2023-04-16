using Domain.LessonBoundaryModel;

namespace Infrastructure.Data.UnitTasks;

public static class PresentSimpleUnitTaskSources
{
    #region ToBe_1
    public static readonly UnitTaskSource Grammar_Task_1_1 = new()
    {
        Id = Guid.NewGuid(),
        Type = TaskSourceType.MissedWord,
        UnitTaskId = GrammarUnitTasks.ToBe_1.Id,
        Key = "*",
        Content = "I * at school.",
        Value = "am",
        SortOrder = 1,
    };
    public static readonly UnitTaskSource Grammar_Task_1_2 = new()
    {
        Id = Guid.NewGuid(),
        Type = TaskSourceType.MissedWord,
        UnitTaskId = GrammarUnitTasks.ToBe_1.Id,
        Key = "*",
        Content = "You * beautiful.",
        Value = "are",
        SortOrder = 2,
    };
    public static readonly UnitTaskSource Grammar_Task_1_3 = new()
    {
        Id = Guid.NewGuid(),
        Type = TaskSourceType.MissedWord,
        UnitTaskId = GrammarUnitTasks.ToBe_1.Id,
        Key = "*",
        Content = "We * in the office.",
        Value = "are",
        SortOrder = 3,
    };
    public static readonly UnitTaskSource Grammar_Task_1_4 = new()
    {
        Id = Guid.NewGuid(),
        Type = TaskSourceType.MissedWord,
        UnitTaskId = GrammarUnitTasks.ToBe_1.Id,
        Key = "*",
        Content = "They * at work.",
        Value = "are",
        SortOrder = 4,
    };
    public static readonly UnitTaskSource Grammar_Task_1_5 = new()
    {
        Id = Guid.NewGuid(),
        Type = TaskSourceType.MissedWord,
        UnitTaskId = GrammarUnitTasks.ToBe_1.Id,
        Key = "*",
        Content = "He * early.",
        Value = "is",
        SortOrder = 5,
    };
    public static readonly UnitTaskSource Grammar_Task_1_6 = new()
    {
        Id = Guid.NewGuid(),
        Type = TaskSourceType.MissedWord,
        UnitTaskId = GrammarUnitTasks.ToBe_1.Id,
        Key = "*",
        Content = "She * late for work.",
        Value = "is",
        SortOrder = 6,
    };
    public static readonly UnitTaskSource Grammar_Task_1_7 = new()
    {
        Id = Guid.NewGuid(),
        Type = TaskSourceType.MissedWord,
        UnitTaskId = GrammarUnitTasks.ToBe_1.Id,
        Key = "*",
        Content = "You * Kazakh.",
        Value = "are",
        SortOrder = 7,
    };
    public static readonly UnitTaskSource Grammar_Task_1_8 = new()
    {
        Id = Guid.NewGuid(),
        Type = TaskSourceType.MissedWord,
        UnitTaskId = GrammarUnitTasks.ToBe_1.Id,
        Key = "*",
        Content = "We * in Kazakhstan ",
        Value = "are",
        SortOrder = 8,
    };
    public static readonly UnitTaskSource Grammar_Task_1_9 = new()
    {
        Id = Guid.NewGuid(),
        Type = TaskSourceType.MissedWord,
        UnitTaskId = GrammarUnitTasks.ToBe_1.Id,
        Key = "*",
        Content = "My name * Yernur.",
        Value = "is",
        SortOrder = 9,
    };
    public static readonly UnitTaskSource Grammar_Task_1_10 = new()
    {
        Id = Guid.NewGuid(),
        Type = TaskSourceType.MissedWord,
        UnitTaskId = GrammarUnitTasks.ToBe_1.Id,
        Key = "*",
        Content = "It * my school. ",
        Value = "is",
        SortOrder = 10,
    };
    #endregion

    #region ToBe_2
    public static readonly UnitTaskSource Grammar_Task_2_1 = new()
    {
        Id = Guid.NewGuid(),
        Type = TaskSourceType.NegativeForm,
        UnitTaskId = GrammarUnitTasks.ToBe_2.Id,
        Content = "I am British",
        Value = "I am not British",
        SortOrder = 1,
    };
    public static readonly UnitTaskSource Grammar_Task_2_2 = new()
    {
        Id = Guid.NewGuid(),
        Type = TaskSourceType.NegativeForm,
        UnitTaskId = GrammarUnitTasks.ToBe_2.Id,
        Content = "You are Russian",
        Value = "You are not Russian",
        SortOrder = 2,
    };
    public static readonly UnitTaskSource Grammar_Task_2_3 = new()
    {
        Id = Guid.NewGuid(),
        Type = TaskSourceType.NegativeForm,
        UnitTaskId = GrammarUnitTasks.ToBe_2.Id,
        Content = "They are in the office",
        Value = "They are not in the office",
        SortOrder = 3,
    };
    public static readonly UnitTaskSource Grammar_Task_2_4 = new()
    {
        Id = Guid.NewGuid(),
        Type = TaskSourceType.NegativeForm,
        UnitTaskId = GrammarUnitTasks.ToBe_2.Id,
        Content = "He is from Turkey",
        Value = "He is not from Turkey",
        SortOrder = 4,
    };
    public static readonly UnitTaskSource Grammar_Task_2_5 = new()
    {
        Id = Guid.NewGuid(),
        Type = TaskSourceType.NegativeForm,
        UnitTaskId = GrammarUnitTasks.ToBe_2.Id,
        Content = "We are from Egypt",
        Value = "We are not from Egypt",
        SortOrder = 5,
    };
    public static readonly UnitTaskSource Grammar_Task_2_6 = new()
    {
        Id = Guid.NewGuid(),
        Type = TaskSourceType.NegativeForm,
        UnitTaskId = GrammarUnitTasks.ToBe_2.Id,
        Content = "She is in America",
        Value = "She is not in America",
        SortOrder = 6,
    };
    public static readonly UnitTaskSource Grammar_Task_2_7 = new()
    {
        Id = Guid.NewGuid(),
        Type = TaskSourceType.NegativeForm,
        UnitTaskId = GrammarUnitTasks.ToBe_2.Id,
        Content = "It is from China",
        Value = "It is not from China",
        SortOrder = 7,
    };
    public static readonly UnitTaskSource Grammar_Task_2_8 = new()
    {
        Id = Guid.NewGuid(),
        Type = TaskSourceType.NegativeForm,
        UnitTaskId = GrammarUnitTasks.ToBe_2.Id,
        Content = "You are French",
        Value = "You are not French",
        SortOrder = 8,
    };
    public static readonly UnitTaskSource Grammar_Task_2_9 = new()
    {
        Id = Guid.NewGuid(),
        Type = TaskSourceType.NegativeForm,
        UnitTaskId = GrammarUnitTasks.ToBe_2.Id,
        Content = "They are Brazilian",
        Value = "They are not Brazilian",
        SortOrder = 9,
    };
    public static readonly UnitTaskSource Grammar_Task_2_10 = new()
    {
        Id = Guid.NewGuid(),
        Type = TaskSourceType.NegativeForm,
        UnitTaskId = GrammarUnitTasks.ToBe_2.Id,
        Content = "He is Kazakh",
        Value = "He is not Kazakh",
        SortOrder = 10,
    };
    #endregion
}
