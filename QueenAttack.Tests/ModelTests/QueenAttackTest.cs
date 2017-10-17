using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueenAttack;
using System;

namespace QueenAttack.Tests
{
    [TestClass]
    public class QueenAttackTest
    {
        [TestMethod]
        public void CanAttack_QueenAndOtherShareXCoordinate_True()
        {
            Queen testQueen = new Queen();
            Assert.AreEqual(true, testQueen.CanAttack(1,2,1,7));
        }

        [TestMethod]
        public void CanAttack_QueenAndOtherShareYCoordinate_True()
        {
            Queen testQueen = new Queen();
            Assert.AreEqual(true, testQueen.CanAttack(4,3,5,3));
        }

        [TestMethod]
        public void CanAttack_QueenAndOtherShareDownwardDiagonalPath_True()
        {
            Queen testQueen = new Queen();
            Assert.AreEqual(true, testQueen.CanAttack(3,5,4,4));
        }

        [TestMethod]
        public void CanAttack_QueenAndOtherShareUpwardDiagonalPath_True()
        {
            Queen testQueen = new Queen();
            Assert.AreEqual(true, testQueen.CanAttack(3,5,6,2));
        }
    }
}
