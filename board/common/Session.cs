using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board.common
{
    public static class Session
    {
        public static string JwtToken { get; set; } // JWT 토큰 저장

        public static string UserId { get; set; }

        //public static bool IsLoggedIn => !string.IsNullOrEmpty(UserId);

        public static string AuthorityType { get; set; }

        public static bool IsLoggedIn => !string.IsNullOrEmpty(JwtToken); // JWT 존재 여부로 로그인 상태 확인

        // 세션 초기화 (로그아웃 시 호출)
        public static void Clear()
        {
            JwtToken = null;
            UserId = null;
            AuthorityType = null;
        }
    }
}
