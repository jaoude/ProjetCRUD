﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiGrain.BLL.Helpers
{
    public interface IAutoMapperService
    {
        IMapper Mapper { get; }
    }
}
