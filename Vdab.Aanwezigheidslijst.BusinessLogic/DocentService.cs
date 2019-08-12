using System;
using System.Collections.Generic;
using System.Text;
using Vdab.Aanwezigheidslijst.BusinessLogic.Contracts;
using Vdab.Aanwezigheidslijst.EF;
using Vdab.Aanwezigheidslijst.EF.Model;

namespace Vdab.Aanwezigheidslijst.BusinessLogic
{
   public  class DocentService
    {
        public void Create(CreateDocent docent)
        {
            using (var ctx = new AanwezigheidslijstDBContext())
            {
                ctx.Add(new Docent()
                {
                    Bedrijf = docent.Bedrijf,
                    Naam = docent.Naam
                });

                ctx.SaveChanges();
            }
        }
    }
}
