using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masraf.PL
{
    public interface IMasraf<T>
    {
        void Insert(T item);
        void Update(T item);
        void Delete(int itemid);
        List<T> SelecAll();
    }
}
