
namespace HospitalSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplictaionDbContext _context =new ApplictaionDbContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Doctors(FilterDoctorVM filter)
        {

            var doctors = _context.Doctors.AsQueryable();

            if (filter.SearchName != null)
            {
                doctors = doctors.Where(d => d.DoctorName.Contains(filter.SearchName));
            }

            if (filter.SearchSpecialization != null)
            {
                doctors = doctors.Where(d => d.Specialization.Contains(filter.SearchSpecialization));
            }

            ViewBag.TotalPages = (int)Math.Ceiling((double)doctors.Count() / 6);
            ViewBag.CurrentPage = filter.PageNumber;
            ViewBag.SearchName = filter.SearchName;
            ViewBag.SearchSpecialization = filter.SearchSpecialization;

            doctors = doctors.Skip((filter.PageNumber - 1) * 6).Take(6);
            return View(doctors);
        }

        public IActionResult MakeAppointment(int doctorId)
        {
            var doctor = _context.Doctors.FirstOrDefault(d => d.Id == doctorId);

            if (doctor == null)
            {
                return NotFound();
            }

            ViewBag.Doctor = doctor;

            return View();
        }

    
        [HttpPost]
        public IActionResult MakeAppointment(Appointment appointment)
        {
            var isBooked = _context.Appointments.Any(a =>
                a.DoctorId == appointment.DoctorId &&
                a.Date.Date == appointment.Date.Date &&
                a.Time == appointment.Time
            );

            if (isBooked)
            {
                ViewBag.Doctor = _context.Doctors
                    .FirstOrDefault(d => d.Id == appointment.DoctorId);

                ViewBag.Error = "This doctor is already booked at this date and time.";

                return View(appointment);
            }

            _context.Appointments.Add(appointment);
            _context.SaveChanges();

            return RedirectToAction("AllAppointments");
        }

        public IActionResult AllAppointments()
        {
            var appointments = _context.Appointments
                .Include(a => a.Doctor)
                .ToList();

            return View(appointments);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
