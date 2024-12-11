using Microsoft.AspNetCore.Mvc;
using prototype.Models;
using prototype.Models.Registration;

namespace prototype.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Step 1
        public IActionResult Index()
        {
            // Retrieve Step 1 data from TempData if it exists; otherwise, create a new model
            var model = TempData["StepOneData"] as StepOneModel ?? new StepOneModel();
            TempData.Keep("StepOneData"); // Keep TempData for the next steps
            return View(model);
        }

        // POST: Step 1
        [HttpPost]
        public IActionResult Index(StepOneModel model)
        {
            if (ModelState.IsValid)
            {
                // Save Step 1 data to TempData
                TempData["StepOneData"] = model;

                // Redirect to Step 2: PersonalInfo
                return RedirectToAction("PersonalInfo");
            }

            // If validation fails, return the same view
            return View(model);
        }

        // GET: Step 2
        public IActionResult PersonalInfo()
        {
            // Retrieve Step 1 data from TempData (if needed for Step 2 logic)
            var stepOneData = TempData["StepOneData"] as StepOneModel;

            // Create a new Step 2 model to pass to the view
            var model = new PersonalInfoModel();
            TempData.Keep("StepOneData"); // Ensure Step 1 data persists for further steps
            return View(model);
        }

        // POST: Step 2
        [HttpPost]
        public IActionResult PersonalInfo(PersonalInfoModel model)
        {
            if (ModelState.IsValid)
            {
                // Save Step 2 data to TempData
                TempData["StepTwoData"] = model;

                // Redirect to the next step (or other logic)
                return RedirectToAction("Index"); // Temporary redirection for now
            }

            // If validation fails, return the same view
            return View(model);
        }
    }
}
