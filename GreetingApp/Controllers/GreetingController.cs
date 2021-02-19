using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace GreetingApp.Controllers
{
    [ApiController]
    [Route("api")]
    public class GreetingController
    {
        private IItem _item;

        public GreetingController(IItem item)
        {
            _item = item;
        }

        [HttpGet("greeting")]
        public string GetWelcomeMessage()
        {
            var timeStamp = DateTime.Now;
            return timeStamp + "welcome";
        }

        [HttpGet("all")]
        public List<Item> GetItems()
        {
            return _item.GetAllItems();
        }
    }
}
