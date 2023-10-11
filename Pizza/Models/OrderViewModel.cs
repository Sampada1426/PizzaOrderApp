namespace PizzaOrderApp1.Models
{
    public class OrderViewModel
    {
        public int PizzaId { get; set; }
        public string PizzaName { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
