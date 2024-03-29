using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BaKaVO.Classes
{
    [Table("Anamnesis")]
    class Anamnesis //анамнез
    {
        [Key]
        public int ID_Anamnesis { get; set; } //id
        public string First_Anamnesis { get; set; }  //да/нет для 1 строки и данные если да
        public string Second_Anamnesis { get; set; } //да/нет для 2 строки и данные если да
        public string Third_Anamnesis { get; set; } //да/нет для 3 строки и данные если да
        public string Fourth_Anamnesis { get; set; } //да/нет для 4 строки и данные если да
        public string Fifth_Anamnesis { get; set; } //да/нет для 5 строки и данные если да
        public string Sixth_Anamnesis { get; set; } //да/нет для 6 строки и данные если да
        public string Seventh_Anamnesis { get; set; } //да/нет для 7 строки и данные если да
        public string Eighth_Anamnesis { get; set; } //да/нет для 8 строки и данные если да
        public string Ninth_Anamnesis { get; set; }  //да/нет для 9 строки и данные если да
        public string Tenth_Anamnesis { get; set; } //да/нет для 10 строки и данные если да
        public string Other_Anamnesis { get; set; } //дополнительные данные
        public int ID_Patient_Ana { get; set; }

        public Anamnesis() { }

        public Anamnesis(
            string First_Anamnesis, 
            string Second_Anamnesis, 
            string Third_Anamnesis, 
            string Fourth_Anamnesis, 
            string Fifth_Anamnesis, 
            string Sixth_Anamnesis, 
            string Seventh_Anamnesis, 
            string Eighth_Anamnesis, 
            string Ninth_Anamnesis, 
            string Tenth_Anamnesis, 
            string Other_Anamnesis,
            int ID_Patient_Ana)
        {
            this.First_Anamnesis = First_Anamnesis;
            this.Second_Anamnesis = Second_Anamnesis;
            this.Third_Anamnesis = Third_Anamnesis;
            this.Fourth_Anamnesis = Fourth_Anamnesis;
            this.Fifth_Anamnesis = Fifth_Anamnesis;
            this.Sixth_Anamnesis = Sixth_Anamnesis;
            this.Seventh_Anamnesis = Seventh_Anamnesis;
            this.Eighth_Anamnesis = Eighth_Anamnesis;
            this.Ninth_Anamnesis = Ninth_Anamnesis;
            this.Tenth_Anamnesis = Tenth_Anamnesis;
            this.Other_Anamnesis = Other_Anamnesis;
            this.ID_Patient_Ana = ID_Patient_Ana;
        }
    }
}
