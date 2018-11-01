using ManagementAPI.Modale;
using ManagementAPI.ST_Class;
using ManagementAPI.X_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ManagementAPI
{
    public partial class wConfigDB : Form
    {
        public wConfigDB()
        {
            InitializeComponent();
        }

        private void wConfigDB_Load(object sender, EventArgs e)
        {
            W_GETxConfigDB();
        }

        private void ocmSaveConfig_Click(object sender, EventArgs e)
        {
            try
            {
                W_SETxConfigDB();
                Close();
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }
        private void W_GETxConfigDB()
        {

            try
            {
                var oConfigDB = new cSetting();
                var oConnectDB = new cmlConnectDB();
                oConnectDB = oConfigDB.C_GEToSetting();
                otbServerName.Text = oConnectDB.tCML_Server;
                otbDbName.Text = oConnectDB.tCML_Database;
                otbUserName.Text = oConnectDB.tCML_Username;
                otbUserPwd.Text = oConnectDB.tCML_Password;
                otbUrl.Text = oConnectDB.tCML_Url;

            }
            catch (Exception oEx)
            {
                MessageBox.Show("wConfigDB : wConfigDB_Load  //" + oEx.Message);
            }
        }
        private void W_SETxConfigDB()
        {
            cFoodLandCallAPI oFoodLandCallAPI;
            cmlConnectDB oConnectDB;
            string tUrl;
            try
            {
                var oConfigDB = new cSetting();
                tUrl = otbUrl.Text + "SETConfigDB";
                oFoodLandCallAPI = new cFoodLandCallAPI();
                oConnectDB = new cmlConnectDB();
                oConnectDB.tCML_Server = otbServerName.Text;
                oConnectDB.tCML_Database = otbDbName.Text;
                oConnectDB.tCML_Username = otbUserName.Text;
                oConnectDB.tCML_Password = otbUserPwd.Text;
                oFoodLandCallAPI.C_SETxConfigDB(tUrl.Trim(), oConnectDB);
                oConnectDB.tCML_Url = otbUrl.Text;
                oConfigDB.C_SETxSetting(oConnectDB);
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }

        private void otbCancel_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception oEx)
            {
                throw oEx;
            }
        }
    }
}
