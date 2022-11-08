using BlazorApp1.Models;

namespace BlazorApp1.Pages;

public partial class SegmentedTest
{
  public Person Person { get; set; } = new();

  protected override void OnInitialized()
  {
    Person.IsFunny = true;
    Person.IsTall = true;
  }
}
