﻿using System;
using FJB.Domain.Entities.Users;

namespace FJB.Domain.Entities.Robots
{
    public class RobotModelFeedback
    {
        public int RobotFeedbackId { get; set; }

        public int RobotModelId { get; set; }

        public int ClientId { get; set; }

        public Rating Rate { get; set; }

        public string Comment { get; set; }

        public DateTime CreatedOn { get; set; }

        public virtual RobotModel RobotModel { get; set; }

        public virtual Client Client { get; set; }
    }
}