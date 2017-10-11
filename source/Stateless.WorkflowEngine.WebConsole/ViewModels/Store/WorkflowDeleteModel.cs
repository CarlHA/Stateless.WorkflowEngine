﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stateless.WorkflowEngine.WebConsole.ViewModels.Store
{
    public class WorkflowDeleteModel
    {
        public WorkflowDeleteModel()
            : base()
        {
            this.WorkflowIds = new Guid[] { };
        }

        public Guid ConnectionId { get; set; }

        public Guid[] WorkflowIds { get; private set; }

    }
}
