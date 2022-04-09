using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Collections;

namespace WindowsFormsApp6
{

    //全域變數 訂購人資訊, 訂購品項列表 使用Arraylist 
    //使用class 存放列表
    class GlobalVar
    {
        public static string 訂購人資訊 = ""; 
        //public static List<ArrayList>
        public static List<ArrayList> list訂購品項列表 = new List<ArrayList>();
        public static List<ArrayList> CustInfo_list = new List<ArrayList>(); //step3

        public static string CustAccountNow="";
        
    }
}
