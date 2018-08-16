using Microsoft.AspNetCore.Mvc;
using ReferMeApi.Helpers;
using ReferMeApi.Models;
using ReferMeApi.Models.DTOs;
using ReferMeApi.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReferMeApi.Controllers
{
    public class UsersController : Controller
    {
        private readonly ReferMeDbContext context;

        public UsersController(ReferMeDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Adds a user to the database
        /// </summary>
        /// <param name="user">User DTO</param>
        /// <returns></returns>
        [HttpPost("/api/users")]
        public async Task<IActionResult> AddUser([FromBody] AddUserRequestDTO user)
        {
            // Return 400 Bad Request if AddUserRequestDTO validations fail
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                // Return 400 Bad Request if user email is already present and active in the database
                var emailResult = context.Emails.Where(e => e.Address.ToLower() == user.Email.ToLower() && e.IsActive == true).Select(e => e);

                if (emailResult.Count() > 0)
                    return BadRequest();

                // Return 400 Bad Request if username is already present and active in the database
                var usernameResult = context.Users.Where(u => u.Username.ToLower() == user.Username.ToLower()).Select(u => u);

                if (usernameResult.Count() > 0)
                    return BadRequest();


                // Generate PBKDH2 hash of the plain password with a salt and store it in the Password table

                string salt = PasswordHelper.GenerateRandomSalt(16);

                string passwordHash = PasswordHelper.ComputePbkdf2Hash(user.Password, salt);

                Password pass = new Password
                {
                    PasswordHash = passwordHash,
                    Salt = salt
                };

                context.Add(pass);

                // Add an entry to the Emails table

                string verificationCode = RandomStringHelper.GenerateRandomString(16);

                Email emailAddress = new Email
                {
                    Address = user.Email,
                    IsActive = false,
                    VerificationCode = verificationCode
                };

                context.Add(emailAddress);

                await context.SaveChangesAsync();

                // Add the user to the Users table

                User newUser = new User
                {
                    Username = user.Username,
                    PasswordId = pass.Id,
                    EmailId = emailAddress.Id,
                    CompanyId = user.CompanyId,
                    UserRoleId = (int)UserRoles.Member,
                    UserStatusId = (int)UserStatuses.AccountVerificationPending
                };

                context.Add(newUser);

                await context.SaveChangesAsync();

                // Send account verification email

                EmailHelper.SendAccountVerficationEmail(emailAddress.Address, verificationCode);
            }

            catch(Exception e)
            {
                return Ok(false);
            }

            return Ok(true);
        }

    }
}
