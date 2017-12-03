using System;

namespace Linq.Model {
    public class Item {
        public Item (string name, string category, decimal price, DateTime createdAt, DateTime expirationDate) {
            this.Name = name;
            this.Category = category;
            this.Price = price;
            this.CreatedAt = createdAt;
            this.ExpirationDate = expirationDate;

        }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}