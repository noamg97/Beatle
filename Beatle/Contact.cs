using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Drawing;
using System.IO;
using Newtonsoft.Json;

namespace Beatle
{
    class Contact
    {
        ContactChatManager chatManager;
        UserData userData;


        public Contact(string username)
        {
            LoadUserData();
        }

        private void LoadUserData()
        {
            if (File.Exists(ContactsManager.ContactDataFolder + @"\" + userData.username + ".txt"))
            {
                string text = File.ReadAllText(ContactsManager.ContactDataFolder + @"\" + userData.username + ".txt");

                userData = JsonConvert.DeserializeObject<UserData>(text);
            }
            else
            {
                AskServerForContactData();
            }
        }

        private void AskServerForContactData()
        {
            throw new NotImplementedException();
        }
    }

    struct UserData
    {
        public IPEndPoint endPoint;

        public string username;
        public string firstName;
        public string lastName;

        public Image image;

        public DateTime lastChanged;


        public UserData(IPEndPoint endPoint, string username, string firstName, string lastName, Image image, DateTime lastChanged)
        {
            this.endPoint = endPoint;
            this.username = username;
            this.firstName = firstName;
            this.lastName = lastName;
            this.image = image;
            this.lastChanged = lastChanged;
        }
    }
}
