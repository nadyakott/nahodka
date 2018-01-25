using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutputMessages
{
    public class InputOutputMessage
    {
        public MessageType messageType { get; set; }
        public string Name { get; set; } = "";
        public string Adress { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; } = "Not Filled";
        public string Color { get; set; }
        public string Size { get; set; }
        public string Breed { get; set; }
        public string Description { get; set; }

        public static List<string> Input { get; set; } = new List<string>();
        public static List<string> Output { get; set; } = new List<string>();

        public static List<InputOutputMessage> listObj { get; set; } = new List<InputOutputMessage>();

        public static List<InputOutputMessage> AddMessage(InputOutputMessage message)
        {
            listObj.Add(message);
            return listObj;
        }

        public static double CompareTwoArrays(List<string> input,List<string> output)
        {
            try
            {
                double size = 0;
                input = input.Where(x => x != "").ToList();
                output = output.Where(x => x != "").ToList();

                if (input.Count > output.Count) size = input.Count; else size = output.Count;

                List<string> keywords = input.Where(t => output.Contains(t)).ToList();                
                return keywords.Count*1.00 / size * 100;
            }
            catch(Exception ex)
            {
                    return 0.0;
            }
        }
    }
    public enum MessageType
    {
        Lost,
        Found
    }
}
