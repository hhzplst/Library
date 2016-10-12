using System.Collections.Generic;

namespace Library {
  public class Book {
    public int YearOfPublication {get; set;}
    public string Title {get; set;}
    public string LCNumber {get; set;}
    public string Publisher {get; set;}
    public List<string> authors;
    public List<string> subjectHeadings;
    public bool Circulating {get; set;}
  }
}