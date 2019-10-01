using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Application.Common
{
    public class OperationResult : IOperationResult
    {
        //public OperationResult(bool success,string errorMessage,Exception ex)
        //{
        //    Success = success;
        //    ErrorMessage = errorMessage;
        //    Exception = ex;
        //}
        public bool Success { get; private set; }

        public string? ErrorMessage { get; private set; }
        public Exception? Exception { get; private set; }

        public void BuildSuccessResult()
        {
            Success = true;
        }

        public void BuildFailure(string errorMessage)
        {
            Success = false;
            ErrorMessage = errorMessage;
        }
        public void BuildFailure(Exception ex)
        {
            Success = false;
            Exception = ex;
        }

        public void BuildFailure(Exception ex, string errorMessage)
        {
            Success = false;
            Exception = ex;
            ErrorMessage = errorMessage;
        }

    }
}
