namespace Demo.PL.ViewModels
{
    public class ProductDetailsVm
    {
        public int Id { get; set; }



        public string Name { get; set; } = null!;



        public string Code { get; set; } = null!;



        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }


    }
}
