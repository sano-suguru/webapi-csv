using Microsoft.AspNetCore.Mvc;
using System;
using WebApiCsv.Services;

namespace WebApiCsv.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class TodosController : ControllerBase {
    // サンプルなので DI はしないで直接 インスタンスを持っちゃう
    private readonly TodoService service = new TodoService();

    // GET api/values
    [HttpGet]
    public FileContentResult Export() {
      var csv = service.GetCsv();
      var fileName = $"ToDoList-{DateTime.Now:yyyyMMdd_HHmmss}.csv";
      return File(csv, "text/csv", fileName);
    }
  }
}
