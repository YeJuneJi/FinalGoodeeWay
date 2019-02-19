using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoodeeWay.DB;
using GoodeeWay.Order;

namespace GoodeeWay.DAO
{
    class OrderDAO
    {
        internal List<Menu> GetAllMenu(List<Menu> menuList)
        {
            string procedure = "SelectMenu"; // 저장 프로시져 이름                        

            try
            {
                // return new List<Menu>();
                SqlDataReader sdr = new DBConnection().Select(procedure, null);

                while (sdr.Read())
                {
                    Menu menu = new Menu();
                    menu.MenuCode = sdr["menuCode"].ToString();
                    menu.MenuName = sdr["menuName"].ToString();
                    menu.Price = float.Parse(sdr["price"].ToString());
                    menu.Kcal = int.Parse(sdr["kCal"].ToString());
                    byte[] array = (byte[])sdr["menuImage"];
                    MemoryStream ms = new MemoryStream(array);
                    Image img = Image.FromStream(ms);

                    menu.MenuImage = img;
                    menu.Division = sdr["division"].ToString();
                    menu.AdditionalContext = sdr["additionalContext"].ToString();
                    menu.DiscountRatio = float.Parse(sdr["discountRatio"].ToString());

                    menuList.Add(menu);
                }
            }
            catch (SqlException)
            {
                throw;
            }

            return menuList;
        }
    }
}
