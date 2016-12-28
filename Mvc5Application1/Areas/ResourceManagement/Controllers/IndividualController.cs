using Mvc5Application1.Areas.ResourceManagement.ViewModels;
using Mvc5Application1.Business.Contracts.ResourceManagement;
using Mvc5Application1.Data.Model.ResourceManagement;
using Mvc5Application1.Infrastructure.Attribute;
using Mvc5Application1.Resources;
using PagedList;
using System;
using System.Configuration;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using EmployeeBasicInfo = Mvc5Application1.Data.Model.hrm_t_employee_base;

namespace Mvc5Application1.Areas.ResourceManagement.Controllers
{
    [AllowAnonymous]
    public class IndividualController : Controller
    {
        private readonly IEmployeeBusiness _employeeBusiness;

        public IndividualController(IEmployeeBusiness employeeBusiness)
        {
            _employeeBusiness = employeeBusiness;
        }

        // GET: ResourceManagement/Individual
        public ActionResult Index()
        {
            return View();
        }

        // GET: ResourceManagement/Individual/View?id=1
        public ActionResult View(int id)
        {
            var model = _employeeBusiness.GetEmployeeDetailsById(id);
            return View(model);
        }

        // GET: ResourceManagement/Individual/Edit?id=1
        public ActionResult Edit(int id)
        {
            var model = _employeeBusiness.GetEmployeeDetailsById(id);
            return View(model);
        }

        // GET: ResourceManagement/Individual/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: ResourceManagement/Individual/Search
        public ActionResult Search()
        {
            var employeeModel = new SearchEmployeeViewModel
            {
                BirthDate = DateTime.Today.Date
            };
            return View(employeeModel);
        }

        // POST: ResourceManagement/Individual/SearchEmployee
        [HttpPost]
        public ActionResult SearchEmployee(SearchEmployeeViewModel model)
        {
            try
            {
                ViewBag.Code = model.Code;
                ViewBag.FullName = !string.IsNullOrEmpty(model.FullName) ? model.FullName.Trim() : model.FullName;
                ViewBag.FullNameEnglish = !string.IsNullOrEmpty(model.FullNameEnglish) ? model.FullNameEnglish.Trim() : model.FullNameEnglish;
                ViewBag.BirthDate = model.BirthDate;
                ViewBag.HomeTown = model.HomeTown;
                ViewBag.SortBy = "FullName";
                ViewBag.SortOrder = "asc";
                ViewBag.Page = 1;//display the first page

                var criteria = new SearchEmployeeCriteria();
                criteria.BirthDate = model.BirthDate;
                criteria.Code = model.Code;
                criteria.FullName = model.FullName;
                criteria.FullNameEnglish = model.FullNameEnglish;
                criteria.HomeTown = model.HomeTown;

                var allEmployees = _employeeBusiness.SearchEmployees(criteria);

                var allSortedEmployees = allEmployees.OrderBy(x => x.FullName);

                var pageSize = 10;

                var pageNumber = 1;

                return PartialView("_SearchEmployeeResultTable", allSortedEmployees.ToPagedList(pageNumber, pageSize));
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    Success = false,
                    Message = ex.Message,
                    ReturnUrl = "/ResourceManagement/Individual/Search"
                }, JsonRequestBehavior.AllowGet);
            }
        }

        [DisableCache]
        public ActionResult SearchEmployee(
            string code,
            string fullName,
            string fullNameEnglish,
            string homeTown,
            DateTime? birthDate,
            string sortOrder,
            string sortBy,
            int? page
            )
        {
            ViewBag.Code = !string.IsNullOrEmpty(code) ? code.Trim() : code;
            ViewBag.FullName = !string.IsNullOrEmpty(fullName) ? fullName.Trim() : fullName;
            ViewBag.FullNameEnglish = !string.IsNullOrEmpty(fullNameEnglish) ? fullNameEnglish.Trim() : fullNameEnglish;
            ViewBag.HomeTown = !string.IsNullOrEmpty(homeTown) ? homeTown.Trim() : homeTown;
            ViewBag.BirthDate = birthDate;
            ViewBag.SortBy = sortBy;
            ViewBag.SortOrder = sortOrder;
            ViewBag.Page = page;

            var viewModel = new SearchEmployeeViewModel
            {
                Code = !string.IsNullOrEmpty(code) ? code.Trim() : code,
                FullName = !string.IsNullOrEmpty(fullName) ? fullName.Trim() : fullName,
                FullNameEnglish = !string.IsNullOrEmpty(fullNameEnglish) ? fullNameEnglish.Trim() : fullNameEnglish,
                HomeTown = !string.IsNullOrEmpty(homeTown) ? homeTown.Trim() : homeTown,
                BirthDate = birthDate
            };

            var criteria = new SearchEmployeeCriteria();

            criteria.Code = viewModel.Code;
            criteria.FullName = viewModel.FullName;
            criteria.FullNameEnglish = viewModel.FullNameEnglish;
            criteria.HomeTown = viewModel.HomeTown;
            criteria.BirthDate = viewModel.BirthDate;

            var allEmployees = _employeeBusiness.SearchEmployees(criteria);

            switch (sortBy)
            {
                case "Code":
                    allEmployees = sortOrder == "desc" ? allEmployees.OrderByDescending(x => x.Code).ToList() : allEmployees.OrderBy(x => x.Code).ToList();
                    break;

                case "FullName":
                    allEmployees = sortOrder == "desc" ? allEmployees.OrderByDescending(x => x.FullName).ToList() :
                        allEmployees.OrderBy(x => x.FullName).ToList();
                    break;

                case "FullNameEnglish":
                    allEmployees = sortOrder == "desc" ? allEmployees.OrderByDescending(x => x.FullNameEnglish).ToList() :
                        allEmployees.OrderBy(x => x.FullNameEnglish).ToList();
                    break;

                case "HomeTown":
                    allEmployees = sortOrder == "desc" ? allEmployees.OrderByDescending(x => x.HomeTown).ToList() : allEmployees.OrderBy(x => x.HomeTown).ToList();
                    break;

                case "BirthDate":
                    allEmployees = sortOrder == "desc" ? allEmployees.OrderByDescending(x => x.BirthDate).ToList() : allEmployees.OrderBy(x => x.BirthDate).ToList();
                    break;

                default:
                    allEmployees = sortOrder == "desc" ? allEmployees.OrderByDescending(x => x.FullName).ToList() :
                        allEmployees.OrderBy(x => x.FullName).ToList();
                    break;
            }

            var pageSize = 10;

            var pageNumber = (page ?? 1);

            return PartialView("_SearchEmployeeResultTable", allEmployees.ToPagedList(pageNumber, pageSize));
        }

        // POST: ResourceManagement/Individual/SaveBasicInformation

        [HttpPost]
        [ValidateAntiForgeryToken()]
        public ActionResult SaveBasicInformation(EmployeeBasicInfo model)
        {
            if (ModelState.IsValid)
            {
                #region Save file to temporary folder

                var fileName = string.Empty;
                var logicalName = string.Empty;
                var file = Request.Files["fileImport"];
                var fileSize = Convert.ToInt32(ConfigurationManager.AppSettings["MaxFileSize"].ToString()); // Max file size is 10485760
                if (file != null && file.ContentLength > 0)
                {
                    if (file.ContentLength > fileSize)
                    {
                        return Json(new { message = string.Format("Max file size is {0}, please input other image file.", fileSize) }, JsonRequestBehavior.AllowGet);
                    }

                    var extension = Path.GetExtension(file.FileName);
                    if (extension != ".png" && extension != ".jpg" && extension != ".jpeg" && extension != ".gif" && extension != ".tif")
                    {
                        return Json(new { message = "File type is an image, please input other image file." }, JsonRequestBehavior.AllowGet);
                    }

                    var fileNameNoEx = Path.GetFileNameWithoutExtension(file.FileName);
                    var timeStamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                    fileName = string.Concat(fileNameNoEx, timeStamp, extension);
                    logicalName = string.Concat(fileNameNoEx, extension);
                    string uploadPath = ConfigurationManager.AppSettings["ImportUploadFilePath"].ToString();
                    bool exists = Directory.Exists(Server.MapPath(uploadPath));
                    if (!exists)
                        Directory.CreateDirectory(Server.MapPath(uploadPath));

                    var path = Path.Combine(Server.MapPath(uploadPath), fileName);
                    file.SaveAs(path);
                }

                #endregion Save file to temporary folder

                var employee = new EmployeeBasicInfo();
                employee.maiden_name = model.maiden_name;
                employee.maiden_name_eng = model.maiden_name_eng;
                employee.sex_div = model.sex_div;
                employee.blood_type_div = model.blood_type_div;
                employee.hometown_name = model.hometown_name;
                employee.birth_date = model.birth_date;

                employee.image_file_logical_name = logicalName;
                employee.image_file_physical_name = fileName;

                _employeeBusiness.SaveEmployee(employee);

                return Json(new
                {
                    Success = true,
                    Message = "Redirecting...",
                    ReturnUrl = "/ResourceManagement/Individual/Index"
                }, JsonRequestBehavior.AllowGet);
            }

            return View();
        }

        // POST: ResourceManagement/Individual/DeleteEmployee?code=SD10003
        [HttpPost]
        public ActionResult DeleteEmployee(string code)
        {
            try
            {
                _employeeBusiness.DeleteEmployee(code);

                return Json(new
                {
                    Success = true,
                    Message = "Redirecting...",
                    ReturnUrl = ""
                }, JsonRequestBehavior.AllowGet);
            }
            catch (DbUpdateException dbUpdateException)
            {
                return Json(new
                {
                    Success = false,
                    Message = dbUpdateException.Message,
                    ReturnUrl = ""
                }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception exception)
            {
                return Json(new
                {
                    Success = false,
                    Message = string.Format("{0}. Exception: {1}", Message.IMPORT_DRAWING_DownloadError, exception.Message),
                    ReturnUrl = ""
                }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}