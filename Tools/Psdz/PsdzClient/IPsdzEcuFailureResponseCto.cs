﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsdzClient
{
    public interface IPsdzEcuFailureResponseCto
    {
        IPsdzEcuIdentifier EcuIdentifierCto { get; }

        ILocalizableMessageTo Cause { get; }
    }
}
