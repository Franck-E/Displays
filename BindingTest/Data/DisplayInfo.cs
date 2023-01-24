using CommunityToolkit.Mvvm.ComponentModel;

namespace BindingTest.Data;

public class DisplayInfo : ObservableObject
{
    private string deviceName = string.Empty;
    public string DeviceName
    {
        get { return deviceName; }
        set { deviceName = value; OnPropertyChanged(nameof(DeviceName)); }
    }

    private bool primary;
    public bool Primary
    {
        get { return primary; }
        set { primary = value; OnPropertyChanged(nameof(Primary)); }
    }
}
