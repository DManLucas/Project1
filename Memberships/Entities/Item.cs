using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Memberships.Entities
{
    [Table("Item")]
    public class Item
    {
        /// <summary>
        /// automatically incrimante the Id by adding the attribute "[DatabaseGenerated(DatabaseGeneratedOption.Identity)]"
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// an attribute to specify the max length of the property "[MaxLength(255)]"
        /// </summary>
        [MaxLength(255)]
        [Required]
        public string Title { get; set; }
        [MaxLength(2048)]
        public string Description { get; set; }
        [MaxLength(1024)]
        public string Url { get; set; }
        [MaxLength(1024)]
        [DisplayName("Image Url")]
        public string ImageUrl { get; set; }
        [AllowHtml]
        public string HTML { get; set; }
        [DefaultValue(0)]
        [DisplayName("Wait Days")]
        public int WaitDays { get; set; }
        public string HTMLShort {
            get { return HTML == null || HTML.Length > 50 ? HTML : HTML.Substring(0, 50); }
        }
        public int ProductId { get; set; }
        public int ItemTypeId { get; set; }
        public int SectionId { get; set; }
        public int PartId { get; set; }
        public bool IsFree { get; set; }

        /// <summary>
        /// Atribute "[DisplayName]" alters the name to be shown instead of the property name "ItemTypes" it will show
        /// 
        /// </summary>
        [DisplayName("Item Type")]
        public ICollection<ItemType> ItemTypes { get; set; }
        [DisplayName("Sections")]
        public ICollection<Section> Sections { get; set; }
        [DisplayName("Parts")]
        public ICollection<Part> Parts { get; set; }
    }
}