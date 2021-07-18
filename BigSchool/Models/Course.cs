namespace BigSchool.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {
      
        public Course()
        {
            Attendances = new HashSet<Attendance>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string LectureId { get; set; }

        [Required]
        [StringLength(255)]
        public string Place { get; set; }

        public DateTime DateTime { get; set; }

        public int CategoryId { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

       
        public virtual ICollection<Attendance> Attendances { get; set; }

        public virtual Category Category { get; set; }
        public List<Category> ListCategory = new List<Category>();

        [Required]
    
        public string LectureName;
        public bool isLogin = false;
        public bool isShowGoing = false;
        public bool isShowFollow = false;
    }
}
