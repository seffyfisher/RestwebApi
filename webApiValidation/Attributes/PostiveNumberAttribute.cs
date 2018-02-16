using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webApiValidation.Attributes
{
    public class PostiveNumberAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            int valueAsInt = (int)value;
            if (valueAsInt >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}