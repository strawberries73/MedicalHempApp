using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedicalHempApp.Models.CannabisSalesModels
{
    public class VapesAndAccessoriesBaseViewModel
    {
        [Key]
        public int VapeId { get; set; }
        public int TypeId { get; set; }
        public int PaperId { get; set; }
        public int GrinderId { get; set; }

        // Displays for Name of product and URL image
        [Display(Name = "Type Name of product")]
        public string TypeName { get; set; }

        [Display(Name = "Image of product")]
        public string UrlImage { get; set; }
    }
}