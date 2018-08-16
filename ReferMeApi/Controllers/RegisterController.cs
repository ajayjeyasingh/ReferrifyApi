using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ReferMeApi.Controllers.Resources;
using ReferMeApi.Models;
using ReferMeApi.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReferMeApi.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ReferMeDbContext context;
        private readonly IMapper mapper;

        public RegisterController(ReferMeDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        /// <summary>
        /// Gets a list of all companies in the database
        /// </summary>
        /// <returns></returns>
        [HttpGet("/api/register/getCompanies")]
        public IActionResult GetCompanies()
        {
            var companies = context.Companies.ToList();

            var result = mapper.Map<List<Company>, List<CompanyResource>>(companies);

            return Ok(result);
        }

        /// <summary>
        /// Checks whether an email is already present and active in the database
        /// </summary>
        /// <param name="email">User's company email</param>
        /// <returns></returns>
        [HttpPost("/api/register/checkDuplicateEmail")]
        public IActionResult CheckDuplicateEmail([FromBody] string email)
        {
            if (String.IsNullOrEmpty(email))
                return BadRequest();

            var result = context.Emails.Where(e => e.Address.ToLower() == email.ToLower() && e.IsActive == true).Select(e => e);

            if (result.Count() > 0)
                return Ok(true);

            return Ok(false);
        }

        /// <summary>
        /// Checks whether an username is already present in the database
        /// </summary>
        /// <param name="username">Username</param>
        /// <returns></returns>
        [HttpPost("/api/register/checkDuplicateUsername")]
        public IActionResult CheckDuplicateUsername([FromBody] string username)
        {
            if (String.IsNullOrEmpty(username))
                return BadRequest();

            var result = context.Users.Where(u => u.Username.ToLower() == username.ToLower()).Select(u => u);

            if (result.Count() > 0)
                return Ok(true);

            return Ok(false);
        }
    }
}
