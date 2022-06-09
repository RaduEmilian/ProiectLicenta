using Lucene.Net.Search;
using Lucene.Net.Util;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TestFinal.Data;
using TestFinal.Models;
using TestFinal.Models.Repositores;
using TestFinal.ViewModels;
using X.PagedList;

namespace TestFinal.Controllers
{
    public class ProductController : Controller
    {
        private readonly IWebHostEnvironment hostingEnvironment;

        private readonly ICategoryServices categoryService;
        private readonly ISubcategoryServices subcategoryService;
        private readonly IProductService productService;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly MyDbContext context;
        public UserManager<ApplicationUser> UserManager { get; }

        public ProductController(IWebHostEnvironment _hostingEnvironment, ICategoryServices _categoryServices, IProductService _productService,
            RoleManager<IdentityRole> _roleManager,
               UserManager<ApplicationUser> _userManager, ISubcategoryServices _subcategoryService, MyDbContext _context)
        {
            hostingEnvironment = _hostingEnvironment;
            categoryService = _categoryServices;
            productService = _productService;
            roleManager = _roleManager;
            userManager = _userManager;
            subcategoryService = _subcategoryService;
            context = _context;
        }

        [HttpGet]
        [Authorize(Roles = "User")]
        public IActionResult ListProduct()
        {
            var product = productService.ListAllProductWith();
            return View("ListProduct", product);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult CreateProduct()
        {
            CreateProductViewModel model = new CreateProductViewModel { };
            foreach (Subcategory cat in subcategoryService.ListAllSubCategory())
            {
                model.Subcategories.Add(cat.Nume);
            }

            return View("CreateProduct", model);
        }


        public static string GetSerialKeyAlphaNumaric(int keyLength)
        {
            string newSerialNumber = "";
            string SerialNumber = Guid.NewGuid().ToString("N").Substring(0, (int)keyLength).ToUpper();
            for (int iCount = 0; iCount < (int)keyLength; iCount += 4)
                newSerialNumber = newSerialNumber + SerialNumber.Substring(iCount, 4) + "-";
            newSerialNumber = newSerialNumber.Substring(0, newSerialNumber.Length - 1);
            return newSerialNumber;
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateProduct(CreateProductViewModel model)
        {
            int keyLength = 12;

            var cat = subcategoryService.GetSubCategoryByName(model.SubCategory);
            string newSerialNumber = "";
            string SerialNumber = Guid.NewGuid().ToString("N").Substring(0, keyLength).ToUpper();
            for (int iCount = 0; iCount < (int)keyLength; iCount += 4)
                newSerialNumber = newSerialNumber + SerialNumber.Substring(iCount, 4) + "-";
            newSerialNumber = newSerialNumber.Substring(0, newSerialNumber.Length - 1);

            if (ModelState.IsValid)
            {
                //  var productCategorie = categoryService.GetCategoryByName(model.Nume);

                string uniquePhotoFileName = null;
                if (model.Photo != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    uniquePhotoFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniquePhotoFileName);
                    using (FileStream fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Photo.CopyTo(fs);
                    }
                }
                string uniquePhotoFileName1 = null;
                if (model.Photo1 != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    uniquePhotoFileName1 = Guid.NewGuid().ToString() + "_" + model.Photo1.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniquePhotoFileName1);
                    using (FileStream fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Photo1.CopyTo(fs);
                    }
                }

                string uniqueDoc = null;
                if (model.Doc != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.ContentRootPath, "Data", "Lucene");
                    uniqueDoc = Guid.NewGuid().ToString() + "_" + model.Doc.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueDoc);
                    using (FileStream fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Doc.CopyTo(fs);
                    }
                }
                string uniquePhotoFileName2 = null;
                if (model.Photo2 != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    uniquePhotoFileName2 = Guid.NewGuid().ToString() + "_" + model.Photo2.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniquePhotoFileName2);
                    using (FileStream fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Photo2.CopyTo(fs);
                    }
                }
                string uniquePhotoFileName3 = null;
                if (model.Video != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "video");
                    uniquePhotoFileName1 = Guid.NewGuid().ToString() + "_" + model.Video.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniquePhotoFileName3);
                    using (FileStream fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Video.CopyTo(fs);
                    }
                }

                Product produs = new Product
                {
                    ProductName = model.Nume,
                    ProductId = model.ProdusId,
                    ProductDescription = model.Descriere,
                    Pret = model.Pret,
                    //Categories = productCategorie[0],
                    ProductPicture = uniquePhotoFileName,
                    ProductPicture2 = uniquePhotoFileName1,
                    ProductPicture3 = uniquePhotoFileName2,
                    ProductVideo = uniquePhotoFileName3,
                    Subcategorie = cat[0],
                    SerialNo = newSerialNumber,
                    ProductStock = model.Stock
                    //de adaugat Model No
                };

                await productService.AddProductAsync(produs);

                return RedirectToAction("ListProduct", "product");
            }

            return View("CreateProduct", model);
        }
        [AllowAnonymous]

        public ViewResult ListProducts(string subcategory, int? page)
        {
            IEnumerable<Product> product;
            string currentSubCategory;

            if (string.IsNullOrEmpty(subcategory))
            {
                product = productService.ListAllProduct();
                currentSubCategory = "All Product";
            }
            else
            {
                product = productService.ListAllProduct().Where(c => c.Subcategorie.Nume == subcategory);

                currentSubCategory = subcategoryService.ListAllSubCategory().FirstOrDefault(c => c.Nume == subcategory)?.Nume;
            }

            return View(product.ToList().ToPagedList(page ?? 1, 3));
        }


        [Authorize(Roles = "Admin")]

        public RedirectToActionResult UpdateStock(int productId, int amount)
        {
            var selectedProduct = productService.ListAllProduct().FirstOrDefault(c => c.ProductId == productId);
            if (selectedProduct != null)
            {

                selectedProduct.ProductStock = amount;

            }
            context.SaveChanges();

            return RedirectToAction("ListProducts");
        }


        public ViewResult ListSubcategory(string category, int? page)
        {
            IEnumerable<Subcategory> subcategory;

            if (string.IsNullOrEmpty(category))
            {
                subcategory = subcategoryService.ListAllSubCategory();
            }

            subcategory = subcategoryService.ListAllSubCategory().Where(c => c.Categories.CategoryName == category);

            return View(subcategory.ToList().ToPagedList(page ?? 1, 3));
        }
        // [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await productService.GetProductByIdAsync(id);

            await productService.DeleteProductAsync(product);

            return RedirectToAction("ListProduct", "product");
        }



        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditProduct(int id)
        {
            var product = await productService.GetProductByIdAsync(id);

            if (product == null)
            {
                ViewBag.ErrorMessage = $"Car option with Id = {id} cannot be found";
                return View("NotFound");
            }

            var model = new EditProductViewModel
            {
                Id = product.ProductId,
                Nume = product.ProductName,
                Pret = product.Pret,
                Descriere = product.ProductDescription,
                Subcategories = product.Subcategorie
            };

            return View("EditProduct", model);
        }

        // This action responds to HttpPost and receives EditRoleViewModel
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditProduct(EditProductViewModel model)
        {
            var product = await productService.GetProductByIdAsync(model.Id);

            if (product == null)
            {
                ViewBag.ErrorMessage = $"Product with Id = {model.Id} cannot be found";
                return View("NotFound");
            }
            else
            {
                string uniquePhotoFileName = null;
                if (model.Photo != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    uniquePhotoFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniquePhotoFileName);
                    using (FileStream fs = new FileStream(filePath, FileMode.Create))
                    {
                        model.Photo.CopyTo(fs);
                    }
                }
                product.ProductName = model.Nume;
                product.ProductDescription = model.Descriere;
                product.Pret = model.Pret;
                product.ProductPicture = uniquePhotoFileName;

                await productService.UpdateProductAsync(product);

                return RedirectToAction("ListProduct", "product");

            }
            return View("ListProduct", model);
        }


        [HttpPost]
        public JsonResult AutoComplete(string prefix)
        {
            var product = (from Product in this.context.Products
                           where Product.ProductName.Contains(prefix)
                           select new
                           {
                               label = Product.ProductName,
                               val = Product.ProductId
                           }).ToList();

            return Json(product);
        }
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
                return NotFound();

            var product = await productService.GetProductByIdAsync(id);
            if (product == null)
                return NotFound();

            return View(product);
        }
    }
}
