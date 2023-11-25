namespace AutoLot.Services.Validation;

[AttributeUsage(AttributeTargets.Property)]
public class MustBeGreaterThanZeroAttribute : ValidationAttribute
{
    public MustBeGreaterThanZeroAttribute() : this("{0} must be greater than 0")
    {

    }

    public MustBeGreaterThanZeroAttribute(string errorMessage) : base(errorMessage)
    {

    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (!int.TryParse(value.ToString(), out int result))
        {
            return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
        }

        return result > 0
            ? ValidationResult.Success
            : new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
    }
}
