using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BaKaVO.Classes
{
    [Table("Exam")]
    class Exam //осмотр
    {
        [Key]
        public int ID_Exam { get; set; } //id
        public byte Num_Exam { get; set; } //первый/второй/третий осмотр (1/2/3)
        public bool Bit_Exam { get; set; } //верхняя/нижняя челюсть (0 - верхний, 1 нижний)
        public DateTime Date_Exam { get; set; } //дата осмотра (надо ли?) //блять))

        //левая и правая сторона как на бумаге! а не в жизни, левая 18-11 и 48-41, правая 21-28 и 31-38
        
        //левая
        public string Left_First_Exam { get; set; }  //номер чекбокса для левого столбца 11 и 41
        public string Left_Second_Exam { get; set; } //номер чекбокса для левого столбца 12 и 42
        public string Left_Third_Exam { get; set; } //номер чекбокса для левого столбца 13 и 43
        public string Left_Fourth_Exam { get; set; } //номер чекбокса для левого столбца 14 и 44
        public string Left_Fifth_Exam { get; set; }  //номер чекбокса для левого столбца 15 и 45
        public string Left_Sixth_Exam { get; set; } //номер чекбокса для левого столбца 16 и 46
        public string Left_Seventh_Exam { get; set; }  //номер чекбокса для левого столбца 17 и 47
        public string Left_Eighth_Exam { get; set; } //номер чекбокса для левого столбца 18 и 48

        //правая
        public string Right_First_Exam { get; set; } //номер чекбокса для правого столбца 21 и 31
        public string Right_Second_Exam { get; set; } //номер чекбокса для правого столбца 22 и 32
        public string Right_Third_Exam { get; set; } //номер чекбокса для правого столбца 23 и 33
        public string Right_Fourth_Exam { get; set; } //номер чекбокса для правого столбца 24 и 34
        public string Right_Fifth_Exam { get; set; } //номер чекбокса для правого столбца 25 и 35
        public string Right_Sixth_Exam { get; set; } //номер чекбокса для правого столбца 26 и 36
        public string Right_Seventh_Exam { get; set; } //номер чекбокса для правого столбца 27 и 37
        public string Right_Eighth_Exam { get; set; } //номер чекбокса для правого столбца 28 и 38
        public int ID_Patient_Exa { get; set; }

        public Exam() { }

        public Exam(
            byte Num_Exam, 
            bool Bit_Exam, 
            DateTime Date_Exam, 
            string Left_First_Exam, 
            string Left_Second_Exam, 
            string Left_Third_Exam, 
            string Left_Fourth_Exam, 
            string Left_Fifth_Exam, 
            string Left_Sixth_Exam, 
            string Left_Seventh_Exam, 
            string Left_Eighth_Exam,
            string Right_First_Exam,
            string Right_Second_Exam,
            string Right_Third_Exam,
            string Right_Fourth_Exam,
            string Right_Fifth_Exam,
            string Right_Sixth_Exam,
            string Right_Seventh_Exam,
            string Right_Eighth_Exam,
            int ID_Patient_Exa)
        {
            this.Num_Exam = Num_Exam;
            this.Bit_Exam = Bit_Exam;
            this.Date_Exam = Date_Exam;
            this.Left_First_Exam = Left_First_Exam;
            this.Left_Second_Exam = Left_Second_Exam;
            this.Left_Third_Exam = Left_Third_Exam;
            this.Left_Fourth_Exam = Left_Fourth_Exam;
            this.Left_Fifth_Exam = Left_Fifth_Exam;
            this.Left_Sixth_Exam = Left_Sixth_Exam;
            this.Left_Seventh_Exam = Left_Seventh_Exam;
            this.Left_Eighth_Exam = Left_Eighth_Exam;
            this.Right_First_Exam = Right_First_Exam;
            this.Right_Second_Exam = Right_Second_Exam;
            this.Right_Third_Exam = Right_Third_Exam;
            this.Right_Fourth_Exam = Right_Fourth_Exam;
            this.Right_Fifth_Exam = Right_Fifth_Exam;
            this.Right_Sixth_Exam = Right_Sixth_Exam;
            this.Right_Seventh_Exam = Right_Seventh_Exam;
            this.Right_Eighth_Exam = Right_Eighth_Exam;
            this.ID_Patient_Exa = ID_Patient_Exa;

        }
    }
}
