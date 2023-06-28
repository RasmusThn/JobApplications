using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplications
{
    public class ColumnComparer : IComparer
    {
        private int columnIndex;

        public ColumnComparer(int columnIndex)
        {
            this.columnIndex = columnIndex;
        }

        public int Compare(object x, object y)
        {
            ListViewItem itemX = (ListViewItem)x;
            ListViewItem itemY = (ListViewItem)y;

            string textX = itemX.SubItems[columnIndex].Text;
            string textY = itemY.SubItems[columnIndex].Text;

            // Perform the comparison based on the column index
            // Here, we assume that the column contains string values
            return string.Compare(textX, textY);
        }
    }
}
