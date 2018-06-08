using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_GameProject
{
    [Serializable]
    public class Player
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public int PinCode { get; set; }
        public int Money { get; set; }

        public static FileFunctions<Player> userFile =  new FileFunctions<Player>();
        public Player(string Name, string Username, int PinCode)
        {

            this.Name = Name;
            this.Username = Username;
            this.PinCode = PinCode;
            Money = 0;
            if (userExists(Username))
            {
                throw new Exception("Username already exists");
            }
            this.Save();
        }

        public void Save()  {
            if (!Directory.Exists("users")) Directory.CreateDirectory("users");
            try
            {
                userFile.saveToFile("users/" + Username + ".user", this);

            }
            catch (Exception ex) {
                throw ex;
            }
            

        }

        public static Player Login(string username, int pin) {

            try
            {
                if (!userExists(username)) throw new Exception("User doesnt exists");
                Player p =  userFile.openFile("users/" + username + ".user");
                if (p.PinCode != pin) throw new Exception("PinCode is incorect");
                return p;
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public static bool userExists(string username) {
            if (File.Exists("users/" + username + ".user")) return true;
            return false;
        }
    }
    
}
