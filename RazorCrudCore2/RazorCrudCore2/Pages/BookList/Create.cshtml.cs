using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCrudCore2.Models;

namespace RazorCrudCore2.Pages.BookList
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        //show message after adding data successfully
        [TempData]
        public string Message { get; set; }

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Book Book { get; set; }

        public void OnGet()
        {

        }

        //create the Post handler/Method
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Books.Add(Book);
            await _db.SaveChangesAsync();

            //show meessage data added successfully
            Message = "Book has been created successfully";

            return RedirectToPage("Index");

        }
    }
}