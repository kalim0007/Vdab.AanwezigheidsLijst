using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Vdab.Aanwezigheidslijst.BusinessLogic.Contracts;
using Vdab.Aanwezigheidslijst.EF;
using Vdab.Aanwezigheidslijst.EF.Model;
using System.Linq;

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
        public ObservableCollection<ViewDocent> GetDocent()
        {
            ObservableCollection<ViewDocent> Docenten = new ObservableCollection<ViewDocent>();
            using (var ctx = new AanwezigheidslijstDBContext())
            {
                foreach (var docent in ctx.Docenten)
                {
                    Docenten.Add(new ViewDocent()
                    {
                        Bedrijf = docent.Bedrijf,
                        Naam = docent.Naam,
                        Id = docent.Id,
                    });
                }
            }
            return Docenten;
        }
        public void Delete(ViewDocent docent)
        {
            using (var ctx = new AanwezigheidslijstDBContext())
            {
                Docent delDocent = ctx.Docenten.SingleOrDefault(d => d.Id == docent.Id);
                ctx.Docenten.Remove(delDocent);

                ctx.SaveChanges();
            }
        }
    }
}
