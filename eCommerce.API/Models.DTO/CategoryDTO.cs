namespace eCommerce.API.Models.DTO
{
    public class CategoryDTO
    {
        public int ID {get; set;}
        public string Name {get; set;}
        public string ParentCategory {get; set;}
        public int parentCategory_ID { get; set; }
    }
}