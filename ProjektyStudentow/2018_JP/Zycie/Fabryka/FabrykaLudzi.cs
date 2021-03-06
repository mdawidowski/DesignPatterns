﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zycie.Model;

namespace Zycie.Fabryka
{
    public class FabrykaLudzi:FabrykaAbstrakcyjnaIstot
    {
        private readonly string _nazwa;

        public FabrykaLudzi(string nazwa)
        {
            this._nazwa = nazwa;
        }

        public override Istota StworzIstote()
        {
            return new Czlowiek(_nazwa);
        }
    }
}
