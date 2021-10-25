using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace web_app1.Models
{
    public class EventModel
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "Please Enter the Title of the Event")]
        public string Title { get; set; }
        //[Required (ErrorMessage = "Please Enter the Stating Date and Time of the Event")]
        public DateTime? StartTime { get; set; }
        //[Required (ErrorMessage = "Please Enter the Ending Date and time of the Event")]
        public DateTime? EndTime { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        [Required(ErrorMessage = "Please Enter the Language of the Event")]
        public string language { get; set; }
        

    }
}
