using ImprovedEnum.Core.Interfaces;
using System;

namespace ImprovedEnum.Core.Attributes
{
    public class EnumDescriptionAttribute : Attribute, IAttribute
    {
        public string Value { get; set; }

        public EnumDescriptionAttribute(string value)
        {
            Value = value;
        }
    }
}
