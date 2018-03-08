using Masraf.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masraf.PL
{
    public class MasrafRepository : IMasraf<Masraflar>
    {
        MasrafTakipEntities ndata = new MasrafTakipEntities();
        public void Delete(int itemid)
        {
            ndata.Masraflar.Remove(ndata.Masraflar.Find(itemid));
            ndata.SaveChanges();
        }

        public void Insert(Masraflar item)
        {
            ndata.Masraflar.Add(item);
            ndata.SaveChanges();
        }
        //public void InsertOnay(Masraflar item,int id)
        //{
        //    ndata.Masraflar.Where(f=> f.masrafid==id).Select(f=> )
        //    ndata.SaveChanges();
        //}

        public List<Masraflar> SelecAll()
        {
            return ndata.Masraflar.Where(f => f.YetkiRol == 3).ToList();
        }
        public List<Masraflar> SelecAllBirimYön()
        {
            return ndata.Masraflar.Where(f => f.YetkiRol == 2 || f.YetkiRol ==3).ToList();
        }
        public List<Masraflar> SelecAllYön()
        {
            return ndata.Masraflar.Where(f => f.YetkiRol == 1 || f.YetkiRol == 2).ToList();
        }
        public List<Masraflar> SelecAlloff()
        {
            return ndata.Masraflar.Where(f => f.YetkiRol == 1 || f.YetkiRol == 2 || f.YetkiRol == 3).ToList();
        }

        public void Update(Masraflar item)
        {
            Masraflar guncelle = ndata.Masraflar.Find(item.masrafid);
            ndata.Entry(guncelle).CurrentValues.SetValues(item);
            ndata.SaveChanges();
        }
        public List<Masraflar> selectMasrafID(string masid)
        {
            return ndata.Masraflar.Where(f => f.MasrafSahibi == masid).ToList();
        }
    }
}
