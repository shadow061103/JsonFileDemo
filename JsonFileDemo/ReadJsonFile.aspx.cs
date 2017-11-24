using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.IO;
using JsonFileDemo.Models;

namespace JsonFileDemo
{
    public partial class ReadJsonFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Bank> bankList = new List<Bank>();
            string filelocate = Server.MapPath("~/JsonFile/json.json");
            try
            {   //1
                StreamReader sr = new StreamReader(filelocate);
                string json = sr.ReadToEnd();


                //solution 2
                //string json = File.ReadAllText(filelocate);
                bankList = JsonConvert.DeserializeObject<List<Bank>>(json);

            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.ToString();
            }
           
            GridView1.DataSource = bankList;
            GridView1.DataBind();
            lblMsg.Text = "讀檔成功";




        }
    }
}