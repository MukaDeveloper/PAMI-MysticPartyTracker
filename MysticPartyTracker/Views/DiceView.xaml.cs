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
		string result = "Resultado = ";
		List<int> results = new Dice(sides, quantity).RollDices();
		int soma = 0;
        foreach (var item in results)
        {
			soma += item;
			result += $"{item} ";
        }
        ResultLabel.Text = $"{result}\nSoma = {soma}";
    }
}