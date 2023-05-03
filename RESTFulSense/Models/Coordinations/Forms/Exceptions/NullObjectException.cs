﻿// ----------------------------------------------------------------------------------
// Copyright (c) The Standard Organization: A coalition of the Good-Hearted Engineers
// ----------------------------------------------------------------------------------

using Xeptions;

namespace RESTFulSense.Models.Coordinations.Forms.Exceptions
{
    internal class NullObjectException : Xeption
    {
        public NullObjectException()
            : base(message: "Object is null.")
        { }
    }
}
