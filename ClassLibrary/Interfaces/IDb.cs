using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Interfaces
{
    public interface IDb
    {
        public IItem GetItem(string name);

        public IItem AddItem(IItem itemToAdd);

        public void AddLogRecord(string message);
    }
}
