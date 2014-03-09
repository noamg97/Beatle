using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Beatle
{
    struct Message
    {
        public string sender;
        public string message;
        public DateTime time;

        public Message(string sender, string message, DateTime time)
        {
            this.sender = sender;
            this.message = message;
            this.time = time;
        }
    }


    class ChatBoxManager
    {
        List<Message> messages;
        TextBox senderBox, messagesBox, timesBox;
        string dataPath, dataFolderPath;
        string contactName;
        string lastMessageSender = "";


        public ChatBoxManager(string contactName, TextBox senderBox, TextBox messagesBox, TextBox timesBox)
        {
            this.senderBox = senderBox;
            this.messagesBox = messagesBox;
            this.timesBox = timesBox;
            this.contactName = contactName;
            dataFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Beatle";
            dataPath = dataFolderPath + @"\" + contactName + ".txt";
            LoadFromData();
        }

        public void AppendMessage(string sender, string message, DateTime time)
        {
            Message m = new Message(sender, message, time);

            messages.Add(m);
            AppendMessageToChatBox(m);
            RewriteData();
        }

        private void LoadFromData()
        {
            if (File.Exists(dataPath))
            {
                string text = File.ReadAllText(dataPath);

                messages = JsonConvert.DeserializeObject<List<Message>>(text);
                foreach (Message m in messages)
                {
                    AppendMessageToChatBox(m);
                }
            }
            else
            {
                messages = new List<Message>();
                if (!System.IO.Directory.Exists(dataFolderPath)) System.IO.Directory.CreateDirectory(dataFolderPath);
                messages = new List<Message>();
                RewriteData();
            }
        }

        private void RewriteData()
        {
            TextWriter tw = File.CreateText(dataPath);
            tw.Write(JsonConvert.SerializeObject(messages));
            tw.Close();
        }

        private void AppendMessageToChatBox(Message m)
        {
            float _deltaLines = messagesBox.CreateGraphics().MeasureString(m.message, messagesBox.Font).Width / (messagesBox.Width - (messagesBox.Margin.Left + messagesBox.Margin.Right));
            int deltaLines = (int)Math.Ceiling(_deltaLines) - 1;

            string newLines = Environment.NewLine;

            for (int i = 0; i < deltaLines; i++)
                newLines += Environment.NewLine;


            string divider = (lastMessageSender != "" && m.sender != lastMessageSender) ? Environment.NewLine : "";


            this.messagesBox.AppendText(divider + m.message + Environment.NewLine);
            this.senderBox.AppendText(divider + (m.sender != lastMessageSender ? m.sender + ":" : "") + newLines);
            this.timesBox.AppendText(divider + m.time.Hour + ":" + m.time.Minute + ":" + m.time.Second + newLines);


            lastMessageSender = m.sender;
        }
    }
}
