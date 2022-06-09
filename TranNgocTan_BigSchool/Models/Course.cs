namespace TranNgocTan_BigSchool.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Course")]
    public partial class Course
    {
        public int Id { get; set; }

        [StringLength(128)]
        public string LecturerId { get; set; }

        [StringLength(255)]
        public string Place { get; set; }

        public DateTime? DateTime { get; set; }

        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public List<Category> ListCategory = new List<Category>();

        public List<Category> ListAll()
        {
            BigSchoolContext context = new BigSchoolContext();
            return context.Categories.ToList();
        }
        public string Name;
        public string LectureName;

        public bool IsLogin = false;
        public bool IsShowGoing = false;
        public bool IsShowFollow = false;
    }
}
