using System;
using System.Collections.Generic;
using Vdab.Aanwezigheidslijst.EF;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace Vdab.Aanwezigheidslijst.BusinessLogic
{
    public class ApplicationBootstrap
    {
        public static void Initialize()
        {
            using (var ctx = new AanwezigheidslijstDBContext())
            {
                ctx.Database.Migrate();
            }
        }
    }
}
