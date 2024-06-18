using MysticPartyTracker.ViewModels;

namespace MysticPartyTracker.Views;

public partial class SpellView : ContentPage
{
	public SpellView()
	{
		BindingContext = new SpellViewModel();
		InitializeComponent();
	}
}