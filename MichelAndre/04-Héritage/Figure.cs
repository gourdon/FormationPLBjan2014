using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_Héritage {
  abstract class Figure {
    private int x;
    private int y;

    public Figure(int x, int y) {
      Move(x, y);
    }

    public override string ToString() {
      return " à l'origine (" + x + ", " + y + ") ";
    }

    public void Move(int x, int y) {
      this.x = x;
      this.y = y;
    }
  }
}
