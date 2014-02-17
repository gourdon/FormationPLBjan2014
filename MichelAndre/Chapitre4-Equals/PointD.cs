using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapitre4_Equals {
  class PointD {
    private double x;
    private double y;

    public PointD(double x, double y) {
      this.x = x;
      this.y = y;
    }

    public static implicit operator PointD (Point p){
      return new PointD (p.X, p.Y);
    }

    public static explicit operator Point (PointD p) {
      return new Point((int)p.x, (int)p.y);
    }
  }
}
