namespace DataService
{
    public partial class OrderItem
    {
        public int Id { get; set; }

        public virtual string ProductName { get; set; } = null!;
        public virtual decimal UnitPrice { get; set; }
        public virtual int Quantity { get; set; }
        public virtual float Discount { get; set; }
        public virtual DateTime OrderDate { get; set; }
    }
}
