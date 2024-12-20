﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using board.common;

namespace board
{
    public partial class LoginForm : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public LoginForm()
        {
            InitializeComponent();
            btnLogin.Click += BtnLogin_Click;
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            await LoginRequest();
        }

        private async Task LoginRequest()
        {
            if (string.IsNullOrWhiteSpace(txtUserId.Text) || string.IsNullOrWhiteSpace(UserPassword.Text))
            {
                labelLoginMsg.Text = "아이디와 비밀번호를 입력해주세요.";
                return;
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor; // 로딩 시작
                btnLogin.Enabled = false; // 버튼 비활성화

                var userDto = new UserDto
                {
                    userId = txtUserId.Text,
                    userPassword = UserPassword.Text
                };

                string json = JsonConvert.SerializeObject(userDto);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    String url = $"{Config.ServerUrl}user/login";
                    //HttpResponseMessage response = await client.PostAsync(url, content);
                    HttpResponseMessage response = await HttpClientManager.GetClient().PostAsync(url, content);


                    if (response.IsSuccessStatusCode)
                    {
                        // 헤더에서 JWT 토큰 추출
                        if (response.Headers.TryGetValues("Authorization", out var headerValues))
                        {
                            var token = headerValues.First().Replace("Bearer ", ""); // "Bearer " 제거
                            common.Session.JwtToken = token; // Session 클래스에 JWT 저장
                        }

                        // API 응답 구조에 맞게 처리
                        string result = await response.Content.ReadAsStringAsync();
                        var responseDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(result);
                        string resMsg = responseDict["resMsg"]?.ToString();
                        var resUser = JsonConvert.DeserializeObject<UserDto>(responseDict["resUser"]?.ToString());

                        if (resMsg == "SUCCESS")
                        {
                            MessageBox.Show("로그인 성공", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Session.UserId = resUser.userId;
                            Session.AuthorityType = resUser.authorityType;
                            // 로그인 성공 시 LoginForm을 닫음
                            //this.Close();
                            this.DialogResult = DialogResult.OK; // 로그인 성공 시 DialogResult 설정
                            this.Close();
                        }
                        else if (resMsg == "USER_NOT_FOUND")
                        {
                            labelLoginMsg.Text = "존재하지 않는 아이디입니다.";
                        }
                        else if (resMsg == "PASSWORD_INCORRECT")
                        {
                            labelLoginMsg.Text = "비밀번호가 틀렸습니다.";
                        }
                        else
                        {
                            labelLoginMsg.Text = "로그인 실패. 다시 시도해주세요.";
                        }
                    }
                    else
                    {
                        labelLoginMsg.Text = "로그인 실패. 서버 오류 발생.";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"로그인 요청 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Cursor.Current = Cursors.Default; // 로딩 종료
                    btnLogin.Enabled = true; // 버튼 활성화
                }
            }
        }

        private async void txtUserId_KeyDown(object sender, KeyEventArgs e)
        {
            await Enter_KeyDown(e);
        }

        private async void UserPassword_KeyDown(object sender, KeyEventArgs e)
        {
            await Enter_KeyDown(e);
        }

        private async Task Enter_KeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await LoginRequest();
                e.SuppressKeyPress = true; // Enter 키 입력이 다른 컨트롤에 전파되지 않도록 방지
            }
        }

        private void btnJoinUser_Click(object sender, EventArgs e)
        {
            // 회원가입
            this.Hide();

            var joinUserForm = new JoinUserForm();
            joinUserForm.ShowDialog();
            this.Show();
        }
    }
}
