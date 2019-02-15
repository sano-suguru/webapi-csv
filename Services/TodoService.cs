using CsvHelper;
using System.IO;
using WebApiCsv.Data;

namespace WebApiCsv.Services {
  public class TodoService {
    // サンプルなので DI はせず直接 new しちゃう
    private readonly TodoRepository repository = new TodoRepository();

    public byte[] GetCsv() {
      var todos = repository.List();

      using (var memory = new MemoryStream())
      using (var writer = new StreamWriter(memory))
      using (var csv = new CsvWriter(writer)) {
        //csv.Configuration.ShouldQuote = (field, context) => true;
        csv.WriteRecords(todos);
        writer.Flush();
        return memory.ToArray();
      }
    }
  }
}
