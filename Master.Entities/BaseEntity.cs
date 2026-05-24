using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Master.Entities
{
    /// <summary>
    /// 基础实体，包含自增主键、创建时间、更新时间和软删除标志。
    /// </summary>
    /// <remarks>通常作为实体模型的基类；Id 为数据库自增主键，CreatedAt 与 UpdatedAt 默认为当前时间，IsDeleted 用于软删除。</remarks>
    public class BaseEntity
    {
        /// <summary>
        /// 递增主键
        /// </summary>

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        ///<summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        ///<summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        ///<summary>
        ///是否删除
        ///</summary>
       public bool IsDeleted { get; set; } = false;
    }
}
