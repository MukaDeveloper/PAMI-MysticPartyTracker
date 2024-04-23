using MysticPartyTracker.Models;

namespace MysticPartyTracker.View;

public partial class DiceView : ContentPage
{
	public DiceView()
	{
		InitializeComponent();
		QuantityPicker.SelectedIndex = 0;
		SidesPicker.SelectedIndex = 0;
	}

    private void RollButtons_Clicked(object sender, EventArgs e)
    {
		int quantity = (int) QuantityPicker.SelectedItem;
		int sides = (int) SidesPicker.SelectedItem;
		ResultLabel.Text = new Dice(sides).Roll().ToString();
    }
}