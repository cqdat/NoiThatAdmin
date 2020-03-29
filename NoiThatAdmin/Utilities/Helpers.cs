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
    }
}