using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JBHRIS.Api.Dto;
using JBHRIS.Api.Dto.Attendance;
using JBHRIS.Api.Dto.Attendance.Entry;
using JBHRIS.Api.Dto.Attendance.View;
using JBHRIS.Api.Service.Attendance.Normal;
using JBHRIS.Api.Service.Attendance.View;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace HR_WebApi.Controllers.Attendance.View
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/View/[controller]")]
    [ApiController]
    public class OverTimeViewController
    {

        IOverTimeViewService _overTimeViewService;
        public OverTimeViewController(IOverTimeViewService overTimeViewService)
        {
            _overTimeViewService = overTimeViewService;
        }

        /// <summary>
        /// 加班查詢
        /// </summary>
        /// <remarks>
        /// { "employeeList": [ "A1357","A0793" ], "dateBegin": "2020-09-05", "dateEnd": "2020-09-09" }
        /// </remarks>
        [HttpPost("OverTimeSearchView")]
        [Authorize(Roles = "OverTimeView/OverTimeSearchView,Admin")]
        public ApiResult<List<OverTimeSearchViewDto>> GetOverTimeSearchView(OverTimeSearchViewEntry overTimeSearchViewEntry)
        {
            return _overTimeViewService.GetOverTimeSearchView(overTimeSearchViewEntry);
        }

        /// <summary>
        /// 取得加班原因
        /// </summary>
        /// <returns></returns>
        [Route("GetOvertimeReason")]
        [HttpGet]
        [Authorize(Roles = "OverTimeView/GetOvertimeReason,Admin")]
        public ApiResult<List<OvertimeReasonDto>> GetOvertimeReason()
        {
            ApiResult<List<OvertimeReasonDto>> apiResult = new ApiResult<List<OvertimeReasonDto>>();
            apiResult.State = false;
            try
            {
                apiResult.Result = _overTimeViewService.GetOvertimeReason();
                apiResult.State = true;
            }
            catch (Exception ex)
            {
                apiResult.Message = ex.ToString();
            }
            return apiResult;
        }
    }
}
