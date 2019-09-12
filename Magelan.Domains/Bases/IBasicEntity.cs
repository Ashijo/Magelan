using System;
using System.ComponentModel.DataAnnotations;

namespace Magelan.Domains {
    public interface IBasicEntity {
        DateTime Creation { get; set; }
    }
}