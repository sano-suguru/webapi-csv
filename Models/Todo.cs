//using CsvHelper.Configuration.Attributes;

namespace WebApiCsv.Models {
  public class Todo {
    //[Name("あいでー")]
    public int ID { get; set; }
    public string Title { get; set; }
    public bool IsDone { get; set; }
  }
}
