using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vdab.Aanwezigheidslijst.UWP.Models;
using System.Collections.ObjectModel;
using Vdab.Aanwezigheidslijst.UWP.Commands;
using System.Windows.Input;
using System.Threading.Tasks;
using Vdab.Aanwezigheidslijst.BusinessLogic.Contracts;

namespace Vdab.Aanwezigheidslijst.UWP.ViewModels
{
    public class ViewDocentViewModel : BaseViewModel<ViewDocentModel>
    {
        public readonly ICommand DeleteCommand;

        ObservableCollection<ViewDocent> _Docenten;
        public ViewDocentViewModel() : base(new ViewDocentModel())
        {
            DeleteCommand = new RelayCommand(() => DeleteDocent());
            _Docenten = new ObservableCollection<ViewDocent>();
            GetDocent();
        }
        private ViewDocent _selectedDocent;
        public ViewDocent SelectedDocent
        {
            get => _selectedDocent;
            set => SetProperty(ref _selectedDocent, value);
        }
        private void DeleteDocent()
        {

            Model.DeleteDocent(SelectedDocent);
            GetDocent();
        }
        public void GetDocent()
        {
            _Docenten = Model.GetDocent();
        }
        public ObservableCollection<ViewDocent> Docenten
        {
            get => _Docenten;
            set => SetProperty(ref _Docenten, value);
        }
        public string Naam
        {
            get => Model.Docent.Naam;
            set => SetProperty(Model.Docent.Naam, value, () => Model.Docent.Naam = value);

        }

        public string Bedrijf
        {
            get => Model.Docent.Bedrijf;
            set => SetProperty(Model.Docent.Bedrijf, value, () => Model.Docent.Bedrijf = value);

        }
        public int Id
        {
            get => Model.Docent.Id;
            set => SetProperty(Model.Docent.Id, value, () => Model.Docent.Id = value);

        }
    }
}
