using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace tic_tac_toe
{
    class UserData
    {
        string _username;
        string _password;

        public UserData(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public string Username 
        {
            set => _username = value;
            get => _username;
        }
        public string Password 
        { 
            set => _password = value;
            get => _password;
        }

        private string GenerateUID() //4 future improvements
        {
            return $"{_username}_{System.DateTime.Now.ToUniversalTime()}";
        }

        public static void Save(string username, string password)
        {
            try
            {
                using (BinaryWriter file = new BinaryWriter(File.Open("userdata.dat", FileMode.OpenOrCreate)))
                {
                    file.Write(username);
                    file.Write(password);
                    Console.WriteLine($"Succesfully writed {username}'s data");
                }
            }
            catch (IOException err)
            {
                Console.WriteLine(err);
            }

        }
        public static void Load(ref string username, ref string password)
        {
            try
            {
                BinaryReader file = new BinaryReader(File.OpenRead("userdata.dat"));
                username = file.ReadString();
                password = file.ReadString();
                Console.WriteLine($"Succesfully readed {username}'s data");
            }
            catch (IOException err)
            {
                Console.WriteLine(err);
            }
        }
    }
}
