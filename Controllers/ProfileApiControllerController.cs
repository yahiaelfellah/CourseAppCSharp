using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using CourseProjectApp.Models;
using CourseProjectApp.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CourseProjectApp.Controllers
{
    [Route("api/[controller]/")]
    public class ProfileApiController : Controller
    {
        private readonly ProfileContext _context;
        public ProfileApiController(ProfileContext context)
        {
            _context = context;
        }

        // Create Hobby
        [HttpPost]
        public async Task<IActionResult> CreateHobby(Hobbies model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(model);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index", "LoggedIn");

                }
            }
            catch (DbException ex)
            {
                ModelState.AddModelError(ex.ToString(),"Unable to Save changes. Please contact the system administrator.");

            }

              return RedirectToAction("Index", "LoggedIn",model);
        }

        // Create Individual
        [HttpPost]
        public async Task<IActionResult> CreateIndividual(Individual model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(model);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index", "LoggedIn");

                }
            }
            catch (DbException ex)
            {
                ModelState.AddModelError(ex.ToString(), "Unable to Save changes. Please contact the system administrator.");

            }

            return RedirectToAction("Index", "LoggedIn", model);


        }

        // Create Organization
        [HttpPost]
        public async Task<IActionResult> CreateOrganization(Organization model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(model);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index", "LoggedIn");

                }
            }
            catch (DbException ex)
            {
                ModelState.AddModelError(ex.ToString(), "Unable to Save changes. Please contact the system administrator.");

            }

            return RedirectToAction("Index", "LoggedIn", model);

        }

        // Edit Hobby
        [HttpPost]
        public async Task<IActionResult> EditHobby(Guid id, Hobbies model)
        {
            if (id != model.HobbieId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(model);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index", "LoggedIn");

                }
                catch(DbUpdateException ex)
                {
                    ModelState.AddModelError(ex.ToString(), "Unable to edit changes. Please contact the system administrator.");


                }


            }

            return RedirectToAction("Index", "LoggedIn",model);
        }

        // Edit Individual
        [HttpPost]
        public async Task<IActionResult> EditIndividual(Guid id, Individual model)
        {
            if (id != model.IndividualId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(model);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index", "LoggedIn");

                }
                catch (DbUpdateException ex)
                {
                    ModelState.AddModelError(ex.ToString(), "Unable to edit changes. Please contact the system administrator.");


                }


            }

            return RedirectToAction("Index", "LoggedIn", model);
        }

        // Edit Organization
        [HttpPost]
        public async Task<IActionResult> EditOrganization(Guid id, Organization model)
        {
            if (id != model.OrganizationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(model);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index", "LoggedIn");

                }
                catch (DbUpdateException ex)
                {
                    ModelState.AddModelError(ex.ToString(), "Unable to edit changes. Please contact the system administrator.");


                }


            }

            return RedirectToAction("Index", "LoggedIn", model);
        }

        // Detail Hobby
        [HttpGet]
        public async Task<IActionResult> DetailHobby(Guid? id)
        {
            if (id == null)
            {

                return NotFound();
            }

            var model = await _context.Hobby.SingleOrDefaultAsync(x => x.HobbieId == id);

            if (model == null)
            {

                return NotFound();
            }

            return PartialView(model);

        }

        // Detail Organization
        [HttpGet]
        public async Task<IActionResult> DetailOrganiztion(Guid? id)
        {
            if (id == null)
            {

                return NotFound();
            }

            var model = await _context.Organizations.SingleOrDefaultAsync(x => x.OrganizationId == id);

            if (model == null)
            {

                return NotFound();
            }

            return PartialView(model);

        }

        // Detail Individual
        [HttpGet]
        public async Task<IActionResult> DetailIndividual(Guid? id)
        {
            if (id == null)
            {

                return NotFound();
            }

            var model = await _context.Individuals.SingleOrDefaultAsync(x => x.IndividualId == id);

            if (model == null)
            {

                return NotFound();
            }

            return PartialView(model);

        }


        // Delete Hobby
        [HttpPost]
        public async Task<IActionResult> DeleteHobby(Guid id)
        {
            var model = 
            await _context.Hobby.SingleOrDefaultAsync(x => x.HobbieId == id);

            if (model == null)
            {

                return RedirectToAction("Index", "LoggedIn");
            }

            try
            {
                _context.Hobby.Remove(model);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "LoggedIn");

            }
            catch(DbUpdateException ex)
            {
                ModelState.AddModelError(ex.ToString(),"Error");

                return RedirectToAction("Index", "LoggedIn");
            }
        }

        // Delete Hobby
        [HttpPost]
        public async Task<IActionResult> DeleteOrgainization(Guid id)
        {
            var model =
            await _context.Organizations.SingleOrDefaultAsync(x => x.OrganizationId == id);

            if (model == null)
            {

                return RedirectToAction("Index", "LoggedIn");
            }

            try
            {
                _context.Organizations.Remove(model);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "LoggedIn");

            }
            catch (DbUpdateException ex)
            {
                ModelState.AddModelError(ex.ToString(), "Error");

                return RedirectToAction("Index", "LoggedIn");
            }
        }

        // Delete Hobby
        [HttpPost]
        public async Task<IActionResult> DeleteIndividual(Guid id)
        {
            var model =
            await _context.Individuals.SingleOrDefaultAsync(x => x.IndividualId == id);

            if (model == null)
            {

                return RedirectToAction("Index", "LoggedIn");
            }

            try
            {
                _context.Individuals.Remove(model);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "LoggedIn");

            }
            catch (DbUpdateException ex)
            {
                ModelState.AddModelError(ex.ToString(), "Error");

                return RedirectToAction("Index", "LoggedIn");
            }
        }
    }
}
