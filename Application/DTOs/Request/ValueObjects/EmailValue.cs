using System.Text.RegularExpressions;

namespace Application.DTOs.Request.ValueObjects;

public class EmailValue
{
    public string EmailAddress { get; init; }

    public EmailValue(string emailAddress)
    {
        ValidateEmail(emailAddress);

        EmailAddress = emailAddress;
    }

    public void ValidateEmail(string emailAddress)
    {
        if (string.IsNullOrEmpty(emailAddress)) { throw new ArgumentNullException("email cant be null or empty"); }

        string emailRegexPattern = @"^[a-zA-Z0-9._%+-]+@.+";

        if (!Regex.IsMatch(emailAddress, emailRegexPattern))
        {
            throw new ArgumentException("emailAddress must have the format 'fulano@domain'", nameof(emailAddress));
        }
    }
}
