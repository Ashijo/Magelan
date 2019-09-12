using System.ComponentModel.DataAnnotations;

namespace Magelan.Domains
{
    public interface IIntKey
    {
        [Key]
        int Id { get; set; }
    }
}