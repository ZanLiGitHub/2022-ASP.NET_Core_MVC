using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    // 数据库中的表名
    public class Category
    {
        // 数据库中的列名
        // [Key]表示主键
        [Key] public int Id { get; set; }
        // [Required]表示必要项
        [Required]public string? Name { get; set; }
        // [Range(X,Y]表示范围
        [Range(1,100)]public int DisplayOrder { get; set; }
        // 用 = 设置默认值
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
        

    }
}
