using Microsoft.AspNetCore.Mvc;
using SharedModelLibrary;
using System;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneralController : ControllerBase
    {
        [HttpGet]
        [Route("getmenulist")]
        public List<DrawerBindItem> GetMenuList()
        {
            List<DrawerBindItem> list = new List<DrawerBindItem>();
            list.Add(new DrawerBindItem("1", "Home", "home", "/home", "", true));
            list.Add(new DrawerBindItem("2", "Test", "drafts", "/test", "", true));
            return list;
        }
    }
}