using System.Reflection;
using Pothosware.SoapySDR;
using Newtonsoft.Json;
using SoapySdrSharp;

// Force SoapySDR to look for the SDR drivers in a sub-folder of the app folder
string? appDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
if (appDir == null) throw new Exception("Cannot get assembly location");
Environment.SetEnvironmentVariable("SOAPY_SDR_ROOT", appDir);
string path = Environment.GetEnvironmentVariable("PATH") ?? "";
path = $"{appDir}\\lib\\SoapySDR\\modules{BuildInfo.Assembly.ABIVersion};{path}";
Environment.SetEnvironmentVariable("PATH", path);

// enumerate devices, read their properties
SoapySdrInfo soapySdrInfo = new();

// print results
string json = JsonConvert.SerializeObject(soapySdrInfo, Formatting.Indented);
Console.WriteLine(json);
