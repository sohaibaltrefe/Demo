namespace Demo.PL.ViewModels
{
    public class ProductVm
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public bool IsDeleted { get; set; }

    }
}
