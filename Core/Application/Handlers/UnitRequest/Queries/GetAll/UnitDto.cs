using Application.Mappings;
using AutoMapper;
using Domain.LessonBoundaryModel;

namespace Application.Handlers.UnitRequest.Queries.GetAll;

public class UnitDto : IMapFrom<Unit>
{
    public long Id { get; set; }
    public string Title { get; set; } = null!;
    public int SortOrder { get; set; }
    public long LessonId { get; set; }
    public List<SourceDto> Sources { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Unit, UnitDto>();
    }
}

public class SourceDto : IMapFrom<Source>
{
    public int SortOrder { get; set; }
    public string Content { get; set; } = null!;

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Source, SourceDto>();
    }
}
