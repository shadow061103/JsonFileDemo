using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonFileDemo.Models
{   //新北市政府資料開放平台
    //http://data.ntpc.gov.tw/od/detail?oid=6DCFF24A-838C-40FB-A9DF-F1160AFAFE84
    //編輯-選擇性貼上-貼上json作為類別
    //欄位說明 website:網址、twd97E:twd97E、update_date:更新日期、tel:電話、address:地址、name:地標名稱、type:地標類型、twd97N:twd97N、district:行政區

    public class Rootobject
        {
            public string district { get; set; }
            public string type { get; set; }
            public string name { get; set; }
            public string address { get; set; }
            public string tel { get; set; }
            public string website { get; set; }
            public string twd97E { get; set; }
            public string twd97N { get; set; }
            public string update_date { get; set; }
        }

    
}