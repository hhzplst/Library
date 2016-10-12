using System;
using System.Collections.Generic;

namespace Library {
  public class Library {
    public List<Book> books = new List<Book>();
    public void SearchBySubject(string subject) {
      foreach (Book b in books) {
        if (b.subjectHeadings.IndexOf(subject) != -1)
          PrintBookInfo(b);
      }
    }
    public void PrintBookInfo(Book b) {
      Console.WriteLine("Title: {0}\nLibrary of Congress #: {1}\n", b.Title, b.LCNumber);
    }
  }
}