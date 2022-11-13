﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Common
{
    public class Result<T>
    {
        public T? Data { get; set; }
        public bool Succeeded { get; set; }
        public string? Message { get; set; }
        public string? Errors { get; set; }
    }
}
