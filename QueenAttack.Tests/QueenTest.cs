using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using QueenAttack.Models;

namespace QueenAttack.Tests
{
  [TestClass]
  public class QueenTest
  {
    [TestMethod]
    public void CanAttack_No_False()
    {
      Queen attacker = new Queen(1,1);
      Queen target = new Queen(2,5);

      bool result = attacker.CanAttack(attacker.GetX(), attacker.GetY(), target.GetX(), target.GetY());

      Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void CanAttack_Horizontal_True()
    {
      Queen attacker = new Queen(2,1);
      Queen target = new Queen(2,5);

      bool result = attacker.CanAttack(attacker.GetX(), attacker.GetY(), target.GetX(), target.GetY());

      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void CanAttack_Vertical_True()
    {
      Queen attacker = new Queen(6,5);
      Queen target = new Queen(2,5);

      bool result = attacker.CanAttack(attacker.GetX(), attacker.GetY(), target.GetX(), target.GetY());

      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void CanAttack_Diagonal_True()
    {
      Queen attacker = new Queen(4,4);
      Queen target = new Queen(5,3);

      bool result = attacker.CanAttack(attacker.GetX(), attacker.GetY(), target.GetX(), target.GetY());

      Assert.AreEqual(true, result);
    }
  }
}
