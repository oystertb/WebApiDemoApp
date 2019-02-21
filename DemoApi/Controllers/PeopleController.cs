using DemoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoApi.Controllers
{
    /// <summary>
    /// This is where I give you all the information about my people
    /// </summary>
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { Id = 1, FirstName="Selen", LastName="Rickman" });
            people.Add(new Person { Id = 2, FirstName = "Selin ", LastName = "Özek" });
            people.Add(new Person { Id = 3, FirstName = "Mürşide", LastName = "Özek" });
            people.Add(new Person { Id = 4, FirstName = "Chris", LastName = "Rickman" });
            people.Add(new Person { Id = 5, FirstName = "Muzaffer", LastName = "Özek" });

        }

        /// <summary>
        /// This takes two parameters. bla bla
        /// </summary>
        /// <param name="userId">This is user id</param>
        /// <param name="age"></param>
        /// <returns>returns sth</returns>
        [Route("api/People/GetFirstNames/{userId:int}/{age:int}")]
        [HttpGet]
        public List<string> GetFirstNames(int userId, int age)
        {
            List<string> firstNames = new List<string>();

            foreach (var p in people)
            {
                firstNames.Add(p.FirstName);
            }
            return firstNames;
        }

        [Route("api/People/GetLastNames")]
        [HttpGet]
        public List<string> GetLastNames()
        {
            List<string> lastNames = new List<string>();

            foreach (var p in people)
            {
                lastNames.Add(p.LastName);
            }
            return lastNames;
        }
        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault(); //Lambda Expression
        }

        // POST: api/People
        public void Post(Person pVal)
        {
            people.Add(pVal);
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
