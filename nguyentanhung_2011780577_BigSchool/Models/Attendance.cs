using nguyentanhung_2011780577_BigSchool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace nguyentanhung_2011780577_BigSchool.Models
{
    public class Attendance
    {
        public Course Cource { get; set; }

        [Key]
        [Column(Order = 1)]
        public int CourceId { get; set; }
        public ApplicationUser Attendee { get; set; }

        [Key]
        [Column(Order = 2)]
        public string AttendeeId { get; set; }
    }
}