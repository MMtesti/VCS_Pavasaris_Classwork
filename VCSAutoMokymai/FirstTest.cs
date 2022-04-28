/*
 * 4 yra lyginis skaicius
 * Dabar 19 valanda.
 */

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VCSAutoMokymai
{
    class FirstTest
    {
        [Test]
        public static void TesIf4IsEven()
        {
            int leftOver = 4 % 2;
            Assert.AreEqual(0, leftOver, "4 is not even");
        }
        [Test]
        public static void TestNowIs19()
        {
            DateTime currentTime = DateTime.Now;
            Assert.AreEqual(19, currentTime.Hour, "Dabar ne 19 valanda");
        }
        // Testas “žalias” jeigu 995 dalijasi iš 3 (be liekanos)
        // Testas “žalias” jeigu šiandien pirmadienis(DayOfWeek.Monday)
        //  Testas “žalias” po to kai “palaukia” 5 sekundes

        [Test]
        public static void TestIf995divide3()
        {
            int divide = 995 % 3;
            Assert.AreEqual(0, divide, "995 do not divide in 3");
        }
        [Test]
        public static void TestNowIsMonday()
        {
            DateTime currentTime = DateTime.Now;
            Assert.AreEqual(DayOfWeek.Monday, currentTime.DayOfWeek, "Today Is not Monday");
        }
         [Test]
        public static void TestWait()
        {
            Thread.Sleep(5000);
        }
        

    }
}
