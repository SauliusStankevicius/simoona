﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Shrooms.WebViewModels.ValidationAttributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class MinValueAttribute : ValidationAttribute
    {
        private readonly int _minValue;

        public MinValueAttribute(int minValue)
        {
            _minValue = minValue;
        }

        public override bool IsValid(object value)
        {
            if (_minValue <= (int)value)
            {
                return true;
            }

            return false;
        }

        public override string FormatErrorMessage(string name)
        {
            return "Incorrect value";
        }
    }
}