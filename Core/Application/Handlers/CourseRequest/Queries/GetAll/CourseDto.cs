using Application.Mappings;
using AutoMapper;
using Domain.CourseBoundaryModel;

namespace Application.Handlers.CourseRequest.Queries.GetAll;

public class CourseDto : IMapFrom<Course>
{
    public int SortOrder { get; set; }
    public string Name { get; set; } = null!;
    public List<GroupDto> Groups { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Course, CourseDto>();
    }
}

public class GroupDto : IMapFrom<Group>
{
    public int SortOrder { get; set; }
    public string Name { get; set; } = null!;
    public string Token { get; set; } = null!;

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Group, GroupDto>();
    }
}