using System;

namespace Mvc5Application1.Areas.ResourceManagement.ViewModels
{
    public class SearchEmployeeViewModel
    {
        public string Code { get; set; }

        public string EmployeeCode { get; set; }
        public string FullName { get; set; }
        public string HomeTown { get; set; }

        public string FullNameEnglish { get; set; }

        public DateTime? BirthDate { get; set; }
    }
}