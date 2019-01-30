using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoodeeWay.VO;

namespace GoodeeWay.DAO
{
    interface IEquipmentDAO
    {
        /// <summary>
        /// DataBase에서 모든 Row검색
        /// </summary>
        /// <returns></returns>
        List<EquipmentVO> AllequipmentVOsList();
        /// <summary>
        /// EquipmentVO타입의 데이터를 DB에 삽입
        /// </summary>
        /// <param name="equipment"></param>
        /// <returns>정상적으로 처리되었다면 true를 반환</returns>
        bool InsertEquipment(EquipmentVO equipment);
        
    }
}
