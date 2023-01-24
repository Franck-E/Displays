using System.Collections.ObjectModel;
using WindowsDisplayAPI;

namespace BindingTest.Data;

public class DisplayService
{
    public ObservableCollection<DisplayInfo> ScreenCollection { get; set; } = new();

    public DisplayService()
    {
        foreach (Display display in Display.GetDisplays())
        {
            ScreenCollection.Add(new DisplayInfo
            {
                DeviceName = display.DisplayName,
                Primary = display.IsGDIPrimary,
            });
        }
    }
}