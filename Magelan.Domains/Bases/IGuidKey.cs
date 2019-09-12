using System;
using System.ComponentModel.DataAnnotations;

namespace Magelan.Domains
{
    public interface IGuidKey
    {
        [Key]
        Guid Id { get; set; }
    }
}