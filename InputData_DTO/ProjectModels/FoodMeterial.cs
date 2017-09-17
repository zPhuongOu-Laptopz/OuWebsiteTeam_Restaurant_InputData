namespace InputData_DTO.ProjectModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FoodMeterial
    {
        [Key]
        [Column(Order = 0)]
        public Guid ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid IDFood { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid IDMeterials { get; set; }

        public bool IsStatus { get; set; }

        public virtual Food Food { get; set; }

        public virtual Meterial Meterial { get; set; }
    }
}
