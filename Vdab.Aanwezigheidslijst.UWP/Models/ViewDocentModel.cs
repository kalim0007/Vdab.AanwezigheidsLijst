using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Vdab.Aanwezigheidslijst.BusinessLogic;
using Vdab.Aanwezigheidslijst.BusinessLogic.Contracts;

namespace Vdab.Aanwezigheidslijst.UWP.Models
{
    public class ViewDocentModel
    {
        private readonly DocentService _docentService = new DocentService();
        public readonly ViewDocent Docent = new ViewDocent();
        public void DeleteDocent(ViewDocent docent)
        {
            _docentService.Delete(docent);
        }
        public ObservableCollection<ViewDocent> GetDocent()
        {
           return _docentService.GetDocent();
        }
    }
}
