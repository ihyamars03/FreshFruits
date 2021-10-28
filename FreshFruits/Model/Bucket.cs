using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FreshFruits.Model
{
    class Bucket
    {
        private int capacity;
        private List<Fruits> fruits;
        
        public Bucket(int capacity)
        {
            this.capacity = capacity;
            this.fruits = new List<Fruits>();
        }
        public void insert(Fruits fruit)
        {
            this.fruits.Add(fruit);
        }
        public void remove(int position)
        {
            this.fruits.RemoveAt(position);
        }
        public List<Fruits> findAll()
        {
            return this.fruits;
        }
        public int getCapacity()
        {
            return this.capacity;
        }
        public int countItems()
        {
            return this.fruits.Count();
        }

    }
}
