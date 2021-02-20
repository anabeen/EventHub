using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace EventHub.EventViewModelDateValidation
{
    public class DateValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            // Validate that the date formate is right
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "d MMM yyyy",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out dateTime);

            // Validate it's a future date
            return (isValid && dateTime > DateTime.Now);
        }
    }

    public class TimeValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            // Validate that the date formate is right
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "HH:mm",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out dateTime);

            // Validate it's a future date
            return (isValid);
        }
    }

}