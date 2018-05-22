﻿using LamShop.Model.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Abstract;

namespace LamShop.Model.Models
{
    [Table("Posts")]
    public class Post : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public virtual IEnumerable<PostTag> PostTags { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Alias { get; set; }
        [Required]

        public int CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCategory { get; set; }

        public string Image { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }

        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public int ViewCount { get; set; }



    }
}
