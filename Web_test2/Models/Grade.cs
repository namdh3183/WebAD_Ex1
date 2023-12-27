using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_test2.Models
{
    public class Grade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public double Score { get; set; }

        [ForeignKey("Student")]
        public int StudentID { get; set; }

        public virtual Student Student { get; set; }
    }
}