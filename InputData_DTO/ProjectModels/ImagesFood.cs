namespace InputData_DTO.ProjectModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ImagesFood
    {
        public Guid ID { get; set; }

        public Guid IDFoods { get; set; }

        [Required]
        [StringLength(50)]
        public string ImageName { get; set; }

        [StringLength(100)]
        public string Link { get; set; }
    }
}
