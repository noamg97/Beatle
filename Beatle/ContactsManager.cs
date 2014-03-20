using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Beatle
{
    class ContactsManager
    {
        #region App Data Folders Paths
        private static string AppDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Beatle";
        public static string ContactDataFolder = AppDataFolder + @"\ContactsData";
        public static string ChatDataFolder = AppDataFolder + @"\ChatsData";
        #endregion

        List<Contact> contacts;



        public ContactsManager()
        {
            CreateDataFoldersIfMissing();
        }

        private void CreateDataFoldersIfMissing()
        {
            if (!Directory.Exists(ContactsManager.ContactDataFolder))
                Directory.CreateDirectory(ContactsManager.ContactDataFolder);

            if (!Directory.Exists(ContactsManager.ChatDataFolder))
                Directory.CreateDirectory(ContactsManager.ChatDataFolder);
        }
    }
}
