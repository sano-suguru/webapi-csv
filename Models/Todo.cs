using CsvHelper.Configuration.Attributes;

namespace WebApiCsv.Models {
  public class Todo {
    public int ID { get; set; }

    [Name("タイトル")]
    public string Title { get; set; }

    [Name("済")]
    public bool IsDone { get; set; }
  }
}
