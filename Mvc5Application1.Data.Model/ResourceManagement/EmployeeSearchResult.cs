using System;

namespace Mvc5Application1.Data.Model.ResourceManagement
{
    public class EmployeeSearchResult
    {
        public int Id { get; set; }
        public string Code { get; set; }

        public string FullName { get; set; }
        public string HomeTown { get; set; }

        public string FullNameEnglish { get; set; }

        public DateTime? BirthDate { get; set; }
        public string CreatedDate { get; set; }
    }
}