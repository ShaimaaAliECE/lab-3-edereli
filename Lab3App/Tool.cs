﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    abstract class Tool : Collectable
    {
        public Tool(string description) : base(description) { }
        public void DoAction()
        {
            Console.WriteLine(Description + " is Used");
        }
        public override void AddMe(List<Collectable> collectables)
        {
            base.AddMe(collectables);
        }
    }
}
