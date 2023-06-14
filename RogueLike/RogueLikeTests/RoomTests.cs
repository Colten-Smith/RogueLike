using RogueLike.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeTests
{
    [TestClass]
    public class RoomTests
    {
        [TestMethod]
        [DataRow(10, 10, "1|2", true)]
        [DataRow(10, 10, "2|1", true)]
        [DataRow(1, 1, "2|3", true)]
        [DataRow(15, 12, "15|12", false)]
        [DataRow(27, 14, "1|1", false)]
        
        public void AddDoorTests_HappyPath(int width, int height, string coordinate, bool expected)
        {
            Room room = new Room(width, height);
            bool actual = room.AddDoor(coordinate);
            Assert.AreEqual(expected, actual);
        }
    }
}
