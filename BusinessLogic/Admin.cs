using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogic
{
   public static class Admin
    {
        #region Student
        public static void AddStudent(student_t student)
        {
            using (SchoolDataDataContext data = new SchoolDataDataContext())
            {
                data.student_ts.InsertOnSubmit(student);
                data.SubmitChanges();
            }
        }

        //public static void AddStudent(object student)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion

     
       #region Class
        public static void AddClass(subject_t subject_T)
        {
            using(SchoolDataDataContext data = new SchoolDataDataContext())
            {
                data.subject_ts.InsertOnSubmit(subject_T);
                data.SubmitChanges();
            }
        }

        #endregion

        #region Update
        public static void UpdateStudent(student_t student)
        {
            using (SchoolDataDataContext data = new SchoolDataDataContext())
            {
                student_t st = (from s in data.student_ts where s.studentID == student.studentID
                              select s).FirstOrDefault();
                st.first_name = student.first_name;
                st.last_name = student.last_name;
                st.gender = student.gender;
                st.gpa = student.gpa;
                data.SubmitChanges();
            }
        }
        #endregion

        #region Delete
        public static void DeleteStudent(student_t student)
        {
            using (SchoolDataDataContext data = new SchoolDataDataContext())
            {
                student_t st = (from s in data.student_ts
                                where s.studentID == student.studentID
                                select s).FirstOrDefault();
                data.student_ts.DeleteOnSubmit(st);
                data.SubmitChanges();
            }
        }
        #endregion
    }
}
