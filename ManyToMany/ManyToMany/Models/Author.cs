using ManyToMany.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToMany.Models
{
    public class Author : BaseEntity
    {
        public string Name { get; set; } = null!;
        public List<Book> Books { get; set; }
    }
}
