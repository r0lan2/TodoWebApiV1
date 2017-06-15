using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoWebApiV1.Models
{
    public class TodoDTO
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public bool Complete { get; set; }

    }
}