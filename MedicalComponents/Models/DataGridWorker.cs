using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalComponents.Models
{
    class DataGridWorker
    {
        public static void FillDataGrid(DataGridView dataGridView, IEnumerable<object> query, Dictionary<string,string> replaceCollumns)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = query;

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                var headerCollumnName = dataGridView.Columns[i].HeaderText;
                if (replaceCollumns.Keys.Contains(headerCollumnName))
                    dataGridView.Columns[i].HeaderText = replaceCollumns[headerCollumnName];
            }
            if(dataGridView.Columns.Count > 0)
                dataGridView.Columns[0].Visible = false; // to hide the main ID

        }
    }
}
