using System;
using SRML;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlimeArchipelago
{
    public class Main : ModEntryPoint
    {
        public override void PreLoad(){
            HarmonyInstance.PatchAll();
        }

        public override void Load()
        {
            base.Load();
        }

        public override void PostLoad()
        {
            base.PostLoad();
        }
    }
}
