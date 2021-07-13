namespace BigSchool2.Models
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

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string LectureId { get; set; }

        [Required]
        [StringLength(255)]
        public string Place { get; set; }

        public DateTime DateTime { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }

 
        public virtual ICollection<Attendance> Attendances { get; set; }

        public virtual Category Category { get; set; }
        public List<Category> ListCategory = new List<Category>();

        [Required]
        public string LectureName;
        public string Name;

    }
}
