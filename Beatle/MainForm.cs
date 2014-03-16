using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;


namespace Beatle
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public delegate void StringStringDelegate(string msg, string writer);
        private bool isShiftPressed = false;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        Thread listen;
        
        ContactChatManager contact1;


        // "A monkey is way better than an old jar of pickles."
        // "The squirrel has surely got the answer."
        // "Sincerely, I don't think that penguins should be able fly."
        // "A little frog for Christmas."
        // "Had the garden gnome died in the forest, there wouldn't have been any bunnies left for the mayor."



        private IPEndPoint partnerEndPoint = new IPEndPoint(IPAddress.Parse("138.0.0.1"), 1998);



        public MainForm()
        {
            InitializeComponent();
            ChatTextBox.Select();

            chatMain.Font = MetroFramework.MetroFonts.Label(MetroFramework.MetroLabelSize.Medium, MetroFramework.MetroLabelWeight.Regular);
            chatTime.Font = MetroFramework.MetroFonts.Label(MetroFramework.MetroLabelSize.Medium, MetroFramework.MetroLabelWeight.Regular);
            chatSender.Font = MetroFramework.MetroFonts.Label(MetroFramework.MetroLabelSize.Medium, MetroFramework.MetroLabelWeight.Regular);

            ContactChatManager.InitializeChatTextBoxes(chatSender, chatMain, chatTime);
            contact1 = new ContactChatManager("Noam Gal");

            InComing listener = new InComing();
            listen = new Thread(listener.Listen);
            listen.Start();
            InComing.messegeAddedEvent += WriteToChat;

            OutGoing.parent = this;

            timer.Interval = 15;
            timer.Tick += timer_Tick;
            timer.Start();

            this.Text += "Noam Gal"; // = GetFirstName() + GetLastName();
        }

        private void ChatTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13) && !isShiftPressed)
            {
                e.Handled = true;
                SendMessage(null, null);
            }
        }

        private void SendMessage(object sender, EventArgs e)
        {
            string msg = ChatTextBox.Text;

            WriteToChat(msg, "Me");

            ChatTextBox.Select();
            ChatTextBox.Text = "";
            ChatTextBox.Refresh();


            if (!string.IsNullOrWhiteSpace(msg))
                (new Thread(() => (new OutGoing()).SendMessage(msg, partnerEndPoint))).Start();
        }

        public void WriteToChat(string msg, string writer)
        {
            if (!string.IsNullOrWhiteSpace(msg))
            {
                if (InvokeRequired)
                {
                    this.BeginInvoke(new StringStringDelegate(WriteToChat), new object[] { msg, writer });
                    return;
                }

                contact1.AppendMessage(writer, msg, DateTime.Now);
                //chatMain.AppendText(writer + ":\t" + msg + Environment.NewLine);
            }
        }

        public void WriteRecievedSymboleToChat()
        {
            if (ThreadSafety(new Action(WriteRecievedSymboleToChat), new object[] { }))
                return;

            chatMain.AppendText("\t[R]\r\n\r\n");
        }

        public void WriteErrorToChat()
        {
            if (ThreadSafety(new Action(WriteErrorToChat), new object[] { }))
                return;
            if (chatMain != null)
                chatMain.AppendText("Error Connecting To Partner\r\n\r\n");
        }


        private bool ThreadSafety(Action action, params object[] args)
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(action, args);
                return true;
            }
            return false;
        }

        private bool ThreadSafety(Delegate a, params object[] args)
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(a, args);
                return true;
            }
            return false;
        }






        private void ChatTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.ShiftKey))
                isShiftPressed = false;
        }

        private void ChatTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.ShiftKey))
                isShiftPressed = true;
        }

        private void Chat_Enter(object sender, EventArgs e)
        {
            timer.Start();
            HideCaret(chatMain.Handle);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            HideCaret(chatMain.Handle);
            HideCaret(chatTime.Handle);
            HideCaret(chatSender.Handle);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        private void metroTabControl2_CustomPaint(object sender, MetroFramework.Drawing.MetroPaintEventArgs e)
        {
            MetroFramework.Controls.MetroTabPage tab = (MetroFramework.Controls.MetroTabPage)((MetroFramework.Controls.MetroTabControl)sender).Controls[0];
            Point location = new Point();
            location.X = tab.Location.X - 1;
            location.Y = tab.Location.Y - 29;

            Size size = new Size();
            size.Width = tab.Size.Width + 1;
            size.Height = tab.Size.Height + 30;

            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(255, 226, 227, 231), 1), new Rectangle(location, size));
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            OutGoing.isExiting = true;

            InComing.isExiting = true;
            Socket selfish = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            selfish.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1998));

            System.Windows.Forms.Application.Exit();
        }

        private void chat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Down) || e.KeyCode.Equals(Keys.Up))
            {
                chatTime.Scroll(e.KeyCode.Equals(Keys.Up));
                e.Handled = true;
            }
        }

        private void chat_MouseWheel(object sender, MouseEventArgs e)
        {
            chatTime.Scroll(e.Delta > 0);
        }
    }


    class SyncTextBox : TextBox
    {
        public SyncTextBox()
        {
            this.Multiline = true;
            //this.ScrollBars = ScrollBars.Vertical;
        }
        public TextBox Buddy1 { get; set; }
        public TextBox Buddy2 { get; set; }

        const uint WM_MOUSEWHEEL = 0x20A;
        const uint WM_VSCROLL = 0x115;
        const uint SB_LINEUP = 0;
        const uint SB_LINEDOWN = 1;

        public void Scroll(bool isUp)
        {
            System.Windows.Forms.Message m = new System.Windows.Forms.Message();
            m.HWnd = this.Handle;
            m.Msg = (int)WM_VSCROLL;
            m.WParam = (IntPtr)(isUp ? SB_LINEUP : SB_LINEDOWN);
            m.LParam = (IntPtr)0;

            this.WndProc(ref m);
        }

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            if (m.Msg == WM_VSCROLL)
            {
                if (Buddy1 != null && Buddy1.IsHandleCreated)
                    SendMessage(Buddy1.Handle, m.Msg, m.WParam, m.LParam);

                if (Buddy2 != null && Buddy2.IsHandleCreated)
                    SendMessage(Buddy2.Handle, m.Msg, m.WParam, m.LParam);
            }
            if (m.Msg == WM_MOUSEWHEEL)
            {
                int delta = (int)m.WParam >> 16 & 0xFF;
                if ((delta >> 7) == 1)
                {
                    SendMessage(this.Handle, (int)WM_VSCROLL, (IntPtr)SB_LINEDOWN, (IntPtr)0);
                }
                else
                {
                    SendMessage(this.Handle, (int)WM_VSCROLL, (IntPtr)SB_LINEUP, (IntPtr)0);
                }
            }
            else
                base.WndProc(ref m);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
    }
}