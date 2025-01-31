using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using premozi.Models;
using premozi.Data;
using System;

namespace premozi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class terem_Controller : ControllerBase
    {
        private readonly ApiContext _context;

        public terem_Controller(ApiContext context)
        {
            _context = context;
        }

        // Create/Edit
        [HttpPost]
        public JsonResult Create(Terem terem)
        {
            if (terem.Id == 0)
            {
                _context.Termek.Add(terem);
            }

            _context.SaveChanges();

            return new JsonResult(Ok(terem));

        }

        // Get
        [HttpGet]
        public JsonResult Get(int id)
        {
            var result = _context.Termek.Find(id);

            if (result == null)
                return new JsonResult(NotFound());

            return new JsonResult(Ok(result));
        }

        // Delete
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            var result = _context.Termek.Find(id);

            if (result == null)
                return new JsonResult(NotFound());

            _context.Termek.Remove(result);
            _context.SaveChanges();

            return new JsonResult(NoContent());
        }

        // Get all
        [HttpGet()]
        public JsonResult GetAll()
        {
            var result = _context.Termek.ToList();

            return new JsonResult(Ok(result));
        }

    }
}
