
using System.ComponentModel.DataAnnotations;

namespace e_commerce.BaseTypes
{
    public abstract class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}
