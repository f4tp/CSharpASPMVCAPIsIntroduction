using Demo_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Demo_API.Controllers
{
    /// <summary>
    /// This is a specification comment for the PeopleController
    /// Edit me to make sure people know what this API controller is for
    /// </summary>
    public class PeopleController : ApiController
    {
        public List<Person> people = new List<Person>();
        
        /// <summary>
        /// the constructor method specification
        /// </summary>
        public PeopleController()
        {
            //acts as if you have made a call to a database, and loaded the items into a list
            people.Add(new Person { FirstName = "Tim", LastName = "Corey", Id = 1 });
            people.Add(new Person { FirstName = "Sue", LastName = "Storm", Id = 2 });
            people.Add(new Person { FirstName = "Bilbo", LastName = "Baggins", Id = 3 });
        }
        
        /// <summary>
        /// get firstnames only as a list
        /// </summary>
        /// <returns>List type C# object</returns>
       [Route("api/People/GetFirstNames/")]//this route is only for the method directly under it
        //[Route("api/People/GetFirstNames")]
        //can do the above but goes against RESTful convention
           [HttpGet] //only allows Get requests, not Post requests for example
        //[HttpGet,HttpPost]
        // GetFirstNames: api/People/GetFirstNames
        public List<String> GetFirstNames()
        {
            List<String> output = new List<string>();
            foreach (var p in people)
            {
                output.Add(p.FirstName);
            }
            return output;
        }
        /// <summary>
        /// Pass an ID and an age, it will update the age of the person, and Returns their first name as a list (which is illogical and would need changing out later, but keeping as it overloads a given method)
        /// </summary>
        /// <param name="userId"></param> Unique identifier for the user - passed in
        /// <param name="age"></param> - the age of the user - passed in
        /// <returns>A list fo first names</returns>

        [Route("api/People/GetFirstNames/{userId:Int}/{age:int}")]
        [HttpGet]
        public List<String> GetFirstNames(int userId, int age)
        {
            List<String> output = new List<string>();
            foreach (var p in people)
            {
                if (p.Id == userId)
                {
                    p.Age = age;
                    output.Add(p.FirstName);
                }
            }
            return output;
        }

        // GET: api/People
        public List<Person> Get()
        { 
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            //only if the id is valid, i.e. that id exists
            return people.Where(x=> x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person val)
        {
          people.Add(val);
                      
        }

        /*
        // PUT: api/People/5
        public void Put(int id, [FromBody]string value)
        {
        }
        */

        // DELETE: api/People/5
        public void Delete(int id)
        {
        
        }
    }
}
