using System;

namespace cbo_dotnet
{
    class A: B
    {
        public void mA1() {
            new B().mB1();
            new C().mC1();
        }
        public void mA2() {
            new B().mB2();
            new C().mC2();
        }
        public void mA3() {
            new B().mB3();
            new C().mC3();
        }
        public void mA4() {
            new C().mC4();
        }
    }
}
