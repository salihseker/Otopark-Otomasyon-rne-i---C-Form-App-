using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace OTOPARK_OTOMASYON
{
    public class csDatabaseSql
    {

        SqlConnection emsSqlConnection;
        public csDatabaseSql()
        {
            emsSqlConnection = new SqlConnection("Integrated Security=SSPI;Initial Catalog=OTOPARK_OTOMASYON;Data Source=localhost");

        }


        public string DataTable2HTMLTable(System.Data.DataTable dt)
        {
            StringBuilder sbTop = new StringBuilder();
            sbTop.Append("<table border=1px");
            string bottom = "</table>";
            StringBuilder sb = new StringBuilder();
            //Header        
            sb.Append("<tr>");
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                sb.Append("<td>" + dt.Columns[i].ColumnName + "</td>");
            }
            sb.Append("</tr>");
            //Items        
            for (int x = 0; x < dt.Rows.Count; x++)
            {
                sb.Append("<tr>");
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    sb.Append("<td>" + dt.Rows[x][i] + "</td>");
                }
                sb.Append("</tr>");
            }
            string sTable = sbTop.ToString() + sb.ToString() + bottom;
            return sTable;
        }

        // EMOS DB METHOTLARI


        public string emsExcQuery(string sqlString)
        {
            if (emsSqlConnection.State != ConnectionState.Open)
                emsSqlConnection.Open();

            string errMessage = "";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sqlString;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = emsSqlConnection;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                errMessage = ex.Message;
            }
            emsSqlConnection.Close();
            return errMessage;
        }

        public DataView emsGetDataView(SqlCommand myCommand)
        {
            if (emsSqlConnection.State != ConnectionState.Open)
                emsSqlConnection.Open();

            DataSet ds = new DataSet();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Connection = emsSqlConnection;
            SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
            myAdapter.Fill(ds);

            DataView dv = ds.Tables[0].DefaultView;
            emsSqlConnection.Close();
            return dv;
        }

        public DataView emsGetDataView(string sqlString)
        {
            SqlCommand myCommand = new SqlCommand();
            if (emsSqlConnection.State != ConnectionState.Open)
                emsSqlConnection.Open();

            DataSet ds = new DataSet();
            myCommand.CommandType = CommandType.Text;
            myCommand.Connection = emsSqlConnection;
            myCommand.CommandText = sqlString;
            SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
            myAdapter.Fill(ds);

            DataView dv = ds.Tables[0].DefaultView;
            emsSqlConnection.Close();
            return dv;
        }

        public DataSet emsGetDataSet(SqlCommand myCommand)
        {
            if (emsSqlConnection.State != ConnectionState.Open)
                emsSqlConnection.Open();

            DataSet ds = new DataSet();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Connection = emsSqlConnection;
            SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
            myAdapter.Fill(ds);

            emsSqlConnection.Close();
            return ds;
        }


        public string emsExcQuery(SqlCommand cmd)
        {
            if (emsSqlConnection.State != ConnectionState.Open)
                emsSqlConnection.Open();

            string errMessage = "";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = emsSqlConnection;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                errMessage = ex.Message;
            }
            emsSqlConnection.Close();
            return errMessage;
        }

        public SqlDataReader emsExcCommand(SqlCommand cmd)
        {
            if (emsSqlConnection.State != ConnectionState.Open)
                emsSqlConnection.Open();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = emsSqlConnection;

            SqlDataReader dr = null;
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            return dr;
        }

        public string kayExcTranQuery(SqlCommand cmd)
        {
            string errMessage = "";
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                errMessage = ex.Message;
            }

            return errMessage;
        }


        //--------------------------------
        // DATASET VERİLERİNİ DB YE OTOMATİK YAZAN KOD
        //---------------------------------

        #region DataSet Verilerini DB Ye yazan kod

        public string getSqlDataType(string dataType)
        {
            string ret = "nvarchar(max)";
            switch (dataType)
            {
                case "System.Int32":
                    ret = "int";
                    break;
                case "System.String":
                    ret = "nvarchar(max)";
                    break;
                case "System.Boolean":
                    ret = "bit";
                    break;
                case "System.DateTime":
                    ret = "datetime";
                    break;
            }

            return ret;
        }

        public string getSqlDataValue(string dataType, string dataValue)
        {
            string ret = "'" + dataValue + "'";
            switch (dataType)
            {
                case "System.Int32":
                    ret = (dataValue == "" ? "null" : dataValue);
                    break;
                case "System.String":
                    ret = (dataValue == "" ? "null" : "'" + dataValue.Replace("'", "''") + "'");
                    break;
                case "System.Boolean":
                    ret = (dataValue == "" ? "null" : (dataValue == "True" ? "1" : "0"));
                    break;
                case "System.DateTime":

                    ret = (dataValue == "" ? "null" : (dataValue != "" ? "'" + String.Format("{0:MM/dd/yyyy HH:mm:ss}", DateTime.Parse(dataValue)) + "'" : "''"));
                    break;
            }

            return ret;
        }



        #endregion

        //--------------------------------
        // DATASET VERİLERİNİ DB YE OTOMATİK YAZAN KOD
        //---------------------------------


        public void ToCsV(DataGridView dGV, string filename)
        {
            try
            {
                var path = AppDomain.CurrentDomain.BaseDirectory + filename;
                string stOutput = "";
                // Export titles:
                string sHeaders = "";

                for (int j = 0; j < dGV.Columns.Count; j++)
                    sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
                stOutput += sHeaders + "\r\n";
                // Export data.
                for (int i = 0; i < dGV.RowCount; i++)
                {
                    string stLine = "";
                    for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                        stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                    stOutput += stLine + "\r\n";
                }
                Encoding utf16 = Encoding.GetEncoding(1254);
                byte[] output = utf16.GetBytes(stOutput);
                FileStream fs = new FileStream(path, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(output, 0, output.Length); //write the encoded file
                bw.Flush();
                bw.Close();
                fs.Close();
                MessageBox.Show("Excele Başarılı Şekilde Aktarılmıştır , Dosya yolu : " + path);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata :" + e.Message);
            }
        }

    }
}
