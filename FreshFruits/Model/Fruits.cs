using System;
using System.Collections.Generic;
using System.Text;

namespace FreshFruits.Model
{
    class Fruits
    {
        public string name { get; set; }

    public Fruits(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
    }
}
