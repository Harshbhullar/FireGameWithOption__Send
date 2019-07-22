using Microsoft.VisualStudio.TestTools.UnitTesting;
using FireGameWithOption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireGameWithOption.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Assert.Fail();
        }
        // this is the testing of the End game method that is used to start the game 
        [TestMethod()]
        public void EndTest()
        {
            Form1 obj = new Form1();
            obj.End_Game();
        }
        // this is the testing of the start game method that is used to start the game 
        [TestMethod()]
        public void StartTest()
        {
            Form1 obj = new Form1();
            obj.Start_Game();
        }

        // this is the testing of the fire gun  method that is used to start the game 
        [TestMethod()]
        public void FireTest()
        {
            Form1 obj = new Form1();
            obj.Fire_Bullet();
        }
        // this is the testing of the start game method that is used to start the game 
        [TestMethod()]
        public void Start_GameTest()
        {
            Assert.Fail();
        }
    }
}