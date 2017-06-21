using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    public class CreatTableRow
    {
        private TextBox _rowName;

        private ComboBox _rowType;

        private Label _num;


        public TextBox RowName
        {
            get { return _rowName; }
            set { _rowName = value; }
        }

        public ComboBox RowType
        {
            get { return _rowType; }
            set { _rowType = value; }
        }

        public Label Num
        {
            get { return _num; }
            set { _num = value; }
        }
    }
}
