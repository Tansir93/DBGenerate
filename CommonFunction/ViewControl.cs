using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonFunction
{
    public class ViewControl
    {
        private static void DataSourceBind<T>(T Model, List<CreateRowNameAndType> list) where T : ListControl
        {
            Model.DataSource = null;
            Model.DataSource = new List<CreateRowNameAndType>(list);
            Model.ValueMember = "RowName";
            Model.DisplayMember = "RowName";
        }
    }
}
