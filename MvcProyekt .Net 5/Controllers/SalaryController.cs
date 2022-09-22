using Microsoft.AspNetCore.Mvc;
using MvcProyekt_.Net_5.BLL.Abstract;
using MvcProyekt_.Net_5.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvcProyekt_.Net_5.Controllers
{
    public class SalaryController : Controller
    {
        private readonly ISalaryService _salaryService;
        private readonly IMonthService _monthService;
        private readonly IYearService _yearService;


        public SalaryController(ISalaryService salaryService, IMonthService monthService, IYearService yearService)
        {
            _salaryService = salaryService;
            _monthService = monthService;
            _yearService = yearService;


        }
        public async Task<IActionResult> Index(int id)
        {
            List<SalaryToListDTO> salarys = await _salaryService.Get();
            ViewBag.EmpId = id;
            return View(salarys);
        }

        public async Task<IActionResult> AddSalary(int id)
        {

            List<MonthToListDTO> monthToListDTOs = await _monthService.Get();
            List<YearToListDTO> yearToListDTOs = await _yearService.Get();
            SalaryToAddDTO salaryToAddDTO = new SalaryToAddDTO();
            salaryToAddDTO.Month = monthToListDTOs;
            salaryToAddDTO.Year = yearToListDTOs;
            salaryToAddDTO.EmployeeId = id;
            return View(salaryToAddDTO);
        }
        public async Task<IActionResult> Add(SalaryToAddDTO salaryToAddDTO)
        {

            await _salaryService.Add(salaryToAddDTO);
            return RedirectToAction("Index");

        }
    }
}
