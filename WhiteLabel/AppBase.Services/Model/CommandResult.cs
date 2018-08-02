using System;
using System.Collections.Generic;
using System.Text;

namespace AppBase.Services.Model
{
    public class CommandResult<T> where T : IModelBase
    {
        public bool Success { get; set; }
        public IList<string> Erros { get; set; }
        public T Data { get; set; }
    }
}
