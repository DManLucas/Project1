using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Memberships.Entities
{
    [Table("ProductItem")]
    public class ProductItem
    {
        /// <summary>
        /// Because there is 2 primary keys here we use the attribute "[Key, Column(Order = 1)]" and "[Key, Column(Order = 2)]"
        /// the first order is the first primary key that is fetched
        /// </summary>
        [Required]
        [Key, Column(Order = 1)]
        public int ProductId { get; set; }
        [Key, Column(Order = 2)]
        public int ItemId { get; set; }
        /// <summary>
        /// The NotMapped attribute is used to specify that an entity or 
        /// property is not to be mapped to a table or column in the database.
        /// </summary>
        [NotMapped]
        public int OldProductId { get; set; }
        [NotMapped]
        public int OldItemId { get; set; }
    }
}