﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traquest.Views
{

    public class ControlRootMenuItem
    {
        public ControlRootMenuItem()
        {
            TargetType = typeof(HomePage);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}