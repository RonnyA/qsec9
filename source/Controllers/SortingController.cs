﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace qsec9.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SortingController : ControllerBase
    {
        [HttpPost]
        [ActionName("numbersort")]
        public ContentResult NumberSort(List<int> list)
        {
            list.Sort();
            return Content(JsonConvert.SerializeObject(list));
        }
    }
}