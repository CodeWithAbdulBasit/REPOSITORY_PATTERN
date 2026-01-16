using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model.Common
{
    public class ServiceResponse<T>
    {
        public bool Success { get; set; }
        public string message { get; set; }
        public T Data { get; set; }
    }
}
