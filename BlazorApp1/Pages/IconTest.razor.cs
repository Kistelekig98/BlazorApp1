namespace BlazorApp1.Pages;

public partial class IconTest
{
  public bool Loading { get; set; }

  protected override async Task OnInitializedAsync()
  {
    Loading = true;
    await Task.Delay(3000);
    Loading = false;
  }
}
