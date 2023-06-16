using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike.Classes
{
    public class Chart
    {
        private Dictionary<string, Item> MappedItems { get; set; }
        public int Width { get; private set; }
        public int Length { get; private set; }
        public Chart(Dictionary<string, Item> itemsToMap, int width, int length)
        {
            MappedItems = itemsToMap;
            Width = width;
            Length = length;
        }
        //TODO Finish Chart Methods
        public List<string> GetSprites()
        {
            List<string> output = new List<string>();
            foreach (string key in MappedItems.Keys)
            {
                int x = int.Parse(key.Split('|')[0]);
                int y = int.Parse(key.Split('|')[1]);
                while (output.Count < y + 1)
                {
                    output.Add("");
                }
                while (output[y].Length < x)
                {
                    output[y] += " ";
                }
                output[y] = ReplaceCharInString(output[y], MappedItems[key].Sprite, x);
            }
            return output;
        }

        public string ReplaceCharInString(string wordToModify, char charToAdd, int index)
        {
            if(index < wordToModify.Length)
            {
                wordToModify = wordToModify.Substring(0, index) + charToAdd
                        + wordToModify.Substring(index + 1, wordToModify.Length - (index + 1));

            }
            else
            {
                wordToModify += charToAdd;
            }
            return wordToModify;
        }
        public bool AddItem(string coordinate, Item itemToAdd)
        {
            try
            {
                int x = int.Parse(coordinate.Split('|')[0]);
                int y = int.Parse(coordinate.Split('|')[1]);
                MappedItems[coordinate] = itemToAdd;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool RemoveItem(string coordinate)
        {
            try
            {
                MappedItems.Remove(coordinate);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}
