using System;
using System.Collections.Generic;
using System.Text;

namespace lab11 {
    class ZeroDivideEventArgs : EventArgs {
        public object _dividend { get; set; }
        public object _divider { get; set; }

        public ZeroDivideEventArgs(object dividend, object divider) {
            _dividend = dividend;
            _divider = divider;
        }
    }
}
