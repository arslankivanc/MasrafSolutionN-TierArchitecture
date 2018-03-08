using Masraf.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masraf.PL
{
    public class KisiRepo : IMasraf<Kisi>
    {
        MasrafTakipEntities ndata = new MasrafTakipEntities();
        public void Delete(int itemid)
        {
            
        }
        
        public void Insert(Kisi item)
        {
            
        }

        public List<Kisi> SelecAll()
        {
            return ndata.Kisi.ToList();
        }
        

        public void Update(Kisi item)
        {
            
        }
    }
}
