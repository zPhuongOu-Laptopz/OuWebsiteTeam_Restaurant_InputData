namespace InputData_DTO.ProjectModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FoodHashtag
    {
        [Key]
        [Column(Order = 0)]
        public Guid IDHashtag { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid IDFood { get; set; }

        public bool? IsStatus { get; set; }

        public virtual Food Food { get; set; }

        public virtual Hashtag Hashtag { get; set; }
    }
}
