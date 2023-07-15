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
        public int ColumnIndex { get; set; }
        public bool IsDescending { get; set; }

        public ColumnComparer(int columnIndex, bool isDescending)
        {
            ColumnIndex = columnIndex;
            IsDescending = isDescending;
        }

        public int Compare(object x, object y)
        {
            ListViewItem itemX = (ListViewItem)x;
            ListViewItem itemY = (ListViewItem)y;

            string textX = itemX.SubItems[ColumnIndex].Text;
            string textY = itemY.SubItems[ColumnIndex].Text;

            // Perform the comparison based on the column index and sort order
            if (ColumnIndex == 0) // Assuming columnIndex 0 corresponds to the "Id" column
            {
                int intX = int.Parse(textX);
                int intY = int.Parse(textY);
                return IsDescending ? intY.CompareTo(intX) : intX.CompareTo(intY);
            }
            else if (ColumnIndex == 4) // Assuming columnIndex 4 corresponds to the "ApplyDate" column
            {
                DateTime dateX = DateTime.Parse(textX);
                DateTime dateY = DateTime.Parse(textY);
                return IsDescending ? dateY.CompareTo(dateX) : dateX.CompareTo(dateY);
            }
            else
            {
                return IsDescending ? string.Compare(textY, textX) : string.Compare(textX, textY);
            }
        }
    }

}
