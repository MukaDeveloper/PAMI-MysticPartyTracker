using CommunityToolkit.Mvvm.ComponentModel;
using MysticPartyTracker.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MysticPartyTracker.ViewModels;

public partial class SpellViewModel : ObservableObject
{

    private readonly RestService _restService;

	public SpellViewModel()
	{
        _restService = new RestService();
        ListarSpellAsyncCommand = new Command(async () => await ListarSpells());	
	}

    [ObservableProperty]
    private ObservableCollection<Result> _spells = new ObservableCollection<Result>();

    public ICommand ListarSpellAsyncCommand { get; }

	public async Task ListarSpells()
	{
        Spells = await _restService.GetSpellsAsync();
	}
}