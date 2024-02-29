using AcdYoklama.DAL;
using AcdYoklama.Models;
using AcdYoklama.Models.DbEntities;
using Microsoft.AspNetCore.Mvc;
namespace AcdYoklama.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDbContext _context;

        public EmployeeController(EmployeeDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var employees = _context.Yoklamas.ToList();
            List<EmployeeViewModel> employeeList = new List<EmployeeViewModel>();

            if (employees != null)
            {
                foreach (var employee in employees)
                {
                    var EmployeeViewModel = new EmployeeViewModel()
                    {
                        OgrenciId = employee.OgrenciId,
                        Ogrenci_adi = employee.Ogrenci_adi,
                        Ogrenci_no = employee.Ogrenci_no,
                        Ogrenci_sinif = employee.Ogrenci_sinif,
                        Ogrenci_url = employee.Ogrenci_url
                    };
                    employeeList.Add(EmployeeViewModel);
                }
                return View(employeeList);
            }
            return View(employeeList);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeViewModel employeeData)
        {
          try
            { 
            if (ModelState.IsValid)
            {
                var employee = new Employee()
                {
                    Ogrenci_adi = employeeData.Ogrenci_adi,
                    Ogrenci_no = employeeData.Ogrenci_no,
                    Ogrenci_sinif = employeeData.Ogrenci_sinif,
                    Ogrenci_url = employeeData.Ogrenci_url
                };
                _context.Yoklamas.Add(employee);
                _context.SaveChanges();
                TempData["SuccessMessage"] = "Başarıyla Oluşturuldu!";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["ErrorMessage"] = "Veriler geçerli değil.";
                return View();
            }
        }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.Message;
                return View();
            }

        }

        [HttpGet]
        public IActionResult Edit(int OgrenciId)
        {
           try
           {
                var employee = _context.Yoklamas.SingleOrDefault(x => x.OgrenciId == OgrenciId);

                if (employee != null)
                {
                    var employeeView = new EmployeeViewModel()
                    {
                        OgrenciId = employee.OgrenciId,
                        Ogrenci_adi = employee.Ogrenci_adi,
                        Ogrenci_no = employee.Ogrenci_no,
                        Ogrenci_sinif = employee.Ogrenci_sinif,
                        Ogrenci_url = employee.Ogrenci_url
                    };
                    return View(employeeView);
                }
                else
                {
                    TempData["ErrorMessage"] = $"Employee details not available with the Id: {OgrenciId}";
                    return RedirectToAction("Index");
                }
           }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Edit(EmployeeViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var employee = new Employee()
                    {
                        OgrenciId = model.OgrenciId,
                        Ogrenci_adi = model.Ogrenci_adi,
                        Ogrenci_no = model.Ogrenci_no,
                        Ogrenci_sinif = model.Ogrenci_sinif,
                        Ogrenci_url = model.Ogrenci_url
                    };
                    _context.Yoklamas.Update(employee);
                    _context.SaveChanges();
                    TempData["SuccessMessage"] = "Updated Successfully";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["ErrorMessage"] = "data is invalid.";
                   return View();
                }
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return View();
            }
        }


        [HttpGet]
        public IActionResult Delete(int OgrenciId)
        {
            try
            {
                var employee = _context.Yoklamas.SingleOrDefault(x => x.OgrenciId == OgrenciId);

                if (employee != null)
                {
                    var employeeView = new EmployeeViewModel()
                    {
                        OgrenciId = employee.OgrenciId,
                        Ogrenci_adi = employee.Ogrenci_adi,
                        Ogrenci_no = employee.Ogrenci_no,
                        Ogrenci_sinif = employee.Ogrenci_sinif,
                        Ogrenci_url = employee.Ogrenci_url
                    };
                    return View(employeeView);
                }
                else
                {
                    TempData["ErrorMessage"] = $"Employee details not available with the Id: {OgrenciId}";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Delete(EmployeeViewModel model)
        {
            try
            {
                var employee = _context.Yoklamas.SingleOrDefault(x => x.OgrenciId == model.OgrenciId);

                if (employee != null)
                {
                    _context.Yoklamas.Remove(employee);
                    _context.SaveChanges();
                    TempData["SuccessMessage"] = "Employee deleted successfully!";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["ErrorMessage"] = $"Employee details not available with the Id: {model.OgrenciId}";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return View();
            }
        }

        [HttpGet]
        public IActionResult Goruntule(int OgrenciId)
        {
            try
            {
                var employee = _context.Yoklamas.SingleOrDefault(x => x.OgrenciId == OgrenciId);

                if (employee != null)
                {
                    var employeeView = new EmployeeViewModel()
                    {
                        OgrenciId = employee.OgrenciId,
                        Ogrenci_adi = employee.Ogrenci_adi,
                        Ogrenci_no = employee.Ogrenci_no,
                        Ogrenci_sinif = employee.Ogrenci_sinif,
                        Ogrenci_url = employee.Ogrenci_url
                    };
                    return View(employeeView);
                }
                else
                {
                    TempData["ErrorMessage"] = $"Employee details not available with the Id: {OgrenciId}";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Index");
            }
        }
        //PROFİL SAYFASI

        [HttpGet]
        public IActionResult Profil(int OgrenciId)
        {
            try
            {
                var employee = _context.Yoklamas.SingleOrDefault(x => x.OgrenciId == OgrenciId);

                if (employee != null)
                {
                    var employeeView = new EmployeeViewModel()
                    {
                        OgrenciId = employee.OgrenciId,
                        Ogrenci_adi = employee.Ogrenci_adi,
                        Ogrenci_no = employee.Ogrenci_no,
                        Ogrenci_sinif = employee.Ogrenci_sinif,
                        Ogrenci_url = employee.Ogrenci_url
                    };
                    return View(employeeView);
                }
                else
                {
                    TempData["ErrorMessage"] = $"Employee details not available with the Id: {OgrenciId}";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

    }
}
