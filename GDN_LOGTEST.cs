using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/******************************************************************************
 * Author               :   GIDEON                                            *
 ******************************************************************************
 * Create date          :   20220801                                          *
 * Last moditify date   :   20220804                                          *
 *****************************************************************************/

namespace GDN_LOGTEST
{
    /// <summary>
    /// 
    /// </summary>
    public partial class LOGTEST_F : Form
    {
        #region "KHởi tạo"

        public string ServerName;
        //-------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        public string DbName;
        //-------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        public string TableName;
        //-------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        public GDNdatabase.GDNDB DataSource;
        //-------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        public GDN_MODE.GDN_MODE GDNMODE;
        //-------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        public DataTable dtSource;
        //-------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        public DataTable dtTemp;
        //-------------------------------------------------------------------
        /// <summary>
        /// Mode thay đổi data
        /// </summary>
        /// <remarks>
        ///     value = "1": Insert
        ///     value = "2": Update
        ///     value = "3": Delete
        ///     value = "4": View
        ///     ...
        /// </remarks>

        public SEARCH_S SearchForm;
        #endregion

        #region "Main"
        //-------------------------------------------------------------------
        /// <summary>
        /// Init
        /// </summary>
        public LOGTEST_F()
        {
            InitializeComponent();
        }
        //-------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LOGTEST_F_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        //-------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LOGTEST_F_Shown(object sender, EventArgs e)
        {
            B_MODE.PerformClick();
        }
        //-------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        public void LoadData()
        {
            ServerName = "(local)";
            DbName = "TEST";
            TableName = "LOGTEST";
            DataSource = new GDNdatabase.GDNDB(ServerName, DbName);
            dtSource = new DataTable();
            dtTemp = new DataTable();
            SearchForm = new SEARCH_S();
            //-------------------------------------------------------------------
            DataSource.Connect();
            //-------------------------------------------------------------------
            dtSource = DataSource.GetDataTable(TableName, "");
            //-------------------------------------------------------------------
            DataSource.Disconnect();
            //-------------------------------------------------------------------
            ClearTextAll();
            GotoKey();
        }
        /// <summary>
        /// tìm một hàng có các điều kiện trong G_KEY
        /// </summary>
        /// <returns>số hàng trong bảng</returns>
        public int GetDataDB()
        {
            DataSource.Connect();
            //-------------------------------------------------------------------
            StringBuilder SqlQuery = new StringBuilder();
            System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
            System.Data.SqlClient.SqlCommand SqlCmd = new System.Data.SqlClient.SqlCommand();
            //-------------------------------------------------------------------
            SqlQuery.Append("SELECT ");
            SqlQuery.Append(" LT.USERNAME AS USERNAME");
            SqlQuery.Append(",LT.PASSWORD AS PASSWORD");
            //-------------------------------------------------------------------
            SqlQuery.Append(" FROM");
            SqlQuery.Append(" LOGTEST LT");
            //-------------------------------------------------------------------
            SqlQuery.Append(" WHERE");
            SqlQuery.AppendFormat(" LT.USERNAME = '{0}'", USERNAME.Text);
            //-------------------------------------------------------------------
            SqlCmd.CommandText = SqlQuery.ToString();
            SqlCmd.Connection = DataSource.SQLconn;
            SqlCmd.ExecuteNonQuery();
            //-------------------------------------------------------------------
            da.SelectCommand = SqlCmd;
            dtSource.Clear();
            da.Fill(dtSource);
            //-------------------------------------------------------------------
            DataSource.Disconnect();
            //-------------------------------------------------------------------
            return dtSource.Rows.Count;    //chỉ lấy 1 hàng
        }
        //-------------------------------------------------------------------
        #endregion

        #region "Check"
        /// <summary>
        /// Check dữ liệu nhập phần key
        /// </summary>
        /// <returns></returns>
        public bool CheckKey()
        {
            if(CheckKeyRefer() == false)
                return false;

            if (CheckKeyRequire() == false)
                return false;

            return true;
        }
        //-------------------------------------------------------------------
        /// <summary>
        /// Check điều kiện trong database
        /// </summary>
        /// <returns></returns>
        public bool CheckKeyRefer()
        {
            return true;
        }
        //-------------------------------------------------------------------
        /// <summary>
        /// check điều kiện bắt buộc nhập (không được để trống) trong textbox
        /// </summary>
        /// <returns></returns>
        public bool CheckKeyRequire()
        {
            if (USERNAME.Text == "")
                return false;

            return true;
        }
        //-------------------------------------------------------------------
        /// <summary>
        /// Check dữ liệu nhập phần data
        /// </summary>
        /// <returns></returns>
        public bool CheckData()
        {
            if (CheckDataRefer() == false)
                return false;

            if (CheckDataRequire() == false)
                return false;

            return true;
        }
        //-------------------------------------------------------------------
        /// <summary>
        /// Check điều kiện trong database
        /// </summary>
        /// <returns></returns>
        public bool CheckDataRefer()
        {
            return true;
        }
        //-------------------------------------------------------------------
        /// <summary>
        /// check điều kiện bắt buộc nhập (không được để trống) trong textbox
        /// </summary>
        /// <returns></returns>
        public bool CheckDataRequire()
        {
            if (PASSWORD.Text == "")
                return false;

            return true;
        }
        #endregion

        #region "Control"
        /// <summary>
        /// Đặt các giá trị trong textbox về ""
        /// </summary>
        /// <param name="control"></param>
        public void ClearText(GroupBox control)
        {
            foreach (Control textBox in control.Controls.OfType<TextBox>())
            {
                textBox.Text = "";
            }
        }
        //-------------------------------------------------------------------
        /// <summary>
        /// xóa hết giá trị trong text box trong form
        /// </summary>
        public void ClearTextAll()
        {
            ClearText(G_KEY);
            ClearText(G_DATA);
        }
        //-------------------------------------------------------------------
        /// <summary>
        /// Focus vào text box đầu tiên trong G_KEY
        /// </summary>
        public void GotoKey()
        {
            G_KEY.Enabled = false;
            G_DATA.Enabled = false;
            P_CONTROLS_DATA.Enabled = false;
            //-------------------------------------------------------------------
            G_KEY.Enabled = true;
            //-------------------------------------------------------------------
            USERNAME.Select();
        }
        //-------------------------------------------------------------------
        /// <summary>
        /// Focus vào text box đầu tiên trong G_DATA
        /// </summary>
        public void GotoData()
        {
            G_KEY.Enabled = false;
            G_DATA.Enabled = false;
            P_CONTROLS_DATA.Enabled = false;
            //-------------------------------------------------------------------
            G_DATA.Enabled = true;
            P_CONTROLS_DATA.Enabled = true;
            //-------------------------------------------------------------------
            PASSWORD.Select();
        }
        //-------------------------------------------------------------------
        /// <summary>
        /// tải dữ liệu vòa các text box trong control
        /// </summary>
        /// <param name="control"></param>
        public void LoadData(GroupBox control, string conditions)
        {
            dtSource = DataSource.GetDataTable("LOGTEST", conditions);
            //-------------------------------------------------------------------
            if(dtSource.Rows.Count != 1)
            {
                return;
            }    
            //-------------------------------------------------------------------
            FillData(G_DATA, dtSource);
        }
        /// <summary>
        /// đổ data vào các text box trên màn hình
        /// </summary>
        /// <param name="control"></param>
        /// <param name="dt"></param>
        public void FillData(GroupBox control, DataTable dt)
        {
            if(dt.Rows.Count == 0)
            {
                return;
            }    
            //-------------------------------------------------------------------
            foreach (Control textBox in control.Controls.OfType<TextBox>())
            {
                textBox.Text = dt.Rows[0][textBox.Name].ToString();
            }
        }
        #endregion

        #region "Form events"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_MODE_Click(object sender, EventArgs e)
        {
            GDNMODE = new GDN_MODE.GDN_MODE();
            GDNMODE.ShowDialog();
            //-------------------------------------------------------------------
            B_MODE.Text = GDNMODE.ModeView;
        }
        #endregion

        #region "G_KEY events"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_GDNLOGTEST_SEARCH_Click(object sender, EventArgs e)
        {
            SearchForm = new SEARCH_S(dtSource, USERNAME.Text);
            SearchForm.ShowDialog();
            //-------------------------------------------------------------------
            if(SearchForm.dtTemp == null)
            {
                return;
            }
            //-------------------------------------------------------------------
            USERNAME.Text = SearchForm.dtTemp.Rows[0][USERNAME.Name].ToString();
        }
        //-------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_OK_KEY_Click(object sender, EventArgs e)
        {
            if(CheckKey() == false)
            {
                return;
            }
            dtSource.Clear();
            //-------------------------------------------------------------------
            switch (GDNMODE.CurrentMode)
            {
                case "1": 
                    if(GetDataDB() == 0)
                    {
                        GotoData();
                    }
                    else
                    {
                        MessageBox.Show("Data đã tồn tại!");
                        GotoKey();
                    }
                    break;
                //-------------------------------------------------------------------
                case "2":
                    if (GetDataDB() == 1)
                    {
                        FillData(G_DATA, dtSource);
                        GotoData();
                    }
                    else
                    {
                        MessageBox.Show("Data không tồn tại!");
                        GotoKey();
                    }
                    break;
                //-------------------------------------------------------------------
                case "3":
                    if (GetDataDB() == 1)
                    {
                        FillData(G_DATA, dtSource);
                        GotoData();
                        G_DATA.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Data không tồn tại!");
                        GotoKey();
                    }
                    break;
                //-------------------------------------------------------------------
                case "4":
                    if (GetDataDB() == 1)
                    {
                        GotoData();
                        FillData(G_DATA, dtSource);
                        G_DATA.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Data không tồn tại!");
                        GotoKey();
                    }
                    break;
                //-------------------------------------------------------------------

                default: break;
            }
        }
        #endregion

        #region "G_DATA events"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_OK_DATA_Click(object sender, EventArgs e)
        {
            if (CheckData() == false)
                return;
            //-------------------------------------------------------------------
            UpdateData();
        }
        //-------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        public void UpdateData()
        {
            switch (GDNMODE.CurrentMode)
            {
                case "1":
                    DataSource.Connect();
                    GetDataToTable();
                    DataSource.InsertRow_DataTable(TableName, dtTemp);
                    GotoKey();
                    DataSource.Disconnect();
                    break;
                //-------------------------------------------------------------------
                case "2":
                    DataSource.Connect();
                    GetDataToTable();
                    DataSource.UpdateRow_DataTable(TableName, dtTemp);
                    GotoKey();
                    DataSource.Disconnect();
                    break;
                //-------------------------------------------------------------------
                case "3":
                    DataSource.Connect();
                    GetKeyDataToTable();
                    DataSource.DeleteRow_DataTable(TableName, dtTemp);
                    GotoKey();
                    DataSource.Disconnect();
                    break;
                //-------------------------------------------------------------------
                case "4": break;
                //-------------------------------------------------------------------

                default: break;
            }

            LoadData();
        }
        //-------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        public void GetDataToTable()
        {
            dtTemp = dtSource;
            dtTemp.Rows.Clear();
            dtTemp.Rows.Add(dtTemp.NewRow());
            //-------------------------------------------------------------------
            foreach (TextBox txt in G_KEY.Controls.OfType<TextBox>())
            {
                dtTemp.Rows[0][txt.Name] = txt.Text;
            }
            //-------------------------------------------------------------------
            foreach (TextBox txt in G_DATA.Controls.OfType<TextBox>())
            {
                dtTemp.Rows[0][txt.Name] = txt.Text;
            }
        }
        //-------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        public void GetKeyDataToTable()
        {
            dtTemp.Clear();

            foreach (TextBox txt in G_KEY.Controls.OfType<TextBox>())
            {
                dtTemp.Columns.Add(txt.Name);
            }
            //-------------------------------------------------------------------
            dtTemp.Rows.Add(dtTemp.NewRow());

            foreach (TextBox txt in G_KEY.Controls.OfType<TextBox>())
            {
                dtTemp.Rows[0][txt.Name] = txt.Text;
            }
        }
        #endregion

        #region "P_CONTROLS events"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_INSERT_Click(object sender, EventArgs e)
        {
            GDNMODE.CurrentMode = "1";
        }
        //-------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_UPDATE_Click(object sender, EventArgs e)
        {
            GDNMODE.CurrentMode = "2";
        }
        //-------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_DELETE_Click(object sender, EventArgs e)
        {
            GDNMODE.CurrentMode = "3";
        }
        #endregion

        #region "Form events"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LOGTEST_F_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClearTextAll();
            DataSource.Disconnect();
        }
        #endregion
    }
}
