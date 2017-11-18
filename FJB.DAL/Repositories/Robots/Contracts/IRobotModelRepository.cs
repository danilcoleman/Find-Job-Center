﻿using FJB.Domain.Entities.Robots;

namespace FJB.DAL.Repositories.Robots.Contracts
{
    public interface IRobotModelRepository : IRjbRepository<RobotModel>, IItemRepository<RobotModel>
    {
    }
}
