using System;

namespace Margo.Interface.Handlers
{
    public interface IExceptionHandler
    {
        T Run<T>(Func<T> func);
    }
}
