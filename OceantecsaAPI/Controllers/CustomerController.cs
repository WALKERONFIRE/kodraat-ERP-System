using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace OceantecsaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerSerivce _CustomerService;

        public CustomerController(ICustomerSerivce CustomerService)
        {
            _CustomerService = CustomerService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var Customers = await _CustomerService.GetAll();
            return Ok(Customers);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            if (id == null)
                return BadRequest("Not Found");
            var Customer = await _CustomerService.GetById(id);
            if (Customer == null)
                return BadRequest("Not Found");
            return Ok(Customer);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CustomerDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var Customer = new Customer()
            {
                EnglishName = dto.EnglishName,
                ArabicName = dto.ArabicName,
                Description = dto.Description,
                EnglishAddress = dto.EnglishAddress,
                ArabicAddress = dto.ArabicAddress,
                TelephoneNo = dto.TelephoneNo,
                FaxNo  = dto.FaxNo,
                MobileNo = dto.MobileNo,
                Website = dto.Website,
                Email = dto.Email,
                CityId = dto.CityId,
                CustomerTypeId =dto.CustomerTypeId,
                CustomerActivityId = dto.CustomerActivityId,
                CustomerGroupId = dto.CustomerGroupId,
                AccountId = dto.AccountId,
                AccountReceivableId = dto.AccountReceivableId,
                Active = dto.Active,
                IsDeleted = false
            };
            await _CustomerService.Add(Customer);

            return Ok(Customer);
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(CustomerDto dto, int id)
        {
            var customer = await _CustomerService.GetById(id);
            if (customer == null)
                return BadRequest("Not Found");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try

            {
                customer.EnglishName = dto.EnglishName;
                customer.ArabicName = dto.ArabicName;
                customer.Description = dto.Description;
                customer.EnglishAddress = dto.EnglishAddress;
                customer.ArabicAddress = dto.ArabicAddress;
                customer.TelephoneNo = dto.TelephoneNo;
                customer.FaxNo = dto.FaxNo;
                customer.MobileNo = dto.MobileNo;
                customer.Website = dto.Website;
                customer.Email = dto.Email;
                customer.CityId = dto.CityId;
                customer.CustomerTypeId = dto.CustomerTypeId;
                customer.CustomerActivityId = dto.CustomerActivityId;
                customer.CustomerGroupId = dto.CustomerGroupId;
                customer.AccountId = dto.AccountId;
                customer.AccountReceivableId = dto.AccountReceivableId;
                customer.Active = dto.Active;
                customer.IsDeleted = false;
                _CustomerService.Update(customer);

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_CustomerService.CustomerExists(customer.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok(customer);
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var Customer = await _CustomerService.GetById(id);
            if (Customer == null)
                return BadRequest("Not Found");
            _CustomerService.Delete(Customer);
            return Ok(Customer);
        }
    }
}
