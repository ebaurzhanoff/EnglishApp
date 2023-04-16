using Domain.LessonBoundaryModel;

namespace Infrastructure.Data.Units;

public static class PresentSimpleUnitSources
{
    #region ToBe
    public static readonly Source Source_ToBe_1 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.ToBe.Id,
        Content = @"Как переводится to be и когда используется?

    'Be' мы используем в 3 случаях, когда мы хотим сказать:
        Кто/что кем/чем является (она медсестра);
        Кто/что каким является (мой кот серый);
        Кто/что где находится (папа на работе).

    То есть если мы хотим описать местоположение чего-либо, состояние чего-либо или то, чем является этот предмет/человек, то мы используем глагол to be.",
        SortOrder = 1
    };
    public static readonly Source Source_ToBe_2 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.ToBe.Id,
        Content = "Важно знать, как глагол to be меняется в зависимости от того, кто производит действие. Это можете быть вы, ваш друг или группа людей. В настоящем времени этот глагол имеет три формы: am, is, are. ",
        SortOrder = 2
    };
    public static readonly Source Source_ToBe_3 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.ToBe.Id,
        Content = "Давайте рассмотрим примеры употребления. ",
        SortOrder = 3
    };
    public static readonly Source Source_ToBe_4 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.ToBe.Id,
        Content = @" Единственное число
    I am a doctor. Я являюсь доктором.
    He is clever. Он является умным.
    She is at home. Она находится дома.
    It is an interesting book. Это есть интересная книга.
    You are a smart guy. Ты являешься сообразительным парнем.",
        SortOrder = 4
    };
    public static readonly Source Source_ToBe_5 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.ToBe.Id,
        Content = @" Множественное число 
    We are good singers. Мы являемся хорошими певцами. 
    You are wonderful listeners. Вы являетесь отличными слушателями. 
    They are in the room. Они находятся в комнате.",
        SortOrder = 5
    };
    public static readonly Source Source_ToBe_6 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.ToBe.Id,
        Content = "Так же посмотрите это видео!",
        SortOrder = 6,
        Type = SourceType.Text
    };
    public static readonly Source Source_ToBe_7 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.ToBe.Id,
        Content = "YlqRjy_Z3GQ",
        SortOrder = 7,
        Type = SourceType.YouTubeVideoUrl
    };
    #endregion

    #region DoDoes
    public static readonly Source Source_DoDoes_1 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.DoDoes.Id,
        Content = "Present simple - это простое настоящее время, оно употребляется когда говорим о действиях которые мы делаем регулярно, каждый или часто. Одним словом это действия который не заканчивается.",
        SortOrder = 1
    };
    public static readonly Source Source_DoDoes_2 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.DoDoes.Id,
        Content = @"I go to work/university every day 

Также оно употребляется, когда мы говорим про факты в настоящем.

I like pizza/sushi",
        SortOrder = 2
    };
    public static readonly Source Source_DoDoes_3 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.DoDoes.Id,
        Content = @"Конструкция предложений в present simple 

    Subject + Verb
    You like ice cream

    He / She / It + Verb(s)
    He likes ice cream",
        SortOrder = 3
    };
    public static readonly Source Source_DoDoes_4 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.DoDoes.Id,
        Content = @"В отрицательных предложениях

    do + not - don’t
    does + not - doesn’t

    Subject + don’t/doesn’t + Verb

    I don’t like ice cream 
    She doesn’t go to school",
        SortOrder = 4
    };
    public static readonly Source Source_DoDoes_5 = new()
    {
        Id = Guid.NewGuid(),
        UnitId = GrammarUnits.DoDoes.Id,
        Content = @"Чтобы сделать вопросительное предложение 

    Do/ Does + Subject + Verb 

    Do you go to university?
    Yes, I do 
    No, I don’t 

    Does he go swimming? 
    Yes, he does
    No, he doesn’t",
        SortOrder = 5
    };
    #endregion
}
