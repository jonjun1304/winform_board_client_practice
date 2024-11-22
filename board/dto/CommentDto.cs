using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board.dto
{
    class CommentDto
    {
        public string commentId { get; set; }  // 댓글 ID
        public long boardSeq { get; set; } // 게시글seq
        public string userId { get; set; }    // 작성자 ID
        public string commentContent { get; set; }   // 댓글 내용
        public string commentDttm { get; set; } // 작성일시
    }
}
