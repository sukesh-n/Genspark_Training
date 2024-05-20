﻿using Microsoft.AspNetCore.Mvc;
using RequestTracker.Interfaces;
using RequestTracker.Models;
using UserLoginTraining1705.Exceptions;

namespace RequestTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController:ControllerBase
    {
        private readonly IEmployee _employee;

        public EmployeeController(IEmployee employee) 
        {
            _employee=employee;
        }
        [HttpPut]
        public async Task<ActionResult<Request>> AddRequest(string RequestDescription)
        {
            try
            {
                var addRequest = await _employee.AddRequest(RequestDescription);
                return Ok(addRequest);
            }
            catch (Exception ex)
            {
                throw new UnableToAddException("Cannot done");
            }
        }
    }
}
