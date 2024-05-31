using Microsoft.AspNetCore.Mvc;
using TRPO_Lab3.Lib;
using TRPO_Lab5.Web.Models;

public class SurfaceAreaController : Controller
{
    [HttpGet]
    public ActionResult Index(ContainerViewModel vm)
    {
        return View(vm);
    }

    [HttpPost]
    public ActionResult Index(ContainerViewModel vm, IFormCollection collection)
    {
        try
        {
            double P1 = vm.P1;
            double P2 = vm.P2;
            double H = vm.H;
            double result = vm.Result;
            return View(vm);
        }
        catch (Exception ex)
        {
            return View("Error", new ErrorViewModel { RequestId = ex.Message });
        }
    }
}