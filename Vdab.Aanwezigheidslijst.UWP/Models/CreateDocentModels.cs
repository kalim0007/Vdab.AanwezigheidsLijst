using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vdab.Aanwezigheidslijst.BusinessLogic;
using Vdab.Aanwezigheidslijst.BusinessLogic.Contracts;

namespace Vdab.Aanwezigheidslijst.UWP.Models
{
    class CreateDocentModels
    {
        private readonly DocentService _docentService = new DocentService();
        public readonly CreateDocent Docent = new CreateDocent();

        public void CreateDocent()
        {
            _docentService.Create(Docent);
        }
    }
}
