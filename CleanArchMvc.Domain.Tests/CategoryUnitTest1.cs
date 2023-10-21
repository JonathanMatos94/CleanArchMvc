namespace CleanArchMvc.Domain.Tests
{
    public class CategoryUnitTest1
    {
        [Fact(DisplayName = "Create Category With Valid State")]
        public void CreateCategory_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Category(1, "Category Name");
            action.Should().
                NotThrow<DomainExceptionValidation>();
        }
        [Fact(DisplayName = "Create Category With Negative Id Value")]
        public void CreateCategory_WithNegativeIdValue_DomainExceptionInvalidId()
        {
            Action action = () => new Category(-1, "Category Name");
            action.Should()
                .Throw<DomainExceptionValidation>()
                .WithMessage("Invalid Id Value");
        }
        [Fact(DisplayName ="Create Category With Short Name")]
        public void CreateCategory_ShortNameValue_DomainExceptionShortName()
        {
            Action action = () => new Category(1, "Ca");
            action.Should()
                .Throw<DomainExceptionValidation>()
                .WithMessage("Invalid name: Name is too short, min 3 characters");
        }
        [Fact(DisplayName ="Create Category Missing Name Value")]
        public void CreateCategory_MissingNameValue_DomainExceptionRequiredName()
        {
            Action action = () => new Category(1, "");
            action.Should()
                .Throw<DomainExceptionValidation>()
                .WithMessage("Invalid Name: Name is Required");
        }
        [Fact(DisplayName ="Create Category Null Name Value")]
        public void CreateCategory_NullNameValue_DomainExceptionRequiredName()
        {
            Action action = () => new Category(1, null);
            action.Should()
                .Throw<DomainExceptionValidation>()
                .WithMessage("Invalid Name: Name is Required");
        }
    }
}