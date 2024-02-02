﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    abstract class Collectable : Displayable
    {
        public string Description { get; set; }
        public CollectionBoard board { get; set; }
        public Collectable (string description)
        {
            Description = description;
        }
        public virtual void AddMe(List<Collectable> collectables)
        {
            collectables.Add(this);
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
        }
        public abstract void Display();
    }
}
