using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDN_LOGTEST
{
    /// <summary>
    /// 
    /// </summary>
    public partial class SEARCH_S : Form
    {
        #region "Khởi tạo"
        /// <summary>
        /// 
        /// </summary>
        public GDNdatabase.GDNDB DataSource;
        /// <summary>
        /// 
        /// </summary>
        public DataTable dtSource;
        /// <summary>
        /// 
        /// </summary>
        public DataTable dtTemp;
        //-------------------------------------------------------------------
        #endregion

        #region "Main"
        /// <summary>
        /// 
        /// </summary>
        public SEARCH_S()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        public SEARCH_S(DataTable dtsource, string searchKey)
        {
            InitializeComponent();
            this.dtSource = dtsource;
            SEARCH.Text = searchKey;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SEARCH_S_Shown(object sender, EventArgs e)
        {
            DGV_ACCOUNT.Columns.Clear();
            foreach (DataColumn col in dtSource.Columns)
            {
                string colName = col.ColumnName;
                DGV_ACCOUNT.Columns.Add(colName, colName);
                DGV_ACCOUNT.Columns[colName].DataPropertyName = colName;
            }
            //-------------------------------------------------------------------
            DGV_ACCOUNT.DataSource = this.dtSource;
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGV_ACCOUNT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            //-------------------------------------------------------------------
            dtTemp = dtSource.Clone();
            dtTemp.Rows.Clear();
            dtTemp.Rows.Add(dtTemp.NewRow());
            //-------------------------------------------------------------------
            foreach (DataGridViewColumn dc in DGV_ACCOUNT.Columns)
            {
                dtTemp.Rows[0][dc.DataPropertyName] =
                    DGV_ACCOUNT.Rows[rowIndex].Cells[dc.Name].Value.ToString();
            }
            //-------------------------------------------------------------------
            this.Close();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_KEY_OK_Click(object sender, EventArgs e)
        {

        }
    }
}
