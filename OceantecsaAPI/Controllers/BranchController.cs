using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;
using System;

namespace OceantecsaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly IBranchService _branchService;

        public BranchController(IBranchService branchService)
        {
            _branchService = branchService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var Branches = await _branchService.GetAll();
            return Ok(Branches);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            if (id == null)
                return BadRequest("Not Found");
            var Branch = await _branchService.GetById(id);
            if (Branch == null)
                return BadRequest("Not Found");
            return Ok(Branch);
        }
        [HttpPost]
        public async Task<IActionResult> Create(BranchDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var branch = new Branch()
            {
                EnglishName = dto.EnglishName,
                ArabicName = dto.ArabicName,
                EnglishAddress = dto.EnglishAddress,
                ArabicAddress = dto.ArabicAddress,
                TelephoneNo1 = dto.TelephoneNo1,
                TelephoneNo2 = dto.TelephoneNo2,
                TelephoneNo3 = dto.TelephoneNo3,
                FaxNo = dto.FaxNo,
                Description = dto.Description,
                CityId = dto.CityId,
                HeadOffice = dto.HeadOffice,
                IsFactory = dto.IsFactory,
                IsShowRoom = dto.IsShowRoom,
                CostCenterId = dto.CostCenterId,
                Active = dto.Active,
                IsDeleted = false     
            };
            await _branchService.Add(branch);

            return Ok(branch);
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(BranchDto dto, int id)
        {
            var branch = await _branchService.GetById(id);
            if (branch == null)
                return BadRequest("Not Found");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try

            {
                branch.EnglishName = dto.EnglishName;
                branch.ArabicName = dto.ArabicName;
                branch.EnglishAddress = dto.EnglishAddress;
                branch.ArabicAddress = dto.ArabicAddress;
                branch.TelephoneNo1 = dto.TelephoneNo1;
                branch.TelephoneNo2 = dto.TelephoneNo2;
                branch.TelephoneNo3 = dto.TelephoneNo3;
                branch.FaxNo = dto.FaxNo;
                branch.Description = dto.Description;
                branch.CityId = dto.CityId;
                branch.HeadOffice = dto.HeadOffice;
                branch.IsFactory = dto.IsFactory;
                branch.IsShowRoom = dto.IsShowRoom;
                branch.CostCenterId = dto.CostCenterId;
                branch.Active = dto.Active;
                branch.IsDeleted = false;
                _branchService.Update(branch);

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_branchService.BranchExists(branch.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok(branch);
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var branch = await _branchService.GetById(id);
            if (branch == null)
                return BadRequest("Not Found");
            _branchService.Delete(branch);
            return Ok(branch);
        }
    }
}
