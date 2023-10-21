using CleanArchMvc.Domain.Validations;

namespace CleanArchMvc.Domain.Entities;

public sealed class Category : Entity
{
   
    //propriedades do domínio
    public string Name { get; private set; }

    //propriedade de navegação
    public ICollection<Product> Products { get; set; }

    //construtores parametrizados
    public Category(string name)
    {
        ValidateDomain(name);
    }

    public Category(int id, string name)
    {
        DomainExceptionValidation.When(id < 0, "Invalid Id Value");
        Id = id;
        ValidateDomain(name);
    }

    //métodos
    public void Update(string name)
    {
        ValidateDomain(name);
    }

    //validações
    private void ValidateDomain(string name)
    {
        DomainExceptionValidation.
            When(string.IsNullOrEmpty(name),
            "Invalid Name: Name is Required");

        DomainExceptionValidation.
            When(name.Length < 3,
            "Invalid name: Name is too short, min 3 characters");

        Name = name;
    }
}
