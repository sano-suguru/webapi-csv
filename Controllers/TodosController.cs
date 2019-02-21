using Microsoft.AspNetCore.Mvc;
using System;
using WebApiCsv.Services;

namespace WebApiCsv.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class TodosController : ControllerBase {
    private readonly TodoService service = new TodoService();

    [HttpGet(nameof(TodosController.Export))]
    public FileContentResult Export() {
      byte[] csvContents = service.GetCsvContents();
      string contentType = "text/csv";
      string fileName = $"ToDoList-{DateTime.Now:yyyyMMdd_HHmmss}.csv";

      return File(csvContents, contentType, fileName);
    }
  }
}
