using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreSample.Models
{
    public class Book
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [StringLength(20)]
        public string Publisher { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}
