using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board
{
    // 게시글 목록에 사용할 DTO 클래스 정의
    public class BoardDto
    {
        public long boardSeq { get; set; }
        public string boardTitle { get; set; }
        public string boardContent { get; set; }
        public string boardDttm { get; set; }
        public string userId { get; set; }
    }
}
