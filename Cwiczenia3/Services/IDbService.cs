﻿using Cwiczenia3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia3.Services
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents();
    }
}
