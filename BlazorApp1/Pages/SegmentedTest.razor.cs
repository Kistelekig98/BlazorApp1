namespace BlazorApp1.Pages;

public partial class SegmentedTest
{
  public bool FirstProperty { get; set; }
  public bool SecondProperty { get; set; }
  public bool Loading { get; set; } = true;

  protected override async Task OnInitializedAsync()
  {
    await Task.Delay(6000);
    FirstProperty = false;
    SecondProperty = true;
    Loading = false;
  }
}
