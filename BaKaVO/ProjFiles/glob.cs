using BaKaVO.Classes;
using BaKaVO.MVVM.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaKaVO.Windows
{
    internal class glob
    {
        public static string connectionstring = @"Data Source = .\SQLEXPRESS; Initial Catalog = bakavo;Integrated Security=True";
        //public static string connectionstring = @"Data Source = localhost; Initial Catalog = bakavo;Integrated Security=True";

        public static SqlDataAdapter adapt;
        public static System.Data.DataTable dt;

        public static AnamnesisContext anamnesisdb = new AnamnesisContext();
        public static DentistContext dentistdb = new DentistContext();
        public static DiaryContext diarydb = new DiaryContext();
        public static ExamContext examdb = new ExamContext();
        public static PatientContext patientdb = new PatientContext();

        public static int pat_id;
        public static int curvi_id;
        public static bool issaveclicked;
        //public static int curr_patlistpage;

        //public static int patientperpage;


        public static Base myBase;
        public static PatientListView myPatientListView;
        public static PatientView myPatientView;
        public static AnamnesisView myAnamnesisView;
        public static SettingsView mySettingsView;
    }
}
