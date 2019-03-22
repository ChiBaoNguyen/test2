using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_MVC.Root.Services;
using WebAPI_MVC.Root.ViewModels;

namespace WebAPI_MVC.App.Controllers
{
    public class CategoryController : ApiController
    {
        private readonly ICategoryService _clientService;
        public CategoryController() { }

        public CategoryController(ICategoryService clientService)
        {
            _clientService = clientService;
        }

        public IHttpActionResult Post(CategoryViewModel client)
        {
            _clientService.CreateClient(client);
            return Ok();
        }
        [HttpGet]
        [Route("api/Category/Test")]
        public int Test()
        {
            var c = new CategoryViewModel();
            c.CategoryName = "Name";
            c.CategoryIsActive = "1";
            c.CategoryCreatedDate = DateTime.Now;
            _clientService.CreateClient(c);
            return 1;
        }
        [HttpGet]
        [Route("api/Category/GetAhihi")]
        public List<CategoryViewModel> Get()
        {
            return _clientService.GetListModels();
        }
    }
}
