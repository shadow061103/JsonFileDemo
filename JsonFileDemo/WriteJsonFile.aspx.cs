using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JsonFileDemo.Models;
using Newtonsoft.Json;
using System.IO;
namespace JsonFileDemo
{
    public partial class WriteJsonFile : System.Web.UI.Page
    {
        private List<Bank> bankList = new List<Bank>();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GetData();
            string json = JsonConvert.SerializeObject(bankList, Formatting.Indented);
            string path = Server.MapPath("~/JsonFile/");
            if (!File.Exists(path))//資料夾不存在就新增
                Directory.CreateDirectory(path);
            string filelocate = Server.MapPath("~/JsonFile/json.json");
            if (File.Exists(filelocate))//驗證檔案是否存在
                File.Delete(filelocate);
            
            try
            {
                StreamWriter sw = File.CreateText(filelocate);
                sw.Write(json);
                //File.WriteAllText(filelocate, json);
                sw.Close();
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.ToString();
            }
            lblMsg.Text = "寫檔成功";

           




        }
        public void GetData()
        {
            bankList.Add(new Bank() { BankId = "AAA", BankName = "TESTA" ,Status=1});
            bankList.Add(new Bank() { BankId = "BBB", BankName = "TESTB", Status = 1 });
            bankList.Add(new Bank() { BankId = "CCC", BankName = "TESTC", Status = 1 });
            bankList.Add(new Bank() { BankId = "DDD", BankName = "TESTD", Status = 1 });
            bankList.Add(new Bank() { BankId = "EEE", BankName = "TESTE", Status = 1 });
            
        }
    }
}