﻿using System;

namespace JBHRIS.Api.Dto.Attendance
{
    public class WorkScheduleDto
    {
        /// <summary>
        /// 出勤日期
        /// </summary>
        public DateTime AttendanceDate { get; set; }
        /// <summary>
        /// 班別代碼
        /// </summary>
        public string ScheduleType { get; set; }
    }
}