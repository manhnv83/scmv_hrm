using System;
using System.Xml.Serialization;

namespace Mvc5Application1.Data.Model.ResourceManagement
{
    public class SearchEmployeeCriteria
    {
        public DateTime? BirthDate { get; set; }
        public string FullName { get; set; }

        [XmlElement(IsNullable = true)]
        public string FullNameEnglish { get; set; }

        [XmlElement(IsNullable = true)]
        public string HomeTown { get; set; }

        public string Code { get; set; }
    }
}