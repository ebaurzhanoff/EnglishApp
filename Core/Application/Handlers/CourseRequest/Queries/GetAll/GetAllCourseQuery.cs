using Application.Services;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Handlers.CourseRequest.Queries.GetAll;

public record class GetAllCourseQuery : IRequest<List<CourseDto>> { }

public class GetAllCourseQueryHandler : IRequestHandler<GetAllCourseQuery, List<CourseDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetAllCourseQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<CourseDto>> Handle(GetAllCourseQuery request, CancellationToken cancellationToken)
    {
        return await _context.Courses
            .Include(x => x.Groups)
            .OrderBy(x => x.SortOrder)
            .ProjectTo<CourseDto>(_mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);
    }
}
