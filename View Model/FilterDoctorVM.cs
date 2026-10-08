namespace HospitalSystem.View_Model
{
    public class FilterDoctorVM
    {
        public string SearchName { get; set; }
        public string SearchSpecialization { get; set; }
        public int PageNumber { get; set; } = 1;
    }
}
