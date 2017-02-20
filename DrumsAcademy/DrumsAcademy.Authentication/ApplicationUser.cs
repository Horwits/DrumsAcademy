using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;

using DrumsAcademy.Models;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DrumsAcademy.Authentication
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            this.Resources = new HashSet<Resource>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required]
        public byte[] Image { get; set; }

        public virtual IEnumerable<Resource> Resources { get; set; }

        public DateTime RegisteredDate
        {
            get
            {
                return DateTime.Now;
            }
        }

        public ClaimsIdentity GenerateUserIdentity(ApplicationUserManager manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = manager.CreateIdentity(this, DefaultAuthenticationTypes.ApplicationCookie);

            // Add custom user claims here
            return userIdentity;
        }

        public Task<ClaimsIdentity> GenerateUserIdentityAsync(ApplicationUserManager manager)
        {
            return Task.FromResult(this.GenerateUserIdentity(manager));
        }
    }
}