using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericsVarious.Test
{
    [TestClass]
    public class CircularBufferTests
    {
        [TestMethod]
        public void TestDefaultSizeOfCircularBuffer()
        {
            var buffer1 = new CircularBufffer<int>();
            int bufferSize = 11;
            Assert.AreEqual(bufferSize, buffer1.BufferSize);
        }
        [TestMethod]
        public void TestBufferLenghtIsSetCorrect()
        {
            var buffer1 = new CircularBufffer<int>(5);
            int bufferSize = 6;
            Assert.AreEqual(bufferSize, buffer1.BufferSize);
        }
        [TestMethod]
        public void Test_Buffer_Overwrites_If_Full()
        {
            var buffer1 = new CircularBufffer<int>(3);
            var bufferlist = new [] { 0, 1, 2, 3, 5 };
            foreach (int bufferitem in bufferlist)
            {
                buffer1.write(bufferitem);
            }

            Assert.AreEqual( 5, buffer1.read());
        }

    }
}
