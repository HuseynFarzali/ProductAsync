using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Xml.Schema;
using WebApplicationExample.Database;

namespace WebApplicationExample.Attributes.Validation_Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class ValidEntityIdAttribute : ValidationAttribute
    {
        private readonly Type _entityType;

        public ValidEntityIdAttribute(Type entityType)
        {
            _entityType = entityType;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var idPropertyName = $"{_entityType.Name}Id";

            var idProperty = _entityType.GetProperty(idPropertyName)
                ?? throw new InvalidOperationException(
                    $"Type {_entityType.Name} does not have an '{idPropertyName}'.");

            var entityId = (int)value;
            var dbContext = (AppDbContext)validationContext.GetService(typeof(AppDbContext));

            if (validationContext.ObjectType.Name is "Products")
            {
                var entity = dbContext.Products.Find(entityId);

                if (entity == null)
                {
                    return new ValidationResult($"The specified {validationContext.DisplayName} does not exist.");
                }
            }
            else if (validationContext.ObjectType.Name is "Colors")
            {
                var entity = dbContext.Colors.Find(entityId);

                if (entity == null)
                {
                    return new ValidationResult($"The specified {validationContext.DisplayName} does not exist.");
                }
            }
            else if (validationContext.ObjectType.Name is "Sizes")
            {
                var entity = dbContext.Sizes.Find(entityId);

                if (entity == null)
                {
                    return new ValidationResult($"The specified {validationContext.DisplayName} does not exist.");
                }
            }
            else if (validationContext.ObjectType.Name is "Categories")
            {
                var entity = dbContext.Categories.Find(entityId);

                if (entity == null)
                {
                    return new ValidationResult($"The specified {validationContext.DisplayName} does not exist.");
                }
            }

            return ValidationResult.Success;
        }
    }
}
