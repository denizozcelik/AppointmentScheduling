using AppointmentScheduling.Models.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppointmentScheduling.Services
{
    public interface IAppointmentService
    {
        public List<DoctorVM> GetDoctorList();
        
        public List<PatientVM> GetPatientList();
        
        public Task<int> AddUpdate(AppointmentVM model);

        public List<AppointmentVM> DoctorsEventsById(string doctorId);
        
        public List<AppointmentVM> PatientsEventsById(string patientId);

    }
}
