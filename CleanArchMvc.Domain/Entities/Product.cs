
using CleanArchMvc.Domain.Validation;

namespace CleanArchMvc.Domain.Entities
{
<<<<<<< HEAD
   public   sealed class Product
    {
        public int Id { get; private set; }
=======
   public   sealed class Product : Entity
    {
          
>>>>>>> 3105790 (finalizando as validacao das classe e criando as interfaces)
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public string Image { get; private set; }

        public Product(string name, string description, decimal price, int stock, string image)
        {
            ValidateDomain(name, description, price, stock, image);     
        }

        public Product(int id ,string name, string description, decimal price, int stock, string image)
        {
            DomainExceptionValidation.When(id < 0, "Invalid ID value");
            Id = id;
            ValidateDomain (name, description, price, stock, image);
        }

        public void Update(string name, string description, decimal price, int stock, string image,int categoryId)
        {
            ValidateDomain(name, description, price, stock, image);
            CategoryId = categoryId;
        }
        public void ValidateDomain(string name, string description, decimal price, int stock, string image)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),
               "Invalid name. name is requerid");

            DomainExceptionValidation.When(name.Length < 3,
               "Invalid name,too short minimo 3 caracter");

            DomainExceptionValidation.When(string.IsNullOrEmpty(description),
               "Invalid decription. decription is requerid");

            DomainExceptionValidation.When(price < 0,
               "Invalid price value");

            DomainExceptionValidation.When(stock < 0,
               "Invalid stock value");

            DomainExceptionValidation.When(image.Length > 250,
               "Invalid imagetoo long, maximo 250 caracter");
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;
        }
        public int CategoryId { get; set; }
        public Category category { get; set; }
    }
}
