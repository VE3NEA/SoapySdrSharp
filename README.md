# SoapySdrSharp

This repository contains:

- the [SoapySDR](https://github.com/pothosware/SoapySDR) C# bindings built for .net 8.0;
- DocFX [documentation](Pothosware.SoapySDR/doc/_site/api/Pothosware.SoapySDR.html) for the C# bindings;
- precompiled binaries (ABIVersion 0.8-3) of
  - [SoapySDR](https://github.com/pothosware/SoapySDR) (SoapySDR.dll and SoapySDRCSharpSWIG.dll)
  - [SoapyAirspy](https://github.com/pothosware/SoapyAirspy) (airspySupport.dll)
  - [SoapyRTLSDR](https://github.com/pothosware/SoapyRTLSDR) (rtlsdrSupport.dll)
  - [SoapySDRPlay3](https://github.com/pothosware/SoapySDRPlay3) (sdrplaySupport.dll)
- a C# utility that enumerates the SoapySDR devices and retrieves all available information about them;
- an [example output](ExampleOutput.json) of the utility for Airspy, RTL-SDR and SDRplay.
