using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyInstaPrepAPI.Models;
using AutoPoco;
using AutoPoco.DataSources;
using AutoPoco.Engine;

namespace MyInstaPrepAPI.Controllers
{
    public class DefaultController : ApiController
    {
        private IList<User> LocalUsers;

        public DefaultController()
        {
            IGenerationSessionFactory factory = AutoPocoContainer.Configure(x =>
            {
                x.Conventions(c => { c.UseDefaultConventions(); });
                x.AddFromAssemblyContainingType<User>();
                x.Include<User>()
                    .Setup(u => u.Id).Use<DefaultIntegerSource>()
                    .Setup(u => u.FirstName).Use<FirstNameSource>()
                    .Setup(u => u.LastName).Use<LastNameSource>()
                    .Setup(u => u.Email).Use<EmailAddressSource>();
            });

            IGenerationSession Session = factory.CreateSession();

            LocalUsers = Session.List<User>(50).Get();
        }

        public List<User> GetUsers()
        {
            return LocalUsers.ToList();
        }

        public User GetUser(int id)
        {
            return LocalUsers.Where(x => x.Id == id).Select(x => x).First();
        }
    }
}
