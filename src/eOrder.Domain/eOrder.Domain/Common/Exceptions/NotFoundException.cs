﻿namespace eOrder.Domain.Common.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string? message) : base(message)
        {

        }
    }
}
