using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NoiThatAdmin.Models.DataModels;

namespace NoiThatAdmin.Utilities
{
    public class Helpers
    {
        TanThoiEntities db = new TanThoiEntities();

        /// <summary>
        /// Get Parent Menu from id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetParentMenu(int? ParentId)
        {
            if(ParentId == 0)
            {
                return "Danh Mục Cha";
            }
            else
            {
                return db.Categories.FirstOrDefault(i => i.CategoryID == ParentId).CategoryName;
            }
            
        }
        #region Rewrite string (Dung-cho-SEO-Google)
        /// <summary>
        /// Convert and rewrite string(tin-tuc-ho)
        /// </summary>
        /// <param name="strInput"></param>
        /// <returns></returns>
        /// 
        public static string ConvertToUpperLower(string strInput)
        {
            for (int i = 1; i < VietNamChar.Length; i++)
            {
                for (int j = 0; j < VietNamChar[i].Length; j++)
                {
                    strInput = strInput.Replace(VietNamChar[i][j], VietNamChar[0][i - 1]);
                }
            }

            string str1 = strInput.Replace(" ", "-").ToLower();
            string str2 = str1.Replace(",", "");
            string str3 = str2.Replace(".", "");
            string str4 = str3.Replace(":", "");
            string str5 = str4.Replace("?", "");
            string str6 = str5.Replace("%", "");
            string str7 = str6.Replace(";", "");
            string str8 = str7.Replace("!", "");
            string str9 = str8.Replace("@", "");
            string str10 = str9.Replace("-", "");

            return str9.ToLower();
        }

        // chuyển chữ có dấu thành không dấu, chữ hoa thành chữ thường
        private static string[] VietNamChar = new string[]
        {
           "aAeEoOuUiIdDyY",
           "áàạảãâấầậẩẫăắằặẳẵ",
           "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
           "éèẹẻẽêếềệểễ",
           "ÉÈẸẺẼÊẾỀỆỂỄ",
           "óòọỏõôốồộổỗơớờợởỡ",
           "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
           "úùụủũưứừựửữ",
           "ÚÙỤỦŨƯỨỪỰỬỮ",
           "íìịỉĩ",
           "ÍÌỊỈĨ",
           "đ",
           "Đ",
           "ýỳỵỷỹ",
           "ÝỲỴỶỸ"
        };
        #endregion

    }
}