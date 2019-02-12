using GoodeeWay.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeWay.DAO
{
    interface IEmp
    {
        // 게시판에 글을 등록
        //bool InsertBoard(BoardVO board);

        // 게시판 글의 전체 글 목록 가져오기
        List<EmpVO> OutputAllBoard();

        // 글 번호로 특정 글 조회수 증가하기
        //BoardVO upReadCountByNum(int num);

        //작성자, 제목, 글내용으로 게시물 검색
        //List<BoardVO> SearchBoard(string searchType, string searchContents);

        //수정

        //삭제
    }
}
