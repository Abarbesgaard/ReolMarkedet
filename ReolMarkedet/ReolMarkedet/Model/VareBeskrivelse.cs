﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet.Model
{
    public record VareBeskrivelse(string Name, EVareType VareType, decimal Pris);
}
