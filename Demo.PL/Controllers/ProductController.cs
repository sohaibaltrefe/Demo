using AutoMapper;
using Demo.BLL.Interfaces;
using Demo.DAL.Models;
using Demo.PL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Demo.PL.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepo;
        private readonly IMapper mapper;

        public  ProductController(IProductRepository productRepo,IMapper mapper)
        {
            this.productRepo = productRepo;
            this.mapper = mapper;
        }
        [HttpGet]
        public IActionResult Index()
        {
            
            var products = productRepo.GetAll();
           

                var ViewModel =mapper.Map<IEnumerable< ProductVm>>(products);
            
            return View(ViewModel);
        }

        [HttpGet]
        public IActionResult Create() {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProductFormViewModel viewModel) {
            if (ModelState.IsValid) 
            {
                var model=mapper.Map<Product>(viewModel);
                model.IsDeleted = false;
                productRepo.Add(model);
                return RedirectToAction(nameof(Index));
            }
            return View(viewModel); 
        }
        [HttpGet]
        public IActionResult Details(int? id) {

            if (id is null)
            {
                return BadRequest();
            }

            var product = productRepo.Get(id.Value);

            if (product is null)
            {
                return NotFound();
            }

            // Map the Product entity to ProductVm
            var viewModel = mapper.Map<ProductDetailsVm>(product);

            return View(viewModel);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id is null)
            {
                return BadRequest();
            }

            var product = productRepo.Get(id.Value);

            if (product is null)
            {
                return NotFound();
            }

            // Map the Product to ProductFormViewModel
            var viewModel = mapper.Map<ProductFormViewModel>(product);

            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Edit(ProductFormViewModel viewModel) {
            if (ModelState.IsValid)
            {
                var model = mapper.Map<Product>(viewModel);
                
                productRepo.Update(model);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(viewModel);
            }

         
        }
        public IActionResult Delete( int? id) {
            if (id is null)
            {
                return BadRequest();
            }
            var product = productRepo.Get(id.Value);
            if(product is null) { return NotFound(); }
            product.IsDeleted = true;
            productRepo.save();
            return RedirectToAction(nameof(Index));
            
        }
    }
}
