using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Emanager.Core;
using Emanager.Web.Infrastructure;

namespace Emanager.Web.Controllers
{
    public class EmanagerWebApiController : ApiController
    {
        private DepartmentDb db;

        public EmanagerWebApiController()
        {
            db = new DepartmentDb();
            db.Configuration.ProxyCreationEnabled = false;
        }
        // GET api/emanagerwebapi
        public IEnumerable<Department> GetAllDepartments()
        {
            //return new string[] { "value1", "value2" };
            return db.Departments;
        }

        // GET api/emanagerwebapi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/emanagerwebapi
        //public void Post([FromBody]string value)
        //{
        //}
        public string Post(Department dept)
        {
            return "value" + "  " + dept.Name.ToString();
        }

        // PUT api/emanagerwebapi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/emanagerwebapi/5
        public void Delete(int id)
        {
        }
    }
}
