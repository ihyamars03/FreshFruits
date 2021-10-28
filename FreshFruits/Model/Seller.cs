using FreshFruits.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreshFruits.Model
{
    class Seller
    {
        private string name;
        private BucketController bucket;
        public Seller(string name, BucketController bucket)
        {
            this.name = name;
            this.bucket = bucket;
        }
        public List<Fruits> findAll()
        {
            return this.bucket.findAll();
        }
        public void addFruit(Fruits fruit)
        {
            this.bucket.addFruit(fruit);
        }
    }
}
