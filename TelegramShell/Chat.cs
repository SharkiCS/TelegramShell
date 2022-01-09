﻿using System;
using System.Windows.Forms;
using Telegram.Bot.Args;

namespace TelegramShell
{
    public partial class Chat : Form
    {
        private readonly TelegramAPI _mainApi;
        private readonly string _nickName;
        private TelegramAPI _api;
        private long _chatId;

        public Chat(TelegramAPI mainApi, string nickName)
        {
            _mainApi = mainApi;
            _nickName = nickName;
            
            InitializeComponent();

            _api = new TelegramAPI();
            _api.Client.StartReceiving();
            _api.Client.OnMessage += OnMessageHandler;
        }

        private void OnMessageHandler(object sender, MessageEventArgs e)
        {
            _chatId = e.Message.Chat.Id;
            messageWindow.AppendText($"{_nickName}: {e.Message.Text}\n");
        }
        
        private void Chat_Load(object sender, EventArgs e)
        {

        }
        

        private void sendMessage_Click(object sender, EventArgs e)
        {
            messageWindow.AppendText($"Victima: {messageBox.Text}\n");
            _api.Client.SendTextMessageAsync(_chatId, messageBox.Text);
        }

        private void Chat_FormClosing(object sender, FormClosingEventArgs e)
        {
            _api.Client.SendTextMessageAsync(_chatId, "Chat has been closed.");

            _api.Client.StopReceiving();
            _mainApi.Client.StartReceiving();
        }
    }
}
