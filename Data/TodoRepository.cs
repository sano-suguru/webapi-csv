using System.Collections.Generic;
using WebApiCsv.Models;

namespace WebApiCsv.Data {
  public class TodoRepository {
    // ダミーデータ
    private static List<Todo> DummyTodos { get; } = new List<Todo> {
      new Todo { ID = 1, Title = "CSV返却の記事", IsDone = false },
      new Todo { ID = 2, Title = "IoCの記事", IsDone = false },
    };

    public List<Todo> List() => DummyTodos;
  }
}
