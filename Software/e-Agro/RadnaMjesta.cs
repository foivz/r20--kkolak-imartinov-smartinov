﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agro
{
    public class RadnaMjesta
    {
        public List<radno_mjesto> DohvatiRadnaMjesta()
        {
            using (var context = new PI20_024_DBEntities())
            {
                var query = from rad in context.radno_mjesto.Include("korisniks").Include("skladiste").Include("ured")
                            select rad;
                return query.ToList();
            }
        }
    }
}
