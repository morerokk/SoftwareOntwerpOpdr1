﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpOpdracht1.Orders
{
    class PendingOrder : OrderState
    {
        public override string State { get { return "Pending"; } }

        public virtual OrderState Submit() { throw new InvalidOperationException(); }

        public virtual OrderState Cancel() { throw new InvalidOperationException(); }
    }
}
