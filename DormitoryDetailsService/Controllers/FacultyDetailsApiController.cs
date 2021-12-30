using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace DormitoryDetailsService.Controllers
{
    [Route("[controller]")]
    public class FacultyDetailsApiController : Controller
    {
        private readonly List<DormitoryInfoModel> DataCosts = new List<DormitoryInfoModel>
        {
            new DormitoryInfoModel()
            {
                Number = "1",
                Cost = 600
            },
            new DormitoryInfoModel()
            {
                Number = "2",
                Cost = 700
            },
            new DormitoryInfoModel()
            {
                Number = "3",
                Cost = 800
            }
        };
        
        private readonly List<DormitoryInfoDescriptionModel> DataDescriptions = new List<DormitoryInfoDescriptionModel>
        {
            new DormitoryInfoDescriptionModel()
            {
                Number = "1",
                Description = "Lorem ipsum la-la-la-la-la-la1"
            },
            new DormitoryInfoDescriptionModel()
            {
                Number = "2",
                Description = "Lorem ipsum la-la-la-la-la-la2"
            },
            new DormitoryInfoDescriptionModel()
            {
                Number = "3",
                Description = "Lorem ipsum la-la-la-la-la-la3"
            }
        };
        
        [HttpGet]
        [Route("get-costs")]
        public IActionResult GetCosts()
        {
            return Ok(DataCosts);
        }
        
        [HttpGet("get-description/{Number}")]
        [Route("get-description")]
        public IActionResult GetDescriptions([FromRoute] string number)
        {
            return Ok(DataDescriptions.FirstOrDefault(x => x.Number == number)?.Description);
        }
    }

    internal class DormitoryInfoDescriptionModel
    {
        public string Number { get; set; }
        
        public string Description { get; set; }
    }

    internal class DormitoryInfoModel
    {
        public string Number { get; set; }
        
        public int Cost { get; set; }
    }
}