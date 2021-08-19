using BMOD.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppSample.Data
{
    public static class DbInitializer
    {
        internal static void PerformInitialSetup(BMODEntityModel context)
        {
            WORKORDR wOrder = context.WORKORDRs.FirstOrDefault(w => w.WORKORDER == "12345");
            if (wOrder == null)
            {
                wOrder = new WORKORDR()
                {
                    WORKORDER = "12345",
                    DATELOGGED = DateTime.Now, 
                    COMPDATE= DateTime.Now,
                    recorddate=DateTime.Now, 
                    updatedate = DateTime.Now,
                    FieldRecorddate = DateTime.Now, 
                    FieldUpdatedate = DateTime.Now
                };
                context.WORKORDRs.Add(wOrder);
            }
            context.SaveChanges();
        }
    }
}