using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Books.Entities
{
    public enum Gendre
    {
        [Display (Name = "Non Fiction")]
        NonFiction,
        Science,
        Beletristic
    }
}
