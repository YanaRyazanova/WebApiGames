using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiApricod.Model;

namespace WebApiApricod.View
{
    public interface IView
    {
        public string ViewAllItems(ICollection<ITableItem> items);
    }
}
