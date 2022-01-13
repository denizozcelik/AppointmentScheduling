using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentScheduling.Models.ViewModels
{
    public class CommonResponse<T>
    {
        public int status { get; set; }

        public string messsage { get; set; }

        public T dataenumk { get; set; }
    }
}
