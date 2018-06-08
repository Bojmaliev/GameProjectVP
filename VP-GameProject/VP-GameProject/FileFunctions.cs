using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace VP_GameProject
{
    public class FileFunctions<T>
    {
        public void saveToFile(string FileName, T Object)
        {
            try
            {
                using (FileStream stream = new FileStream(FileName, FileMode.Create))
                {
                    var formater = new BinaryFormatter();

                    formater.Serialize(stream, Object);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Something bad happened\nInfo: " + ex.ToString());
            }
        }

        public T openFile(string FileName) {
            try
            {
                using (FileStream stream = new FileStream(FileName, FileMode.Open))
                {
                    var formater = new BinaryFormatter();
                    return (T)formater.Deserialize(stream);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Something bad happened\nInfo: " + ex.ToString());
            }
        }
    }
}
