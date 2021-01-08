using API.Entities;
using GraphQL.Types;

namespace API.GraphTypes
{
    public sealed class UserType : ObjectGraphType<User>
    {
        public UserType()
        {
            Name = nameof(User);

            Field(user => user.Id)
                .Description("The user id.");

            Field(user => user.FirstName)
                .Description("The user's first name");

            Field(user => user.LastName)
                .Description("The user's last name");

            Field(user => user.Street)
                .Description("The user's street.");

            Field(user => user.HouseNumber)
                .Description("The user's house number.");

            Field(user => user.City)
                .Description("The user's city.");

            Field(user => user.PostalCode)
                .Description("The user's postal code.");

            Field(user => user.DateOfBirth)
                .Description("The user's date of birth.");

            Field(user => user.Email)
                .Description("The user's email.");

            Field(user => user.CreatedAt)
                .Description("The date the user was created.");
        }
    }
}