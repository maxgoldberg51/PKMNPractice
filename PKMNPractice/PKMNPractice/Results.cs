﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKMNPractice
{
    class Results
    {
        public int count{ get; set; }
        public string next{ get; set; }

        public List<Result> results{ get; set; }
    }

    public class Result
    {
        public string name{ get; set; }
        public string url{ get; set; }

            public override string ToString()
        {
            return name;
        }
    }
}
