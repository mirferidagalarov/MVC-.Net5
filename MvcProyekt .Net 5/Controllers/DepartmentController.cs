using Microsoft.AspNetCore.Mvc;
using MvcProyekt_.Net_5.BLL.Abstract;
using MvcProyekt_.Net_5.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvcProyekt_.Net_5.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService  )
        {
            _departmentService = departmentService;
        }
        public async Task<IActionResult> Index()
        {
            List<DepartmentToListDTO> department = await _departmentService.Get();
            return View(department);
        }

        public IActionResult AddDepartment()
        {
            return View();
        }

        public async Task<IActionResult> Add(DepartmentToAddDTO departmentToAddDTO)
        {
            await _departmentService.Add(departmentToAddDTO);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateDepartment(int id)
        {
            DepartmentToUpdateDTO lesson = await _departmentService.GetId(id);
            return View(lesson);
        }

        public async Task<IActionResult> Update(DepartmentToUpdateDTO departmentToUpdateDTO)
        {
            if (!ModelState.IsValid)
            {
                return View("UpdateDepartment");
            }
            await _departmentService.Update(departmentToUpdateDTO);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _departmentService.Delete(id);
            return RedirectToAction("Index");
        }


    }
}
