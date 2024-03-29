using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BaKaVO.Classes
{
    [Table("Patient")]
    class Patient //пациент
    {
        [Key]
        public int ID_Patient { get; set; } //id
        public string Fullname_Patient { get; set; } //полное имя
        public DateTime BirthDate_Patient { get; set; } //день рождения
        public string Domicile_Patient { get; set; } //место проживания
        public string PhoneNumber_Patient { get; set; } //номер телефона
        public byte Bite_Patient { get; set; } //прикус
        public string Comment_Patient { get; set; } //коммент
        public int ID_Anamnesis_Pat { get; set; }

        public Patient() { }

        public Patient(
            string Fullname_Patient,
            DateTime BirthDate_Patient,
            string Domicile_Patient, 
            string PhoneNumber_Patient,
            byte Bite_Patient,
            string Comment_Patient,
            int ID_Anamnesis_Pat)
        {
            this.Fullname_Patient = Fullname_Patient;
            this.BirthDate_Patient = BirthDate_Patient;
            this.Domicile_Patient = Domicile_Patient;
            this.PhoneNumber_Patient = PhoneNumber_Patient;
            this.Bite_Patient = Bite_Patient;
            this.Comment_Patient = Comment_Patient;
            this.ID_Anamnesis_Pat = ID_Anamnesis_Pat;
        }
    }
}
