using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AccessData.Entities
{
    [Table("Move", Schema = "dbo")]
    public class Move
    {
        [Key]
        public int IdMove { get; set; }
        public string IdentificationCard { get; set; }
        public DateTime DateMove { get; set; }
    }
}
