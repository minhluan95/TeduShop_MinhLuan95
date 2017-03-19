﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        public int ProductID { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }

        [Key]
        [Required]
        [MaxLength(50)]
        public int TagID { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }
    }
}