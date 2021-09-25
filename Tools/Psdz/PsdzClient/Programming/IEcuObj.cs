﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PsdzClient.Core;

namespace PsdzClient.Programming
{
    [AuthorAPI(SelectableTypeDeclaration = true)]
    public enum Bus
    {
        ACan,
        BodyCan,
        DCan,
        FaCan,
        KCan,
        Unknown,
        Unbekannt,
        Most,
        FlexRay,
        B2Can,
        Ethernet,
        SCan,
        LeCan,
        LpCan,
        IkCan,
        SfCan,
        ZsgCan,
        ZgwCan,
        Le2Can,
        InfraCan,
        B3Can,
        SystemBusEthernet,
        AeCanFd,
        ApCanFd,
        FasCanFd,
        UssCanFd,
        SrrCanFd
    }

	[AuthorAPI(SelectableTypeDeclaration = true)]
	public interface IEcuObj
    {
        string EcuRep { get; }

        string EcuGroup { get; }

        string BaseVariant { get; }

        string BnTnName { get; }

        IList<Bus> BusConnections { get; }

        IList<string> BusConnectionsAsString { get; }

        Bus DiagnosticBus { get; }

        IEcuDetailInfo EcuDetailInfo { get; }

        IEcuIdentifier EcuIdentifier { get; }

        IEcuStatusInfo EcuStatusInfo { get; }

        string EcuVariant { get; }

        int? GatewayDiagAddrAsInt { get; }

        string SerialNumber { get; }

        IStandardSvk StandardSvk { get; }

        string OrderNumber { get; }

        IEcuPdxInfo EcuPdxInfo { get; }
    }
}
