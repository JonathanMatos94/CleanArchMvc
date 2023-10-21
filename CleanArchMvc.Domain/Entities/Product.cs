using CleanArchMvc.Domain.Validations;

namespace CleanArchMvc.Domain.Entities;

public sealed class Product : Entity
{
 
    //propriedades do domínio
    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }
    public int Stock { get; private set; }
    public string? Image { get; private set; }

    //propriedades de navegação para relacionar as duas entidades
    public int CategoryId { get; set; }
    public Category Category { get; set; }

    //construtores parametrizados
    public Product(string name, string description, decimal price, int stock, string image)
    {
        ValidateDomain(name, description, price, stock, image);
    }
    public Product(int id, string name, string description, decimal price, int stock, string image)
    {
        DomainExceptionValidation.When(id < 0, "Invalid Id Value");
        Id = id;
        ValidateDomain(name, description, price, stock, image);
    }

    //métodos
    public void Update(string name, string description, decimal price, int stock, string image, int categoryId)
    {
        ValidateDomain(name, description, price, stock, image);
        CategoryId = categoryId;
    }

    //validações
    private void ValidateDomain(string name, string description, decimal price, int stock, string image)
    {
        DomainExceptionValidation.
           When(string.IsNullOrEmpty(name),
           "Invalid Name: Name is Required");

        DomainExceptionValidation.
           When(name.Length < 3,
           "Invalid name: Name is too short, min 3 characters");

        DomainExceptionValidation.
          When(string.IsNullOrEmpty(description),
          "Invalid Description: Description is Required");

        DomainExceptionValidation.
          When(description.Length < 5,
          "Invalid Description: Description is too short, min 5 characters");

        DomainExceptionValidation.
            When(price < 0, "Invalid Price Value");

        DomainExceptionValidation.
            When(stock < 0, "Invalid stock Value");
        
        DomainExceptionValidation.
         When(image?.Length > 250,
         "Invalid image name: url image is too long, max 250 characters");

        Name = name;
        Description = description; 
        Price = price;
        Stock = stock;
        Image = image;

    }
}
