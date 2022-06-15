﻿using System;

namespace JBHRIS.Api.Dto.Attendance.View
{
    /// <summary>
    /// 得假查詢DTO
    /// </summary>
    public class AbsenceEntitleViewDto
    {
        /// <summary>
        /// 員工編號
        /// </summary>
        public string EmployeeId { get; set; }
        /// <summary>
        /// 員工姓名
        /// </summary>
        public string EmployeeName { get; set; }
        /// <summary>
        /// 編制部門代碼(顯示)
        /// </summary>
        public string DepartmentCode { get; set; }
        /// <summary>
        /// 編制部門名稱
        /// </summary>
        public string DepartmentName { get; set; }
        /// <summary>
        /// 假別代碼(顯示)
        /// </summary>
        public string LeaveCode { get; set; }
        /// <summary>
        /// 假別名稱
        /// </summary>
        public string LeaveName { get; set; }
        /// <summary>
        /// 生效日期
        /// </summary>
        public DateTime BeginDate { get; set; }
        /// <summary>
        /// 失效日期
        /// </summary>
        public DateTime EndDate { get; set; }
        /// <summary>
        /// 得假
        /// </summary>
        public decimal Entitle { get; set; }
        /// <summary>
        /// 已請
        /// </summary>
        public decimal Taken { get; set; }
        /// <summary>
        /// 剩餘
        /// </summary>
        public decimal Balance { get; set; }
        /// <summary>
        /// 單位
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// 備註
        /// </summary>
        public string Remark { get; set; }
    }
}