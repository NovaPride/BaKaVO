using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BaKaVO.Classes
{
    [Table("Diary")]
    class Diary //дневник посещений
    {
        [Key]
        public int ID_Diary { get; set; } //id
        public DateTime Date_Diary { get; set; } //дата посещения
        public string Complaint_Diary { get; set; } //жалоба
        public string Diagnosis_Diary { get; set; } //диагноз
        public string Treatment_Diary { get; set; } //лечение
        public string Recomendation_Diary { get; set; } //рекомендации
        public string Price_Diary { get; set; } //цена
        public int ID_Dentist_Dia { get; set; }
        public int ID_Patient_Dia { get; set; }

        public Diary() { }

        public Diary(
            DateTime date_diary,
            string Complaint_Diary, 
            string Diagnosis_Diary,
            string Treatment_Diary, 
            string Recomendation_Diary,
            string Price_Diary,
            int ID_Dentist_Dia,
            int ID_Patient_Dia)
        {
            this.Date_Diary = date_diary;
            this.Complaint_Diary = Complaint_Diary;
            this.Diagnosis_Diary = Diagnosis_Diary;
            this.Treatment_Diary = Treatment_Diary;
            this.Recomendation_Diary = Recomendation_Diary;
            this.Price_Diary = Price_Diary;
            this.ID_Dentist_Dia = ID_Dentist_Dia;
            this.ID_Patient_Dia = ID_Patient_Dia;
        }
    }
}
