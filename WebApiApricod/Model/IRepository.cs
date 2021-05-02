using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApiApricod.Model
{
    public interface IRepository
    {
        public List<ITableItem> GetAllItems();
        public bool CreateItem(ITableItem item);
        public bool UpdateItem(long idItem, string value, string fieldName);
        public bool DeleteItem(long idItem);
        public List<ITableItem> GetByParameter(string value);
        public ITableItem GenerateFromList(List<string> paramsList);
    }
}
