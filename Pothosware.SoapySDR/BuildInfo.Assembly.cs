// Copyright (c) 2021-2022 Nicholas Corgan
// SPDX-License-Identifier: BSL-1.0

using System;

namespace Pothosware.SoapySDR
{
    /// <summary>Version strings for the SoapySDR versions used at runtime and for this build.</summary>
    public partial class BuildInfo
    {
        /// <summary>Version strings for the SoapySDR version used to build this assembly.</summary>
        public class Assembly
        {
            private static readonly uint APIVersionNum = 0x00080200;

            /// <summary>
            /// The SoapySDR ABI version this assembly was built against.
            ///
            /// On instantiation of a device, this version will be validated against
            /// the installed library.
            /// </summary>
            public static string ABIVersion => "0.8-3";

            /// <summary>
            /// The SoapySDR API version this assembly was built against.
            ///
            /// The format of the version string is <b>major.minor.increment</b>.
            /// </summary>
            public static string APIVersion => string.Format("{0}.{1}.{2}", ((APIVersionNum >> 24) & 0xFF), ((APIVersionNum >> 16) & 0xFF), (APIVersionNum & 0xFFFF));

            /// <summary>
            /// The underlying SoapySDR library version this assembly was built against.
            ///
            /// The format of the version string is <b>major.minor.patch-buildInfo</b>.
            /// </summary>
            public static string LibVersion => "0.8.1-g8c6cb7c5";
        }

        internal static void ValidateABI()
        {
            if((SWIGModule.ABIVersion != Runtime.ABIVersion) || (SWIGModule.ABIVersion != Assembly.ABIVersion))
            {
                throw new ApplicationException(string.Format("Mismatched SoapySDR ABI. Make sure your SoapySDR library, SWIG module, and C# assembly have the same ABI.\nSoapySDR: {0}\nSWIG module: {1}\nAssembly: {2}",
                    Runtime.ABIVersion,
                    SWIGModule.ABIVersion,
                    Assembly.ABIVersion));
            }
        }
    }
}
