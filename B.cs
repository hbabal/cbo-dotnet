using System;

namespace cbo_dotnet
{
    class B
    {
        public void mB1() {
            new C().mC1();
        }
        public void mB2() {
            D d = new D();
            d.mD1();
        }
        public void mB3() {}
        public void mA4() {}
    }
}
