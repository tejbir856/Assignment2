using Microsoft.VisualStudio.TestTools.UnitTesting;
using tajinder_dog_race;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tajinder_dog_race.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Form1 instance_obj = new Form1();

        }
        [TestMethod()]
        public void groundTest()
        {
            ground instance_obj = new ground();
        }
    }
}