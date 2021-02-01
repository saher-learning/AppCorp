using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCorp.Models
{
    public class PagedResponse<T>
    {
        public PagedResponse(int pageNumber, T data)
        {
            PageNumber = pageNumber;
            Data = data;
        }
        public int PageNumber { get; set; }
        public T Data { get; set; }
    }
}
