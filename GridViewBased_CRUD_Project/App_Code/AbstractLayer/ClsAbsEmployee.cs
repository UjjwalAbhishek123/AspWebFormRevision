using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GridViewBased_CRUD_Project.App_Code.AbstractLayer
{
    /// <summary>
    /// class holding properties related to employee
    /// </summary>
    public class ClsAbsEmployee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
    }
}