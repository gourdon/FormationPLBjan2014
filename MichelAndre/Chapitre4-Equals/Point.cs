using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapitre4_Equals {
  class Point {
    private int x;
    private int y;

    public int X {
      get { return x; }
    } 

    public int Y {
      get { return y; }
    }

    public Point(int x, int y) {
      this.x = x;
      this.y = y;
    }

    public static Point operator +(Point p1, Point p2) {
      return new Point(p1.x + p2.x, p1.y + p2.y);
    }

    public static bool operator==(Point p1, Point p2) {
      return p1.x == p2.x && p1.y == p2.y;
    }

    public static bool operator !=(Point p1, Point p2) {
      return !(p1 == p2);
    }

    public override bool Equals(object obj) {
      return this == (Point)obj;
    }
  }
}
