using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistance;

namespace Application.Activities
{
    public class List
    {
        public class Query : IRequest<Result<List<ActivityDTO>>> { }

        public class Handler : IRequestHandler<Query, Result<List<ActivityDTO>>>
        {
            private DataContext context;
            ////private readonly ILogger<List> logger;
            private readonly IMapper mapper;
            public Handler(DataContext contextPrm, IMapper mapper) ////, ILogger<List> loggerPrm
            {
                this.mapper = mapper;
                ////this.logger = loggerPrm;
                context = contextPrm;
            }

            public async Task<Result<List<ActivityDTO>>> Handle(Query request, CancellationToken cancellationToken)
            {
                var activities = await context.Activities
                .ProjectTo<ActivityDTO>(mapper.ConfigurationProvider)
                .ToListAsync();
                return Result<List<ActivityDTO>>.Success(activities);
            }
        }
    }
}
