﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    interface IDepartment
    {
        void Insert(Department dept);
        Department GetDepartment(int id);
    }
}
