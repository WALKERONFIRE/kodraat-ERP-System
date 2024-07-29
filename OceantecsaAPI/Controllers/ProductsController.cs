using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.IdentityServices;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Persistence.DataContext;

namespace OceantecsaAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		private readonly IProductsService _productsService;
		private readonly IMapper _mapper;
		private readonly IDevelopERPContext _context;
		private readonly IProductUnitPricesService _productUnitPricesService;
		public ProductsController(IProductsService productsService, IDevelopERPContext context, IMapper mapper, IProductUnitPricesService productUnitPricesService)
		{
			_productsService = productsService;
			_context = context;
			_mapper = mapper;
			_productUnitPricesService = productUnitPricesService;
		}


		[HttpGet]
		public async Task<IActionResult> GetAllAsync()
		{
			var products = await _productsService.GetAll();
			return Ok(products);
		}

		[HttpGet("GetById")]
		public async Task<IActionResult> GetByIdAsync(long id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var product = await _productsService.GetById(id);
			if (product == null)
			{
				return NotFound();
			}
			return Ok(product);
		}

		[HttpGet]
		[Route("api/images")]
		public IActionResult GetAllImages()
		{
			string fullPath = Directory.GetCurrentDirectory() + "/Images";

			string[] files = Directory.GetFiles(fullPath);

			List<string> imageUrls = new List<string>();

			foreach (string file in files)
			{
				string imageUrl = Request.Scheme + "://" + Request.Host.Value + "/Images/" + Path.GetFileName(file);
				imageUrls.Add(imageUrl);
			}

			return Ok(imageUrls);
		}

		[HttpPost("AddImage")]
		public async Task<IActionResult> AddImage(IFormFile file)
		{
			 string fullPath = Directory.GetCurrentDirectory()+ "/Images";

			string name = DateTime.Now.Ticks.ToString() + file.FileName;

			string filePath = fullPath + "/" + name;

			 var stream = new FileStream(filePath, FileMode.Create);

			await file.CopyToAsync(stream);
			string imageUrl = Request.Scheme + "://" + Request.Host.Value + "/Images/" + Path.GetFileName(name);

			return Ok(imageUrl);


		}

		[HttpPost]
		public async Task<IActionResult> CreateAsync(ProductDto dto)
		{
			string barCode = _productsService.GenerateProductCode();
			var data = _mapper.Map<Product>(dto);
			data.Barcode = barCode;
			await _productsService.Add(data);
		

			foreach (var item in dto.ProductUnitPricesDto)
			{
				ProductUnitPrice p = new ProductUnitPrice()
				{
					MeasurementUnitId = item.MeasurementUnitId,
					WholesalePrice = item.WholesalePrice,
					HalfWholesalePrice = item.HalfWholesalePrice,
					RetailPrice = item.RetailPrice
				};

				p.ProductId = data.Id;
				await _productUnitPricesService.Add(p);


			}
			
			return Ok(data);

		}

		[HttpDelete]
		public async Task<IActionResult> DeleteAsync(long id)
		{
			var product = await _productsService.GetById(id);
			if (product == null)
			{
				return NotFound($"Cannot found this product with ID : {id}");
			}

			_productsService.Delete(product);
			return Ok(product);
		}


		[HttpPut]
		public async Task<IActionResult> UpdateAsync(int id, ProductDto dto)
		{
			var product = await _productsService.GetById(id);
			if (product == null)
			{
				return NotFound($"Cannot found this product with ID : {id}");
			}
			try
			{
				product.Id = dto.Id;
				product.ArabicName = dto.ArabicName;
				product.EnglishName = dto.EnglishName;
				product.Description = dto.Description;
				product.ProductGroupId = dto.ProductGroupId;
				product.ProductTypeId = dto.ProductTypeId;
				product.ProductProductionTypeId = dto.ProductProductionTypeId;
				product.MeasurementUnitId = dto.MeasurementUnitId;
				product.SupplierId = dto.SupplierId;
				product.SupplierProductId = dto.SupplierProductId;
				product.VattypeId = dto.VattypeId;
				product.Vatpercentage = dto.Vatpercentage;
				product.SalesTaxPercent = dto.SalesTaxPercent;
				product.SafetyPoint = dto.SafetyPoint;
				product.ReorderPoint = dto.ReorderPoint;
				product.HasExpiryDate = dto.HasExpiryDate;
				product.ManufacturingCountryId = dto.ManufacturingCountryId;
				product.AlternativeProduct = dto.AlternativeProduct;
				product.MaxReorderPoint = dto.MaxReorderPoint;
				product.ProductHeight = dto.ProductHeight;
				product.ProductWidth = dto.ProductWidth;
				product.Photo = dto.Photo;
				product.Barcode = dto.Barcode;
				product.Active = dto.Active;
				product.IsDeleted = dto.IsDeleted;
				_productsService.Update(product);
				return Ok(product);
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!_productsService.ProductExists(product.Id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}
		}

	}
}
