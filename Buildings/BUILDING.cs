namespace Buildings
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BUILDING")]
    public partial class BUILDING
    {
        public int BuildingId { get; set; }

        [StringLength(255)]
        public string BuildingName { get; set; }

        [StringLength(255)]
        public string BuildingAddress { get; set; }

        public int? CityId { get; set; }
    }
}
