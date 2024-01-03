﻿using E_CommerceWebsiteUsingNetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_CommerceWebsiteUsingNetCoreMVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> categories = _db.Categories.ToList();
            return View(categories);
        }
    }
}