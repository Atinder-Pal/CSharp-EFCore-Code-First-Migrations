﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CodeFirstPractice.Models
{
    [Table("Shelf")]
    class Shelf
    {
        [Key]
        [Column( TypeName ="int(10)" )]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [Column( TypeName ="varchar(50)" )]
        public string Name { get; set; }

        public Shelf()
        {
            Name = "Default_Shelf";
        }

        public Shelf( string shelfName )
        {
            Name = shelfName;
        }
    }
}
