using System;

namespace Portal.Application.Common
{
    public interface IOperationResult
    {

        string? ErrorMessage { get; }
        Exception? Exception { get; }
        bool Success { get; }

    }
}