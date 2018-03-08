using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CS_CustomerInfo_Module.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CS_CustomerInfo_Module.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CustomerController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Customers.ToList());
        }

        //Get : Book / Create
        public IActionResult Create()
        {
            //var list = _db.Countries.ToList();


            //IEnumerable<Country> items = _db.Countries.ToList().Select(c => new SelectListItem
            //{
            //    Value = c.id.ToString(),
            //    Text = c.name
            //});
            //ViewBag.Countries = items;
            //ViewBag.Countries = new SelectList(list, "id", "name", 0);

            //IEnumerable<Country> items = _db.Countries.Select(c => new Country
            //{
            //    id = c.id,
            //    name = c.name

            //});
            //ViewBag.Countries = items;


            //List<Country> conlist = new List<Country>;

            //// ------- Getting Data from Database Using EntityFrameworkCore -------
            //conlist = (from Country  in _db.Countries
            //                select Country).ToList();

            //// ------- Inserting Select Item in List -------
            //conlist.Insert(0, new Country { id = 0, name = "Select" });

            //// ------- Assigning categorylist to ViewBag.ListofCategory -------
            //ViewBag.ListofCountry = conlist;
            return View();
            
        }

        //Post : Book / Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _db.Add(customer);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        //Details : Books/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var customer = await _db.Customers.SingleOrDefaultAsync(m => m.CustID == id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        //Edit : Books/Details/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var customer = await _db.Customers.SingleOrDefaultAsync(m => m.CustID == id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }


        //POST: Books/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _db.Update(customer);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }
        //public async Task<IActionResult> Edit(int id, Customer customer)
        //{
        //    if (id != customer.CustID)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        _db.Update(customer);
        //        await _db.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(customer);
        //}

        //Delete : Books/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var customer = await _db.Customers.SingleOrDefaultAsync(m => m.CustID == id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        //Post : Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveCustomer(int id)
        {
            var customer = await _db.Customers.SingleOrDefaultAsync(m => m.CustID == id);
            _db.Customers.Remove(customer);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        
        protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                _db.Dispose();
            }

        }

    }
}