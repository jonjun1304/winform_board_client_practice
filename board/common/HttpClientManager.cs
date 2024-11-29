using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace board.common
{
    class HttpClientManager
    {
        private static readonly HttpClient client = new HttpClient();

        static HttpClientManager()
        {
            // 기본 서버 주소 설정
            client.BaseAddress = new Uri(Config.ServerUrl);
        }

        public static HttpClient GetClient()
        {
            // 저장된 JWT 토큰 가져오기
            string token = Session.JwtToken;

            // JWT 토큰이 있으면 Authorization 헤더에 추가
            if (!string.IsNullOrEmpty(token))
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                Console.WriteLine(client.DefaultRequestHeaders.Authorization);
            }
            else
            {
                // 토큰이 없으면 Authorization 헤더 제거
                client.DefaultRequestHeaders.Authorization = null;
            }

            return client;
        }
    }
}
