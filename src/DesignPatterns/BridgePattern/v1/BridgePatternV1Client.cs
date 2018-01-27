using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BridgePattern.v1
{
    public class BridgePatternV1Client
    {
        public void Main()
        {
            HandSetBrandBase brandN;
            brandN = new HandSetBrandN();

            brandN.SetSoft(new HandSetGame());
            brandN.Run();

            brandN.SetSoft(new HandSetAddressList());
            brandN.Run();

            brandN = new HandSetBrandM();

            brandN.SetSoft(new HandSetGame());
            brandN.Run();

            brandN.SetSoft(new HandSetAddressList());
            brandN.Run();

            Console.Read();
        }
    }
}
