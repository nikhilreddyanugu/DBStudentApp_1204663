using DBStudentApp_1204663.Models;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStudentApp_1204663.DataLayer
{
    internal interface IRepository
    {
        List<Course> GetAllCourses();
        List<Enrollment> GetEnrollment(string courseNum);

    }
}