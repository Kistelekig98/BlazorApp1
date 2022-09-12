namespace BlazorApp1.Pages;

public partial class SegmentedTest
{
  public bool FirstProperty { get; set; }
  public bool SecondProperty { get; set; }

  protected override void OnInitialized()
  {
    FirstProperty = false;
    SecondProperty = true;
  }
}
