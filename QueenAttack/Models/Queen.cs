using System.Collections.Generic;
using System;

namespace QueenAttack.Models
{
  public class Queen
  {
    private int _x;
    private int _y;

    public Queen(int x, int y)
    {
      _x = x;
      _y = y;
    }

    public int GetX()
    {
      return _x;
    }

    public int GetY()
    {
      return _y;
    }

    public bool CanAttack(int x1, int y1, int x2, int y2)
    {
      if (x1 == x2)
      {
        return true;
      } else if (y1 == y2)
      {
        return true;
      } else if (Math.Abs(x1 - x2) == Math.Abs(y1 - y2))
      {
        return true;
      } else
      {
        return false;
      }
    }

  }
}
