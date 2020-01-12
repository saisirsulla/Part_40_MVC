using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Part40Mvc.Models
{
    [MetadataType(typeof(EmployeeMetaData))]
    public partial class Employee
    {

    }

    public class EmployeeMetaData
    {
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [DisplayFormat(DataFormatString ="{0:dd/MM/yy hh:mm:ss tt}",ApplyFormatInEditMode =true)]
        public Nullable<System.DateTime> HireDate { get; set; }

        [DisplayFormat(NullDisplayText ="Gender not specified")]
        public string Gender { get; set; }

        //This DataAnnotation property only when you have @Html.DisplayForModel in Views
        //Remember all properties in Model will be displayed in Views including Id column
        //[ScaffoldColumn(false)]
        //public Nullable<int> Salary { get; set; }

        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }


        [DataType(DataType.Url)]
        [UIHint("OpenInNewWindow")]
        public string PersonalWebSite { get; set; }

        //if you want currency to be in rupee format GO to Webconfig under <system.web> add globalization tag add a property culture = hi-IN
        [DataType(DataType.Currency)]
        public Nullable<int> Salary { get; set; }
    }

}