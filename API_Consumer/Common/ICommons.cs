using System;
using System.Windows.Forms;

namespace API_Consumer.Common
{
    public interface ICommons
    {
        void copyAlltoClipboard(DataGridView dgv);
        void saveToExcel(DataGridView dgv);
        void showRightMenu(object sender, DataGridViewCellMouseEventArgs e);
        string FromUnixTime(long unixTime);
        string ParsePGN(string json);
    }
}
