using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_Héritage {
  class Segment : Figure{
    private readonly int x2;
    private readonly int y2;

    public Segment(int x, int y, int x2, int y2) : base (x, y) {
      this.x2 = x2;
      this.y2 = y2;
    }

    public override string ToString() {
      return "je suis un segment" + base.ToString();
    }
  }
}
