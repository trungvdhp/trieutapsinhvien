using System;
using System.Xml;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using TrieuTapSinhVien.Components;

namespace TrieuTapSinhVien
{
    partial class DataService : DataTable
    {
        #region Fields
        //private static  OleDbConnection   m_Connection;
        //public static   String          m_ConnectString = "";
        private OleDbCommand m_Command;
        private OleDbDataAdapter m_DataAdapter;
        #endregion

        #region Constructor
        public DataService()
        {

        }
        #endregion

        #region Load
        public int Load(OleDbCommand m_sql)
        {
            KetNoiCSDL.MoKetNoi();
            if (KetNoiCSDL.DaKetNoi == false) return 1;
            int result = 1;
            m_Command = m_sql;
            //MessageBox.Show(m_sql.CommandText);
            try
            {
                m_Command.Connection = KetNoiCSDL.m_Connection;

                m_DataAdapter = new OleDbDataAdapter();
                m_DataAdapter.SelectCommand = m_Command;

                this.Clear();
                result = m_DataAdapter.Fill(this);
            }
            catch (Exception e)
            {
                MessageBox.Show("Không thể thực thi câu lệnh OleDb này!\nLỗi: " + e.Message, "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                KetNoiCSDL.DongKetNoi();
            }
            return result;
        }
        #endregion

        #region Update DataTable
        public int ExecuteNoneQuery()
        {
            KetNoiCSDL.MoKetNoi();
            if (KetNoiCSDL.DaKetNoi == false) return 1;
            int result = 1;
            OleDbTransaction m_OleDbTran = null;
            try
            {
                m_OleDbTran = KetNoiCSDL.m_Connection.BeginTransaction();

                m_Command.Connection = KetNoiCSDL.m_Connection;
                m_Command.Transaction = m_OleDbTran;

                m_DataAdapter = new OleDbDataAdapter();
                m_DataAdapter.SelectCommand = m_Command;

                OleDbCommandBuilder builder = new OleDbCommandBuilder(m_DataAdapter);

                result = m_DataAdapter.Update(this);
                m_OleDbTran.Commit();
            }
            catch
            {
                if (m_OleDbTran != null)
                    m_OleDbTran.Rollback();
            }
            finally
            {
                KetNoiCSDL.DongKetNoi();
            }
            return result;
        }
        #endregion

        #region Thực thi câu lệnh Sql
        public int ExecuteNoneQuery(OleDbCommand m_Sql)
        {
            KetNoiCSDL.MoKetNoi();
            if (KetNoiCSDL.DaKetNoi == false) return 1;
            int result = 1;
            OleDbTransaction m_OleDbTran = null;
            try
            {
                m_OleDbTran = KetNoiCSDL.m_Connection.BeginTransaction();

                m_Sql.Connection = KetNoiCSDL.m_Connection;
                m_Sql.Transaction = m_OleDbTran;
                result = m_Sql.ExecuteNonQuery();

                this.AcceptChanges();
                m_OleDbTran.Commit();
            }
            catch
            {
                if (m_OleDbTran != null)
                    m_OleDbTran.Rollback();
                //throw;
            }
            finally
            {
                KetNoiCSDL.DongKetNoi();
            }
            return result;
        }
        #endregion

        #region ExecuteScalar
        public object ExecuteScalar(OleDbCommand m_Sql)
        {
            KetNoiCSDL.MoKetNoi();
            if (KetNoiCSDL.DaKetNoi == false) return new object();
            object result = null;
            OleDbTransaction m_OleDbTran = null;
            try
            {
                m_OleDbTran = KetNoiCSDL.m_Connection.BeginTransaction();
                m_Sql.Connection = KetNoiCSDL.m_Connection;
                m_Sql.Transaction = m_OleDbTran;
                result = m_Sql.ExecuteScalar();

                this.AcceptChanges();
                m_OleDbTran.Commit();
                if (result == DBNull.Value)
                {
                    result = null;
                }
            }
            catch
            {
                if (m_OleDbTran != null)
                    m_OleDbTran.Rollback();
                //throw;
            }
            finally
            {
                KetNoiCSDL.DongKetNoi();
            }
            return result;
        }
        #endregion

        #region Đổi mật khẩu, thiết lập lại kết nối
        public int ChangePassword(String userName, String newPassword)
        {
            KetNoiCSDL.MoKetNoi();
            if (KetNoiCSDL.DaKetNoi == false) return 1;
            int result = 1;
            m_DataAdapter = new OleDbDataAdapter();
            
            OleDbCommand cmd = new OleDbCommand("UPDATE NGUOIDUNG SET MatKhau = @matkhau WHERE TenDNhap = @tendangnhap");
            cmd.Parameters.Add("tendangnhap", OleDbType.VarChar).Value = userName;
            cmd.Parameters.Add("matkhau",OleDbType.VarChar).Value = newPassword;

            m_Command = new OleDbCommand();
            m_Command = cmd;

            try
            {
                m_Command.Connection = KetNoiCSDL.m_Connection;

                m_DataAdapter = new OleDbDataAdapter();
                m_DataAdapter.SelectCommand = m_Command;

                //this.Clear();

                m_DataAdapter.Fill(this);

                OleDbCommandBuilder buider = new OleDbCommandBuilder(m_DataAdapter);
                result = m_DataAdapter.Update(this);
            }
            catch
            {
                //MessageBox.Show("Không thể thực thi câu lệnh sql này!\nLỗi: " + e.Message, "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                KetNoiCSDL.DongKetNoi();
            }
            return result;
        }
        #endregion
    }
}