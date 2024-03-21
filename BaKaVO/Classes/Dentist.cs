using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BaKaVO.Classes
{
    [Table("Dentist")]
    class Dentist //стоматолог
    {
        [Key]
        public int ID_Dentist { get; set; } //id
        public string Fullname_Dentist { get; set; } //полное имя
        public string PhoneNumber_Dentist { get; set; } //номер телефона

        public Dentist() { }

        public Dentist(
            string Fullname_Dentist, 
            string PhoneNumber_Dentist)
        {
            this.Fullname_Dentist = Fullname_Dentist;
            this.PhoneNumber_Dentist = PhoneNumber_Dentist;
        }
    }
}
