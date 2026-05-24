using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.Entities
{
    /// <summary>
    /// 课程表
    /// 英 / kəˈrɪkjʊlə美 / kəˈrɪkjələ
    /// </summary>
    public class Curricula: BaseEntity
    {
        /// <summary>
        /// 时间表Id
        /// </summary>
        public int ScheduleId { get; set; }

        /// <summary>
        /// 时间表
        /// </summary>
        public Schedule? Scheduley { get; set; }
        /// <summary>
        /// 任课班级Id
        /// </summary>
        public int ScheduleyId { get; set; }
        /// <summary>
        /// 任课班级
        /// </summary>
        public StudentClass StudentClass { get; set; } =new();
        /// <summary>
        /// 星期几
        /// </summary>  
        public DayOfWeek Weekday { get; set; } 

    }
}
