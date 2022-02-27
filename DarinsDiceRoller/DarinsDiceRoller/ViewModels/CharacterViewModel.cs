using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DarinsDiceRoller.Models;
using MvvmHelpers;
using MvvmHelpers.Commands;
using DarinsDiceRoller.Services;

namespace DarinsDiceRoller.ViewModels
{
    public class CharacterViewModel : BaseViewModel
    {
        public ObservableRangeCollection<D20Character> Character { get; set; }
        public AsyncCommand RefreshCommand { get; }
        public AsyncCommand AddCommand { get; }
        public AsyncCommand<D20Character> RemoveCommand { get; }
        public AsyncCommand<D20Character> SelectedCommand { get; }
        public bool IsBusy { get; private set; }

        public CharacterViewModel()
        {
            Character = new ObservableRangeCollection<D20Character>();

            RefreshCommand = new AsyncCommand(Refresh);
            AddCommand = new AsyncCommand(Add);
            RemoveCommand = new AsyncCommand<D20Character>(Remove);
            
        }

        async Task Add()
        {
            var name = await App.Current.MainPage.DisplayPromptAsync("Name", "Character Name");
            var strength = await App.Current.MainPage.DisplayPromptAsync("Strength", "Character Strength");
            var dexterity = await App.Current.MainPage.DisplayPromptAsync("Dexterity", "Character Dexterity");
            var constitution = await App.Current.MainPage.DisplayPromptAsync("Constitution", "Character Constitution");
            var Intelligence = await App.Current.MainPage.DisplayPromptAsync("Intelligence", "Character Intelligence");
            var Wisdom = await App.Current.MainPage.DisplayPromptAsync("Wisdoom", "Character Wisdom");
            var Charisma = await App.Current.MainPage.DisplayPromptAsync("Charisma", "Character Charisma");
            await DiceRollerService.AddCharacter(name, Convert.ToInt32(strength), Convert.ToInt32(dexterity),
                Convert.ToInt32(constitution), Convert.ToInt32(Intelligence), Convert.ToInt32(Wisdom), Convert.ToInt32(Charisma));
            await Refresh();
        }

        
        async Task Remove(D20Character character)
        {
            await DiceRollerService.RemoveCharacter(character.CharacterId);
            await Refresh();
        }

        public async Task Refresh()
        {
            IsBusy = true;

            await Task.Delay(2000);

            Character.Clear();

            var characters = await DiceRollerService.GetCharacter();

            Character.AddRange(characters);

            IsBusy = false;
        }
    }
}
