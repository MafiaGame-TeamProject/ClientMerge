using ChatLib.Handlers;
using ChatLib.Models;
using ChatLib.Sockets;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Krypton.Toolkit;
using WaitingRoom;

namespace WinFormClient
{
    public partial class Init_form : KryptonForm
    {
        public static ChatClient _client;
        private ClientHandler? _clientHandler;
        private waitingRoom_form waitingRoomForm;

        private int RoomId => (int)nudRoomId.Value;
        private string UserName => txtName.Text;

        public Init_form()
        {
            InitializeComponent();

            _client = new ChatClient(IPAddress.Parse("127.0.0.1"), 8080);
            _client.Connected += Connected;
            _client.Disconnected += Disconnected;
            _client.Received += Received;
            _client.RunningStateChanged += RunningStateChanged;

            btnConnect.Click += BtnConnect_Click;
            btnStop.Click += BtnStop_Click;
        }

        private void RunningStateChanged(bool isRunning)
        {
            btnConnect.Enabled = !isRunning;
            btnStop.Enabled = isRunning;
        }

        private void Connected(object? sender, ChatLib.Events.ChatEventArgs e)
        {
            _clientHandler = e.ClientHandler;
        }

        private void Disconnected(object? sender, ChatLib.Events.ChatEventArgs e)
        {
            _clientHandler = null;
        }

        private void Received(object? sender, ChatLib.Events.ChatEventArgs e)
        {
            ChatHub hub = e.Hub;
            string message = hub.State switch
            {
                ChatState.Connect => $"{hub.UserName}님이 연결하였습니다.",
                ChatState.Disconnect => $"{hub.UserName}님이 연결을 끊었습니다.",
                _ => $"{hub.UserName}: {hub.Message}"
            };

            if (hub.Message.StartsWith("USER_LIST:"))
            {
                var users = hub.Message.Substring("USER_LIST:".Length).Split(',').ToList();
                if (waitingRoomForm == null || waitingRoomForm.IsDisposed)
                {
                    waitingRoomForm = new waitingRoom_form(_client);
                    waitingRoomForm.UserInfo(RoomId, users);
                    waitingRoomForm.Show();
                    waitingRoomForm.FormClosing += waitingRoom_form_FormClosing;
                    this.Hide(); // 현재 폼을 숨김
                }
                else
                {
                    waitingRoomForm.UserInfo(RoomId, users);
                }
            }

            
        }

        private async void BtnConnect_Click(object? sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("이름을 입력해주세요.");
                return;
            }

            await _client.ConnectAsync(new ConnectionDetails
            {
                RoomId = RoomId,
                UserName = UserName,
            });
        }

        private void BtnStop_Click(object? sender, EventArgs e)
        {
            _client.Close();
            this.Close();
        }

        private void waitingRoom_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            _client.Close();
            this.Show(); // Init_form을 다시 표시
        }
    }
}
