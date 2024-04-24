using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepotringToolMVC.Models
{
    public class IMemberInfo
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string PartyName { get; set; }
        public string Donors {  get; set; }
        public double TotalAmount { get; set; }
    }
}
