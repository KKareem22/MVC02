using GymManagement.DAL.Repositories.Classes;
using GymManagement.DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
namespace GymManagement.PL.Controllers
{
    public class PlansController : Controller
    {
        private readonly IPlanRepository planRepository;
        public PlansController(IPlanRepository _planRepository)
        {
            planRepository = _planRepository;
            
        }
        public async Task<IActionResult> Index(CancellationToken ct)
        {
            var plans = await planRepository.GetAllAsync(ct: ct);
            return View(plans);
        }

        public async Task<IActionResult>Details (int id, CancellationToken ct)
        {
            var plan=await planRepository.GetByIdAsync(id,ct);
            if (plan == null)
                return RedirectToAction(nameof(Index));
            
            return View(plan);

        }
    }
}
