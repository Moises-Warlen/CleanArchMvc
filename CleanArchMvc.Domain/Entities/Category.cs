
using CleanArchMvc.Domain.Validation;
using System.Collections.Generic;

namespace CleanArchMvc.Domain.Entities
{
<<<<<<< HEAD
  public sealed  class Category
    {
        public int Id { get; private set; }
=======
  public sealed  class Category : Entity
    {
       
>>>>>>> 3105790 (finalizando as validacao das classe e criando as interfaces)
        public string Name { get; private set; }

        public Category(string name)
        {
            ValidateDomain(name);
        }

        public Category(int id, string name)
        {
            DomainExceptionValidation.When(id < 0, "Invalid ID value");
            Id = id;
            ValidateDomain(name);

        }

        public void Update(string name)
        {
            ValidateDomain(name);
        }

        // propriedade de navegação
        // uma categoria vai ter muitos produtos
        public ICollection<Product>Products { get; set; }
        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),
                "Invaled name. name is requerid");
            DomainExceptionValidation.When(name.Length < 3,
               "Invaled name,too short minimo 3 caracter");
            Name = name;
        }
    }
}
