﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace didongexpress.bus.Bus
{
    public interface IOrderBusiness : IBusiness
    {

    }

    public class OrderBusiness : Business, IOrderBusiness
    {
    }
}
