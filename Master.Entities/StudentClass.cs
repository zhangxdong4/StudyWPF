using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.Entities
{
    /// <summary>
    /// 学生班级表
    /// </summary>
    public class StudentClass:BaseEntity
    {
        /// <summary>
        /// 班级名称
        /// </summary>
        public string? ClassName { get; set; }
        /// <summary>
        /// 入学时间
        /// </summary>
        public string? Enrollment { get; set; }=DateTime.Now.ToString("yyyy年");
        /// <summary>
        /// 班主任
        /// </summary>
        public string? HeadTeacher { get; set; } = string.Empty;
    }
}
