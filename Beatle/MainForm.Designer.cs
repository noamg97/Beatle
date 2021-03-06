﻿namespace Beatle
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.Send = new MetroFramework.Controls.MetroButton();
            this.ChatTextBox = new System.Windows.Forms.TextBox();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.OptionsBtn = new MetroFramework.Controls.MetroButton();
            this.AddFriendBtn = new MetroFramework.Controls.MetroButton();
            this.SendFileBtn = new MetroFramework.Controls.MetroButton();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.FriendsTab = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.GroupTab = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Profile = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.chatSender = new System.Windows.Forms.TextBox();
            this.chatMain = new System.Windows.Forms.TextBox();
            this.chatTime = new Beatle.SyncTextBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabControl2.SuspendLayout();
            this.FriendsTab.SuspendLayout();
            this.GroupTab.SuspendLayout();
            this.Profile.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage4);
            this.metroTabControl1.Location = new System.Drawing.Point(20, 50);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1060, 54);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(1052, 15);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // Send
            // 
            this.Send.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Send.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.Send.Highlight = true;
            this.Send.Location = new System.Drawing.Point(993, 538);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(83, 83);
            this.Send.TabIndex = 0;
            this.Send.Text = "Send";
            this.Send.UseSelectable = true;
            this.Send.Click += new System.EventHandler(this.SendMessage);
            // 
            // ChatTextBox
            // 
            this.ChatTextBox.BackColor = System.Drawing.Color.White;
            this.ChatTextBox.Location = new System.Drawing.Point(423, 538);
            this.ChatTextBox.Multiline = true;
            this.ChatTextBox.Name = "ChatTextBox";
            this.ChatTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChatTextBox.Size = new System.Drawing.Size(564, 83);
            this.ChatTextBox.TabIndex = 6;
            this.ChatTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChatTextBox_KeyDown);
            this.ChatTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChatTextBox_KeyPress);
            this.ChatTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ChatTextBox_KeyUp);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Enabled = false;
            this.metroTile2.Location = new System.Drawing.Point(0, 675);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(1100, 0);
            this.metroTile2.TabIndex = 7;
            this.metroTile2.UseSelectable = true;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Enabled = false;
            this.metroTile4.Location = new System.Drawing.Point(423, 136);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(652, 4);
            this.metroTile4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile4.TabIndex = 12;
            this.metroTile4.UseSelectable = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Enabled = false;
            this.metroTile3.Location = new System.Drawing.Point(24, 136);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(368, 4);
            this.metroTile3.TabIndex = 17;
            this.metroTile3.UseSelectable = true;
            // 
            // OptionsBtn
            // 
            this.OptionsBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.OptionsBtn.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.OptionsBtn.Location = new System.Drawing.Point(276, 538);
            this.OptionsBtn.Name = "OptionsBtn";
            this.OptionsBtn.Size = new System.Drawing.Size(83, 83);
            this.OptionsBtn.TabIndex = 16;
            this.OptionsBtn.Text = "Options";
            this.OptionsBtn.UseSelectable = true;
            // 
            // AddFriendBtn
            // 
            this.AddFriendBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.AddFriendBtn.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.AddFriendBtn.Location = new System.Drawing.Point(166, 538);
            this.AddFriendBtn.Name = "AddFriendBtn";
            this.AddFriendBtn.Size = new System.Drawing.Size(83, 83);
            this.AddFriendBtn.TabIndex = 15;
            this.AddFriendBtn.Text = "Add Friend";
            this.AddFriendBtn.UseSelectable = true;
            // 
            // SendFileBtn
            // 
            this.SendFileBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.SendFileBtn.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.SendFileBtn.Location = new System.Drawing.Point(56, 538);
            this.SendFileBtn.Name = "SendFileBtn";
            this.SendFileBtn.Size = new System.Drawing.Size(83, 83);
            this.SendFileBtn.TabIndex = 14;
            this.SendFileBtn.Text = "Send File";
            this.SendFileBtn.UseSelectable = true;
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.FriendsTab);
            this.metroTabControl2.Controls.Add(this.GroupTab);
            this.metroTabControl2.Controls.Add(this.Profile);
            this.metroTabControl2.Location = new System.Drawing.Point(21, 130);
            this.metroTabControl2.Multiline = true;
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 2;
            this.metroTabControl2.Size = new System.Drawing.Size(373, 384);
            this.metroTabControl2.TabIndex = 13;
            this.metroTabControl2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.metroTabControl2.UseSelectable = true;
            this.metroTabControl2.CustomPaint += new System.EventHandler<MetroFramework.Drawing.MetroPaintEventArgs>(this.metroTabControl2_CustomPaint);
            // 
            // FriendsTab
            // 
            this.FriendsTab.AutoScroll = true;
            this.FriendsTab.Controls.Add(this.metroLabel1);
            this.FriendsTab.HorizontalScrollbar = true;
            this.FriendsTab.HorizontalScrollbarBarColor = true;
            this.FriendsTab.HorizontalScrollbarHighlightOnWheel = false;
            this.FriendsTab.HorizontalScrollbarSize = 10;
            this.FriendsTab.Location = new System.Drawing.Point(4, 35);
            this.FriendsTab.Name = "FriendsTab";
            this.FriendsTab.Size = new System.Drawing.Size(365, 345);
            this.FriendsTab.TabIndex = 0;
            this.FriendsTab.Text = "Friends               ";
            this.FriendsTab.VerticalScrollbar = true;
            this.FriendsTab.VerticalScrollbarBarColor = true;
            this.FriendsTab.VerticalScrollbarHighlightOnWheel = false;
            this.FriendsTab.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(141, 90);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Friend List";
            // 
            // GroupTab
            // 
            this.GroupTab.AutoScroll = true;
            this.GroupTab.Controls.Add(this.metroLabel2);
            this.GroupTab.HorizontalScrollbar = true;
            this.GroupTab.HorizontalScrollbarBarColor = true;
            this.GroupTab.HorizontalScrollbarHighlightOnWheel = false;
            this.GroupTab.HorizontalScrollbarSize = 10;
            this.GroupTab.Location = new System.Drawing.Point(4, 35);
            this.GroupTab.Name = "GroupTab";
            this.GroupTab.Size = new System.Drawing.Size(365, 345);
            this.GroupTab.TabIndex = 1;
            this.GroupTab.Text = "Groups               ";
            this.GroupTab.VerticalScrollbar = true;
            this.GroupTab.VerticalScrollbarBarColor = true;
            this.GroupTab.VerticalScrollbarHighlightOnWheel = false;
            this.GroupTab.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(129, 90);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "GroupChat List";
            // 
            // Profile
            // 
            this.Profile.AutoScroll = true;
            this.Profile.Controls.Add(this.metroLabel3);
            this.Profile.HorizontalScrollbar = true;
            this.Profile.HorizontalScrollbarBarColor = true;
            this.Profile.HorizontalScrollbarHighlightOnWheel = false;
            this.Profile.HorizontalScrollbarSize = 10;
            this.Profile.Location = new System.Drawing.Point(4, 35);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(365, 345);
            this.Profile.TabIndex = 2;
            this.Profile.Text = "Profile                  ";
            this.Profile.VerticalScrollbar = true;
            this.Profile.VerticalScrollbarBarColor = true;
            this.Profile.VerticalScrollbarHighlightOnWheel = false;
            this.Profile.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(149, 90);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(44, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Profle";
            // 
            // chatSender
            // 
            this.chatSender.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chatSender.Location = new System.Drawing.Point(423, 139);
            this.chatSender.Multiline = true;
            this.chatSender.Name = "chatSender";
            this.chatSender.ReadOnly = true;
            this.chatSender.Size = new System.Drawing.Size(72, 375);
            this.chatSender.TabIndex = 19;
            this.chatSender.Enter += new System.EventHandler(this.Chat_Enter);
            this.chatSender.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chat_KeyDown);
            this.chatSender.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.chat_MouseWheel);
            // 
            // chatMain
            // 
            this.chatMain.BackColor = System.Drawing.Color.White;
            this.chatMain.Location = new System.Drawing.Point(494, 139);
            this.chatMain.Margin = new System.Windows.Forms.Padding(2);
            this.chatMain.Multiline = true;
            this.chatMain.Name = "chatMain";
            this.chatMain.ReadOnly = true;
            this.chatMain.Size = new System.Drawing.Size(494, 375);
            this.chatMain.TabIndex = 2;
            this.chatMain.Enter += new System.EventHandler(this.Chat_Enter);
            this.chatMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chat_KeyDown);
            this.chatMain.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.chat_MouseWheel);
            // 
            // chatTime
            // 
            this.chatTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chatTime.Buddy1 = this.chatMain;
            this.chatTime.Buddy2 = this.chatSender;
            this.chatTime.Location = new System.Drawing.Point(987, 139);
            this.chatTime.Multiline = true;
            this.chatTime.Name = "chatTime";
            this.chatTime.ReadOnly = true;
            this.chatTime.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.chatTime.Size = new System.Drawing.Size(88, 375);
            this.chatTime.TabIndex = 18;
            this.chatTime.Enter += new System.EventHandler(this.Chat_Enter);
            this.chatTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chat_KeyDown);
            // 
            // MainForm
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.BackImagePadding = new System.Windows.Forms.Padding(25, 12, 0, 0);
            this.ClientSize = new System.Drawing.Size(1100, 680);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.chatSender);
            this.Controls.Add(this.chatTime);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.OptionsBtn);
            this.Controls.Add(this.AddFriendBtn);
            this.Controls.Add(this.SendFileBtn);
            this.Controls.Add(this.metroTabControl2);
            this.Controls.Add(this.chatMain);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.ChatTextBox);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 680);
            this.Name = "MainForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Tag = "";
            this.Text = "BEATLE™  -  ";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabControl2.ResumeLayout(false);
            this.FriendsTab.ResumeLayout(false);
            this.FriendsTab.PerformLayout();
            this.GroupTab.ResumeLayout(false);
            this.GroupTab.PerformLayout();
            this.Profile.ResumeLayout(false);
            this.Profile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroButton Send;
        private System.Windows.Forms.TextBox ChatTextBox;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroButton OptionsBtn;
        private MetroFramework.Controls.MetroButton AddFriendBtn;
        private MetroFramework.Controls.MetroButton SendFileBtn;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage FriendsTab;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage GroupTab;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTabPage Profile;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.TextBox chatMain;
        private SyncTextBox chatTime;
        private System.Windows.Forms.TextBox chatSender;



    }
}
