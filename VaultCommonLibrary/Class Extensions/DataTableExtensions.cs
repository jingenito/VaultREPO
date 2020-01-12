using System.Data;
using System.Diagnostics;

namespace VaultCommonLibrary
{
    public static class DataTableExtensions
    {
        [DebuggerStepThrough]
        public static void AddColumns(this DataTable dt, params string[] columns)
        {
            foreach(string column in columns)
            {
                dt.Columns.Add(column);
            }
        }
    }
}
