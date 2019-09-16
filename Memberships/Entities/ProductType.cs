using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Memberships.Entities
{
    [Table("ProductType")]
    public class ProductType
    {
        /// <summary>
        /// automatically incrimante the Id by adding the attribute "[DatabaseGenerated(DatabaseGeneratedOption.Identity)]"
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// an attribute to specify the max length of the property "[MaxLength(255)]"
        /// </summary>
        [MaxLength(25)]
        [Required]
        public string Title { get; set; }
    }
}