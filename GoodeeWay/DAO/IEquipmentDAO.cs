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
        /// 정보에 맞는 컬럼 찾기
        /// </summary>
        /// <returns></returns>
        List<EquipmentVO> SelectSearch(EquipmentVO equipment, DateTime anotherDate);
        /// <summary>
        /// EquipmentVO타입의 데이터를 DB에 삽입
        /// </summary>
        /// <param name="equipment"></param>
        /// <returns>정상적으로 처리되었다면 true를 반환</returns>
        bool InsertEquipment(EquipmentVO equipment);
        /// <summary>
        /// 해당 Code의 데이터 삭제
        /// </summary>
        /// <param name="equipment"></param>
        /// <returns></returns>
        bool DeleteEquipment(EquipmentVO equipment);
        /// <summary>
        /// 선택된 데이터 수정
        /// </summary>
        /// <param name="equipment"></param>
        /// <returns></returns>
        bool UpdateEquipment(EquipmentVO equipment);
        
    }
}
