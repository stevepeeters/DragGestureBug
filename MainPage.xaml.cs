using System.Windows.Input;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	private bool canDrag1;
	public bool CanDrag1
	{
		get => canDrag1;
		set
		{
			canDrag1 = value;
			OnPropertyChanged();
		}
	}

    private bool canDrag2;
    public bool CanDrag2
    {
        get => canDrag2;
        set
        {
            canDrag2 = value;
            OnPropertyChanged();
        }
    }

    public ICommand ToggleCanDrag1Command { get; }
    public ICommand ToggleCanDrag2Command { get; }

    public MainPage()
	{
        CanDrag1 = false;
        CanDrag2 = true;
		ToggleCanDrag1Command = new Command(() => CanDrag1 = !CanDrag1);
        ToggleCanDrag2Command = new Command(() => CanDrag2 = !CanDrag2);

        BindingContext = this;
        
        InitializeComponent();
	}
}

