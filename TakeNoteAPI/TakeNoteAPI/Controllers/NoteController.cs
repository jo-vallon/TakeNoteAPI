using System;
using Microsoft.AspNetCore.Mvc;

namespace TakeNoteAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NoteController : ControllerBase
    {
        [HttpGet("GetTestResponse")]
        public string GetTestResponse()
        {
            return "Response has been recieved";
        }
	}
}

