using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Common
{
    public static class Constant
    {
    }
    public static class Role
    {
        public static int UserNum = 1;
        public static string User = "USER";
        public static int TeacherNum = 2;
        public static string Teacher = "TEACHER";
        public static int AdminNum = 3;
        public static string Admin = "ADMIN";
    }
    public static class MasterData
    {
        public static int DropOutofSchoolNum = 1;
        public static string DropOutofSchool = "Thôi học";

        public static int NormalNum = 2;
        public static string Normal = "Bình thường";

        public static int GraduatedNum = 3;
        public static string Graduated = "Đã tốt nghiệp";

        public static int StopTeachingNum = 4;
        public static string StopTeaching = "Ngừng giảng dậy";

        public static int MaternityLeaveNum = 5;
        public static string MaternityLeave = "Nghỉ đẻ";

        public static int VacationNum = 6;
        public static string Vacation = "Nghỉ phép";

        public static int MaleNum = 7;
        public static string Male = "Nam";

        public static int FemaleNum = 8;
        public static string Female = "Nữ";

        public static int VINum = 9;
        public static string VI = "Tiếng Việt";

        public static int ENNum = 10;
        public static string EN = "Tiếng Anh";
    }
}