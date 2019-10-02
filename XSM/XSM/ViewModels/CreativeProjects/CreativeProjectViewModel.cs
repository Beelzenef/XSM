using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XSM.Models;
using XSM.Services.Characters;
using XSM.ViewModels.Base;

namespace XSM.ViewModels.CreativeProjects
{
    public class CreativeProjectViewModel : BaseViewModel
    {
        private CreativeProject _project;
        public CreativeProject Project
        {
            get { return _project; }
            set { SetProperty(ref _project, value); }
        }

        private ICollection<CharacterEntity> _characters;
        public ICollection<CharacterEntity> Characters
        {
            get { return _characters; }
            set { SetProperty(ref _characters, value); }
        }

        public ICommand BackToProjectsCommand { get; private set; }

        private readonly ICharacterService _characterService;

        public CreativeProjectViewModel() { }
        public CreativeProjectViewModel(CreativeProject project)
        {
            Project = project;

            _characterService = new CharacterService();

            LoadData();

            BackToProjectsCommand = new Command(async () => await BackToProjectsExecute());
        }

        private void LoadData()
        {
            Characters = _characterService.GetCharacters(Project.Id);
        }

        private async Task BackToProjectsExecute()
        {
            await _navigationService.GoBack();
        }
    }
}
