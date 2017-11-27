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
            bankList.Add(new Bank() { BankId = "TEST0021", BankName = "SBI Bank A" ,Status=1});
            bankList.Add(new Bank() { BankId = "TEST0022", BankName = "SBI Bank B", Status = 1 });
            bankList.Add(new Bank() { BankId = "TEST0023", BankName = "SBI Bank C", Status = 1 });
            bankList.Add(new Bank() { BankId = "TEST0001", BankName = "Test Bank A", Status = 1 });
            bankList.Add(new Bank() { BankId = "TEST0002", BankName = "Test Bank B", Status = 1 });
            bankList.Add(new Bank() { BankId = "TEST0003", BankName = "Test Bank C", Status = 1 });
            bankList.Add(new Bank() { BankId = "TEST0004", BankName = "Test Bank D", Status = 1 });
            bankList.Add(new Bank() { BankId = "TEST0005", BankName = "Test Bank E", Status = 1 });
            bankList.Add(new Bank() { BankId = "ABB0233", BankName = "Affin Bank", Status = 1 });
            bankList.Add(new Bank() { BankId = "ABMB0212", BankName = "Alliance Bank", Status = 1 });
            bankList.Add(new Bank() { BankId = "AMBB0209", BankName = "AmBank", Status = 1 });
            bankList.Add(new Bank() { BankId = "BIMB0340", BankName = "Bank Islam", Status = 1 });
            bankList.Add(new Bank() { BankId = "BKRM0602", BankName = "Bank Rakyat", Status = 1 });
            bankList.Add(new Bank() { BankId = "BMMB0341", BankName = "Bank Muamalat", Status = 1 });
            bankList.Add(new Bank() { BankId = "BSN0601", BankName = "BSN", Status = 1 });
            bankList.Add(new Bank() { BankId = "BCBB0235", BankName = "CIMB Clicks", Status = 1 });
            bankList.Add(new Bank() { BankId = "HLB0224", BankName = "Hong LeongBank", Status = 1 });
            bankList.Add(new Bank() { BankId = "HSBC0223", BankName = "HSBC Bank", Status = 1 });
            bankList.Add(new Bank() { BankId = "KFH0346", BankName = "KFH", Status = 1 });
            bankList.Add(new Bank() { BankId = "MB2U0227", BankName = "Maybank2U", Status = 1 });
            bankList.Add(new Bank() { BankId = "MBB0228", BankName = "Maybank2E", Status = 1 });
            bankList.Add(new Bank() { BankId = "OCBC0229", BankName = "OCBC Bank", Status = 1 });
            bankList.Add(new Bank() { BankId = "PBB0233", BankName = "Public Bank", Status = 1 });
            bankList.Add(new Bank() { BankId = "RHB0218", BankName = "RHB Bank", Status = 1 });
            bankList.Add(new Bank() { BankId = "SCB0216", BankName = "Standard Chartered", Status = 1 });
            bankList.Add(new Bank() { BankId = "UOB0226", BankName = "UOB Bank", Status = 1 });
        }
    }
}