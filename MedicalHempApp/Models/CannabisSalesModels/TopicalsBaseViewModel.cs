using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedicalHempApp.Models.CannabisSalesModels
{
    public class TopicalsBaseViewModel
    {
        [Key]
        // Lotion
        public int LotionId { get; set; }

        // Salve
        public int SalveId { get; set; }

        // Bath
        public int BathbombId { get; set; }

        // Displays for Name of product and URL image
        [Display(Name = "Type Name of product")]
        public string TypeName { get; set; }

        [Display(Name = "Image of product")]
        public string UrlImage { get; set; }
    }
}