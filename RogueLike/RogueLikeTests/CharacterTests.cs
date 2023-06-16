using RogueLike.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RogueLikeTests
{
    [TestClass]
    public class CharacterTests
    {
        private Character C { get; set; }

        [TestInitialize]
        public void SetUpCharacter()
        {
            C = new Character(1, 1);
        }

        [DataTestMethod]
        [DataRow(0, true)]
        [DataRow(1, true)]
        [DataRow(2, true)]
        [DataRow(3, false)]
        [DataRow(4, false)]
        public void TakeDamageTests_HappyPath(int damage, bool expected)
        {
            bool actual = true;
            for(int i = 0; i < damage; i++)
            {
                actual = C.TakeDamage();
            }
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TakeDamageTests_TakeDamageWhenDead()
        {
            bool actual = true;
            bool expected = false;
            for (int i = 0; i < 3; i++)
            {
                actual = C.TakeDamage();
            }
            Assert.AreEqual(expected, actual);
            C.TakeDamage();
            Assert.AreEqual(0, C.Health);
        }
    }
}
