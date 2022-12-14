using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Notification
    {
        [Key]
        public int NotificationID { get; set; }
        public string? NatificationType { get; set; }
        public string? NatificationTypeSymbol { get; set; }
        public string? NatificationDetails { get; set; }
        public DateTime? NatificationDate { get; set; }
        public bool NotificationStatus { get; set; }
        public string? NotificationColor { get; set; }

    }
}
