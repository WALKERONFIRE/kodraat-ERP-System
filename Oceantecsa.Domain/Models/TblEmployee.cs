using System;
using System.Collections.Generic;

namespace Oceantecsa.Domain.Models
{
    public partial class TblEmployee
    {
        public TblEmployee()
        {
            HrEmpDocuments = new HashSet<HrEmpDocument>();
            HrEmpItems = new HashSet<HrEmpItem>();
            HrEmpVacTypes = new HashSet<HrEmpVacType>();
            HrEvalDtls = new HashSet<HrEvalDtl>();
            HrExchangeTickets = new HashSet<HrExchangeTicket>();
            HrLoansHdrs = new HashSet<HrLoansHdr>();
            HrLogInfos = new HashSet<HrLogInfo>();
            HrPermissionDtls = new HashSet<HrPermissionDtl>();
            HrPunishments = new HashSet<HrPunishment>();
            HrRewards = new HashSet<HrReward>();
            HrSalaryDtls = new HashSet<HrSalaryDtl>();
            HrSalaryEmpDtls = new HashSet<HrSalaryEmpDtl>();
            HrVacAdds = new HashSet<HrVacAdd>();
            HrVacDtls = new HashSet<HrVacDtl>();
            HrVacReplaces = new HashSet<HrVacReplace>();
        }

        public int FId { get; set; }
        public string? FName { get; set; }
        public string? FNameA { get; set; }
        public string? FAddress { get; set; }
        public string? FTelephone { get; set; }
        public string? FJob { get; set; }
        public decimal? FGross { get; set; }
        public decimal? FTax { get; set; }
        public decimal? FDisc { get; set; }
        public decimal? FNet { get; set; }
        public string? FDescription { get; set; }
        public bool? FDeleted { get; set; }
        public int? FShiftId { get; set; }
        public DateTime? FRepDate { get; set; }
        public int? FBranchId { get; set; }
        public bool? FReplicated { get; set; }
        public bool? FSrvcPro { get; set; }
        public string? FTelephone2 { get; set; }
        public string? FTelephone3 { get; set; }
        public int? FPaymentType { get; set; }
        public bool? FGender { get; set; }
        public string? FAcountNo { get; set; }
        public string? FBank { get; set; }
        public DateTime? FBirth { get; set; }
        public DateTime? FHiring { get; set; }
        public string? FIdno { get; set; }
        public bool FEmpType { get; set; }
        public bool FPlayer { get; set; }
        public int FPathId { get; set; }
        public bool? CanInsurance { get; set; }
        public bool? CanTax { get; set; }
        public int DepartmentId { get; set; }
        public string IqamaId { get; set; } = null!;
        public DateTime IqamaDate1 { get; set; }
        public DateTime IqamaDate2 { get; set; }
        public string PassportId { get; set; } = null!;
        public DateTime PassportDate1 { get; set; }
        public DateTime PassportDate2 { get; set; }
        public string PassportIssue { get; set; } = null!;
        public int NationalityId { get; set; }
        public int MartialStatusId { get; set; }
        public int NominationTypeId { get; set; }
        public string Qualification { get; set; } = null!;
        public DateTime Graduation { get; set; }
        public string Experience { get; set; } = null!;
        public DateTime IsuranceDate { get; set; }
        public decimal InsuranceSalary { get; set; }
        public string IdIssuer { get; set; } = null!;
        public string? SIqamaDate1 { get; set; }
        public string? SIqamaDate2 { get; set; }
        public string InsuranceNo { get; set; } = null!;
        public int WorkPrftNo { get; set; }
        public float Commition { get; set; }
        public float CommitionVal { get; set; }
        public int DirectManager { get; set; }
        public int WeekendId { get; set; }
        public int SubEmpId { get; set; }
        public int AllowTime { get; set; }
        public int InsuranceOffice { get; set; }
        public DateTime ContractEnd { get; set; }
        public bool LifeInsurance { get; set; }
        public int SalayType { get; set; }
        public float BasicInsuranceEmpVal { get; set; }
        public float ChangeInsuranceEmpVal { get; set; }
        public string MachineId { get; set; } = null!;
        /// <summary>
        /// Value of Insurance payed Share for Emp
        /// </summary>
        public float InsuranceShareVal { get; set; }
        public int JobId { get; set; }
        public int BoundId { get; set; }
        public DateTime MilitryDate { get; set; }
        public bool SpecialNeeds { get; set; }
        public string BloodType { get; set; } = null!;
        public string PreventInsReason { get; set; } = null!;
        public int SectionId { get; set; }
        public int FStatus { get; set; }
        public string FEmail { get; set; } = null!;
        public bool FCustomerService { get; set; }
        public int MedicalInsType { get; set; }
        public int MedicalInsCompanion { get; set; }
        public string UniFormSize { get; set; } = null!;
        public string UniformColor { get; set; } = null!;
        public string UniformType { get; set; } = null!;
        public int ReligionId { get; set; }
        public string FAddress2 { get; set; } = null!;
        public int JobType { get; set; }
        public int ChildCount { get; set; }
        public string CardNo { get; set; } = null!;
        public string FJobEn { get; set; } = null!;
        public DateTime Idrelease { get; set; }
        public DateTime Idend { get; set; }
        public int TestPeriod { get; set; }
        public DateTime HiringRenew { get; set; }
        public float WorkHour { get; set; }
        public float HourCost { get; set; }

        public virtual HrDepartment Department { get; set; } = null!;
        public virtual HrEmpWeekEnd? HrEmpWeekEnd { get; set; }
        public virtual HrEndServiceBonusEmp? HrEndServiceBonusEmp { get; set; }
        public virtual ICollection<HrEmpDocument> HrEmpDocuments { get; set; }
        public virtual ICollection<HrEmpItem> HrEmpItems { get; set; }
        public virtual ICollection<HrEmpVacType> HrEmpVacTypes { get; set; }
        public virtual ICollection<HrEvalDtl> HrEvalDtls { get; set; }
        public virtual ICollection<HrExchangeTicket> HrExchangeTickets { get; set; }
        public virtual ICollection<HrLoansHdr> HrLoansHdrs { get; set; }
        public virtual ICollection<HrLogInfo> HrLogInfos { get; set; }
        public virtual ICollection<HrPermissionDtl> HrPermissionDtls { get; set; }
        public virtual ICollection<HrPunishment> HrPunishments { get; set; }
        public virtual ICollection<HrReward> HrRewards { get; set; }
        public virtual ICollection<HrSalaryDtl> HrSalaryDtls { get; set; }
        public virtual ICollection<HrSalaryEmpDtl> HrSalaryEmpDtls { get; set; }
        public virtual ICollection<HrVacAdd> HrVacAdds { get; set; }
        public virtual ICollection<HrVacDtl> HrVacDtls { get; set; }
        public virtual ICollection<HrVacReplace> HrVacReplaces { get; set; }
    }
}
