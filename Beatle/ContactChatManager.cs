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


    class ContactChatManager
    {
        List<Message> messages;
        static TextBox sendersBox, messagesBox, timesBox;
        string dataFilePath, dataFolderPath;
        string contactName;
        string lastMessageSender = "";


        public ContactChatManager(string contactName)
        {
            this.contactName = contactName;
            dataFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Beatle\ChatsData";
            dataFilePath = dataFolderPath + @"\" + contactName + ".txt";
            LoadFromData();
        }

        public void AppendMessage(string sender, string message, DateTime time)
        {
            Message m = new Message(sender, message, time);

            messages.Add(m);
            AppendMessageToChatBox(m);
            RewriteData();
        }


        public static void InitializeChatTextBoxes(TextBox _sendersBox, TextBox _messagesBox, TextBox _timesBox)
        {
            sendersBox = _sendersBox;
            messagesBox = _messagesBox;
            timesBox = _timesBox;
        }

        public static void Clear()
        {
            sendersBox.Clear();
            messagesBox.Clear();
            timesBox.Clear();
        }


        private void LoadFromData()
        {
            if (File.Exists(dataFilePath))
            {
                string text = File.ReadAllText(dataFilePath);

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
            TextWriter tw = File.CreateText(dataFilePath);
            tw.Write(JsonConvert.SerializeObject(messages));
            tw.Close();
        }

        private void AppendMessageToChatBox(Message m)
        {
            float _deltaLines = messagesBox.CreateGraphics().MeasureString(m.message, messagesBox.Font).Width / (messagesBox.Width);// - (messagesBox.Margin.Left + messagesBox.Margin.Right));
            int deltaLines = (int)Math.Ceiling(_deltaLines) - 1;

            string newLines = Environment.NewLine;

            for (int i = 0; i < deltaLines; i++)
                newLines += Environment.NewLine;

            //string c = "";
            //for (int i = 0; i < m.message.Length; i++)
            //{
            //    c += m.message[i];
            //    if (messagesBox.CreateGraphics().MeasureString(c, messagesBox.Font).Width > messagesBox.Width)
            //    {
            //        m.message = m.message.Insert(i, Environment.NewLine);
            //        c = "";
            //    }
            //}

            string divider = (lastMessageSender != "" && m.sender != lastMessageSender) ? Environment.NewLine : "";


            messagesBox.AppendText(divider + m.message + Environment.NewLine);
            sendersBox.AppendText(divider + (m.sender != lastMessageSender ? m.sender + ":" : "") + newLines);
            timesBox.AppendText(divider + m.time.ToString("HH") + ":" + m.time.ToString("mm") + ":" + m.time.ToString("ss") + newLines);


            lastMessageSender = m.sender;
        }
    }
}
