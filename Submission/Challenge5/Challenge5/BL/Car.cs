using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5
{
    internal class Car
    {
        
        protected string Color;
        protected string Model;
        protected float Price;
        public Car(string color, string model, float price)
        {
            this.Color = color;
           this. Model = model;
           this. Price = price;
        }
        public void setColor(string color) { this.Color = color;}
        public void setModel(string model) {  this.Model = model;}
        public void setPrice(float price) {  this.Price = price;}
        public string getColor() { return this.Color;}
        public string getModel() { return this.Model;}
        public float getPrice() { return this.Price;}
    }
}
