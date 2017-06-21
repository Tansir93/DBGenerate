using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public  class CreateRowNameAndType
    {
        private string _rowName;

        private string _rowType;
        public string RowName
        {
            get { return _rowName; }
            set { _rowName = value; }
        }

        public string RowType
        {
            get { return _rowType; }
            set { _rowType = value; }
        }
    }
}
