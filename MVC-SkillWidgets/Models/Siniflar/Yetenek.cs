using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_SkillWidgets.Models.Siniflar
{
    public class Yetenek
    {
        [Key]
        public int ID { get; set; }
        public string YetenekAd { get; set; }
        public byte Deger { get; set; }
    }
}