﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public interface ITenant
    {
        List<string> SelectDistinctTenant();
    }
}
