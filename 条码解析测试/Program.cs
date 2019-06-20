using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 条码解析测试
{
    class Program
    {
        static void Main(string[] args)
        {
            //String StrJX = "P/N:S2-401WW;SN:MP0619163F17956;IMEI:866133040383764";
            //int i=StrJX.IndexOf("SN:")+3;
            //String str = StrJX.Substring(i,15);
            //String str = GetLsBarcode(StrJX);
            
            String StrJX ="https://heyplus.com/download/app?mac=9c%3af6%3add%3a32%3a18%3a91&pid=911";
            String ruyi = GETRUYIBarcode(StrJX);
            Console.WriteLine(ruyi);
            Console.ReadKey();
        }

        public static string GetLsBarcode(string SN)
        {
            if (string.IsNullOrEmpty(SN))
            {
                return "";
            }
            string ImeiTemp = string.Empty;
            if (SN.Contains("SN:") && SN.Contains("P/N:") && SN.Contains("IMEI:"))
            {
                ImeiTemp = SN.Substring(SN.IndexOf("SN:")+3,15);
            }
            else
            {
                ImeiTemp = "";
            } 
            return ImeiTemp;

            //try
            //{
            //    if (string.IsNullOrEmpty(SN))
            //    {
            //        return "";
            //    }
            //    string ImeiTemp = string.Empty;
            //    if (SN.Contains("SN-") && SN.Contains("IMEI-"))
            //    {
            //        ImeiTemp = SN.Substring(0, SN.IndexOf("IMEI-")).Replace("SN-", "");
            //    }
            //    else
            //    {
            //        ImeiTemp = "";
            //    }
            //    return ImeiTemp;
            //}
            //catch (Exception)
            //{

            //}
        }

        public static string GETRUYIBarcode(string SN)
        {
            if (string.IsNullOrEmpty(SN))
            {
                return "";
            }
            string ImeiTemp = string.Empty;
            if (SN.Contains("mac=") && SN.Contains("&") && SN.Contains("https://"))
            {
                int a=SN.IndexOf("mac=")+4;
                int b=SN.IndexOf("&");
                ImeiTemp = SN.Substring(a,b-a);
                ImeiTemp=ImeiTemp.Replace("%3a", ":");
            }
            else
            {
                ImeiTemp = "";
            }
            return ImeiTemp;

            //try
            //{
            //    if (string.IsNullOrEmpty(SN))
            //    {
            //        return "";
            //    }
            //    string ImeiTemp = string.Empty;
            //    if (SN.Contains("SN-") && SN.Contains("IMEI-"))
            //    {
            //        ImeiTemp = SN.Substring(0, SN.IndexOf("IMEI-")).Replace("SN-", "");
            //    }
            //    else
            //    {
            //        ImeiTemp = "";
            //    }
            //    return ImeiTemp;
            //}
            //catch (Exception)
            //{

            //}
        }
    }
}
