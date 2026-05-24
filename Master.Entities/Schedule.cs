using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master.Entities
{
    /// <summary>
    /// 作息时间表
    /// 英 / ˈʃedjuːl美 / ˈskedʒuːl
    /// </summary>
    public class Schedule:BaseEntity
    {
        /// <summary>
        /// 作息节次
        /// </summary>
        public string Session { get; set; } = string.Empty;
        /// <summary>
        /// 作息时间段
        /// </summary>
        public string TimeSegment { get; set; } = string.Empty;
        /// <summary>
        /// 起始时间
        /// </summary>
        public DateTime BeginTime { get; set; }
        /// <summary>
        /// 结束时间 beginTime + 45分钟
        /// </summary>
        public DateTime EndTime { get; set; }
        public Schedule()
        {
            EndTime= BeginTime.AddMinutes(45);
        }
        public List<Curricula> Curriculas { get; set; } = new List<Curricula>();

    }
}
