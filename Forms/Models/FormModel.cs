using System.ComponentModel.DataAnnotations;

namespace Forms.Models
{
    public class FormModel
    {
        [DataType(DataType.Date)]
        public DateTime? date { get; set; }

        public int numberOfDays { get; set; }
    }
}
