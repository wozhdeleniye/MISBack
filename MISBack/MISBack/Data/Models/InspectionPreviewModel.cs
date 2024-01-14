﻿using System.ComponentModel.DataAnnotations;
using MISBack.Data.Enums;

namespace MISBack.Data.Models
{
    public class InspectionPreviewModel
    {
        [Required]
        public Guid id { get; set; }
        [Required]
        public DateTime createTime { get; set; }
        public Guid? previousId { get; set; }
        [Required]
        public DateTime date {  get; set; }
        [Required]
        public Conclusion conclusion { get; set; }
        [Required]
        public Guid doctorID { get; set; }
        [Required]
        [MinLength(1)]
        public string doctor {  get; set; }
        [Required]
        public Guid patientId { get; set; }
        [Required]
        [MinLength(1)]
        public string patient { get; set; }
        [Required]
        public DiagnosisModel diagnosis { get; set; }
        public bool? hasChain { get; set; }
        public bool? hasNested {  get; set; }
    }
}
