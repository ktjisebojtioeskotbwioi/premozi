using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using premozi.Models;
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
        [HttpPost(Name = "Terem_Create")]
        public JsonResult Terem_Create(Terem terem)
        {
            if (terem.Id == 0)
            {
                _context.Termek.Add(terem);
            }

            _context.SaveChanges();

            return new JsonResult(Ok(terem));

        }

        // Get
        [HttpGet(Name ="Terem_Get_By_Id")]
        public JsonResult Terem_Get_By_Id(int id)
        {
            var result = _context.Termek.Find(id);

            if (result == null)
                return new JsonResult(NotFound());

            return new JsonResult(Ok(result));
        }

        // Delete
        [HttpDelete(Name = "Terem_Delete_By_Id")]
        public JsonResult Terem_Delete_By_Id(int id)
        {
            var result = _context.Termek.Find(id);

            if (result == null)
                return new JsonResult(NotFound());

            _context.Termek.Remove(result);
            _context.SaveChanges();

            return new JsonResult(NoContent());
        }

        // Get all
        [HttpGet(Name ="Terem_Get_All")]
        public JsonResult Terem_Get_All()
        {
            var result = _context.Termek.ToList();

            return new JsonResult(Ok(result));
        }

    }
}
