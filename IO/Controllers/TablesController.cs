﻿namespace IO.Controllers
{
    using IO.Model.Tables;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    [Route("/tables")]
    public class TablesController : Controller
    {

        [HttpGet]
        public IEnumerable<TableEntity> GetTables()
        {





            return null;
        }
    }
}
