namespace InputData_DTO.ProjectModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Food
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Food()
        {
            FoodComboes = new HashSet<FoodCombo>();
            FoodHashtags = new HashSet<FoodHashtag>();
            FoodMeterials = new HashSet<FoodMeterial>();
        }

        public Guid ID { get; set; }

        [Required]
        [StringLength(100)]
        public string NameFood { get; set; }

        [Required]
        [StringLength(100)]
        public string Decriptions { get; set; }

        [Column(TypeName = "money")]
        public decimal? PriceBigSize { get; set; }

        [Column(TypeName = "money")]
        public decimal? PriceSmallSize { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ModifiedDate { get; set; }

        public Guid? Modifedby { get; set; }

        public bool? IsDiscountforBigZize { get; set; }

        public bool? IsDiscountfotSmallSize { get; set; }

        public bool IsBigSize { get; set; }

        public bool IsSmallSize { get; set; }

        public bool IsStatus { get; set; }

        public bool IsBestSale { get; set; }

        public bool IsAllowOrder { get; set; }

        public bool IsHot { get; set; }

        public int ViewCount { get; set; }

        public int BuyCount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FoodCombo> FoodComboes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FoodHashtag> FoodHashtags { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FoodMeterial> FoodMeterials { get; set; }
    }
}
