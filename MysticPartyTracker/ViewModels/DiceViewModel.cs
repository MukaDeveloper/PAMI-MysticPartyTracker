using CommunityToolkit.Mvvm.ComponentModel;
using MysticPartyTracker.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MysticPartyTracker.ViewModels
{
    public partial class DiceViewModel : ObservableObject
    {
        public DiceViewModel() {
            RollCommand = new Command(Roll);
        }

        [ObservableProperty]
        public int _numberSides;

        [ObservableProperty]
        public int _quantity;

        [ObservableProperty]
        public int _total;

        private ObservableCollection<int> _rolls = new ObservableCollection<int>();
        public ObservableCollection<int> Rolls {
            get { return _rolls; }
            set { _rolls = value; } 
        }

        public ICommand RollCommand { get; }

        public void Roll()
        {
            Rolls.Clear();
            Total = 0;
            Dice dice = new Dice(NumberSides);
            for (int i = 0; i < Quantity; i++) //p/ cada nº sorteado, ele sorteia um nº novo
            {
                int roll = dice.Roll();
                Rolls.Add(roll);
                Total += roll;
            }
        }
    }
}
