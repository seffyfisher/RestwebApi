using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webApiValidation.Models;

namespace webApiValidation.Controllers
{
    public class RestController : ApiController
    {
        // GET: api/Rest
        public IHttpActionResult Get()
        {
            return Ok(RestaurantStorge.LocalRests);
        }

        // GET: api/Rest/5
        public IHttpActionResult Get(int id)
        {
            List<Restaurant> tempRest = RestaurantStorge.LocalRests;
            return Ok(tempRest.FirstOrDefault(res => res.ID == id));
                
        }

        // POST: api/Rest
        public IHttpActionResult Post([FromBody]Restaurant rest)
        {
            if (ModelState.IsValid)
            {
                RestaurantStorge.LocalRests.Add(rest);
                return Created("added new rest",rest);
            }
            else
            {
                return BadRequest();
            }
        }

        // PUT: api/Rest/5
        public IHttpActionResult Put(int id, [FromBody]Restaurant rest)
        {
            if (!(id >= 0 && id < RestaurantStorge.LocalRests.Count()))
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                RestaurantStorge.LocalRests[id] = rest;
                return Ok(rest);
            }
            else
            {
                return BadRequest();
            }

        }

        // DELETE: api/Rest/5
        public IHttpActionResult Delete(int id)
        {
            if (!(id >= 0 && id < RestaurantStorge.LocalRests.Count()))
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                Restaurant toRemove = RestaurantStorge.LocalRests.FirstOrDefault(res => res.ID == id);
                RestaurantStorge.LocalRests.Remove(toRemove);

                return Ok(toRemove);
            }
            else
            {
                return BadRequest();
            }

        }
    }
}
