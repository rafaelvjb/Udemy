using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vega.Models
{
    [Table("Makes")]
    public class Make
    {
        public Make()
        {
            Models = new Collection<Model>();
        }
        [Required]
        [StringLength(255)]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Model> Models { get; set; }


    }
}