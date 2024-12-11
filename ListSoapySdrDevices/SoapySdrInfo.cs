using System.Numerics;
using System.Reflection;
using Pothosware.SoapySDR;
using Range = Pothosware.SoapySDR.Range;
using Stream = Pothosware.SoapySDR.Stream;

namespace SoapySdrSharp
{
  public class SoapySdrInfo
  {
    public Dictionary<string, string> Assembly;
    public Dictionary<string, string> Runtime;
    public Dictionary<string, string> SWIGModule;
    public List<DeviceInfo> Devices;

    public SoapySdrInfo()
    {
      Assembly = GetStaticFields(typeof(BuildInfo.Assembly));
      Runtime = GetStaticFields(typeof(BuildInfo.Runtime));
      SWIGModule = GetStaticFields(typeof(BuildInfo.SWIGModule));

      Devices = Device.Enumerate().Select(args => new DeviceInfo(args)).ToList();
    }

    public class DeviceInfo
    {
      public Kwargs Args;
      public string Error;
      public ArgInfoList SettingInfo;
      public string DriverKey;
      public string HardwareKey;
      public Kwargs HardwareInfo;
      public double MasterClockRate;
      public RangeList MasterClockRates;
      public double ReferenceClockRate;
      public RangeList ReferenceClockRates;
      public string ClockSource;
      public StringList ClockSources;
      public string TimeSource;
      public StringList TimeSources;
      public StringList UARTs;
      public bool HasHardwareTime;
      public string FrontendMapping;
      public Dictionary<string, ArgInfo> Sensors;
      public StringList RegisterInterfaces;
      public Dictionary<string, uint> GPIOBankDirections;
      public List<ArgInfo> SensorInfo;
      public Dictionary<string, string> Settings;


      public List<RxTxChannelInfo> RxChannels = new();
      public List<RxTxChannelInfo> TxChannels = new();

      public DeviceInfo(Kwargs kwargs)
      {
        try
        {
          Device device = new(kwargs);

          Args = kwargs;
          DriverKey = device.DriverKey;
          HardwareKey = device.HardwareKey;
          HardwareInfo = device.HardwareInfo;
          MasterClockRate = device.MasterClockRate;
          MasterClockRates = device.MasterClockRates;
          ReferenceClockRate = device.ReferenceClockRate;
          ReferenceClockRates = device.ReferenceClockRates;
          ClockSource = device.ClockSource;
          ClockSources = device.ClockSources;
          TimeSource = device.TimeSource;
          TimeSources = device.TimeSources;
          UARTs = device.UARTs;
          SettingInfo = device.GetSettingInfo();
          HasHardwareTime = device.HasHardwareTime("");
          FrontendMapping = device.GetFrontendMapping(Direction.Rx);
          Sensors = device.ListSensors().ToDictionary(key => key, key => device.GetSensorInfo(key));
          RegisterInterfaces = device.RegisterInterfaces;
          GPIOBankDirections = device.GPIOBanks.ToDictionary(key => key, key => device.ReadGPIODir(key));
          Settings = SettingInfo.ToDictionary(s => s.Key, s => device.ReadSetting(s.Key));

          uint channelCount = device.GetNumChannels(Direction.Rx);
          for (uint channelNo = 0; channelNo < channelCount; channelNo++)
            RxChannels.Add(new RxTxChannelInfo(device, Direction.Rx, channelNo));

          channelCount = device.GetNumChannels(Direction.Tx);
          for (uint channelNo = 0; channelNo < channelCount; channelNo++)
            TxChannels.Add(new RxTxChannelInfo(device, Direction.Tx, channelNo));
        }
        catch (Exception e)
        {
          Error = e.Message;
        }
      }
    }

    public class RxTxChannelInfo
    {
      private Device Device;

      public Direction Direction;
      public uint ChannelNo;
      public string? Error;
      public bool HasDCOffsetMode, HasDCOffset, HasIQBalance, HasIQBalanceMode, HasFrequencyCorrection, HasGainMode;
      public bool FullDuplex;
      public Kwargs ChannelInfo;
      public StringList StreamFormats = new();
      public string NativeStreamFormat;
      public double NativeStreamFullSale;
      public ArgInfoList StreamArgsInfo;
      public StringList Antennas;
      public Dictionary<string, ArgInfo> Sensors;
      public string Antenna;
      public Device device;
      public bool? DCOffsetMode;
      public Complex? DCOffset;
      public bool? IQBalanceMode;
      public Complex? IQBalance;
      public double? FrequencyCorrection;
      public bool? GainMode;
      public double Gain;
      public Dictionary<string, double> Gains;
      public Range GainRange;
      public Dictionary<string, Range> GainRanges;
      public RangeList FrequencyRange;
      public Dictionary<string, RangeList> FrequencyRanges;
      public double Frequency;
      public Dictionary<string, double> Frequencies;
      public ArgInfoList FrequencyArgsInfo;
      public double SampleRate;
      public RangeList SampleRateRange;
      public double Bandwidth;
      public RangeList BandwidthRange;
      public ArgInfoList SettingInfo;
      public Dictionary<string, string> Settings;
      public StreamInfo Stream;

      public RxTxChannelInfo(Device device, Direction direction, uint channelNo)
      {
        Device = device;
        Direction = direction;
        ChannelNo = channelNo;

        try
        {
          ChannelInfo = device.GetChannelInfo(direction, channelNo);
          HasDCOffsetMode = device.HasDCOffsetMode(direction, channelNo);
          HasDCOffset = device.HasDCOffset(direction, channelNo);
          HasIQBalance = device.HasIQBalance(direction, channelNo);
          HasIQBalanceMode = device.HasIQBalanceMode(direction, channelNo);
          HasFrequencyCorrection = device.HasFrequencyCorrection(direction, channelNo);
          HasGainMode = device.HasGainMode(direction, channelNo);
          FullDuplex = device.GetFullDuplex(direction, channelNo);
          StreamFormats = device.GetStreamFormats(direction, channelNo);
          NativeStreamFormat = device.GetNativeStreamFormat(direction, channelNo, out NativeStreamFullSale);
          StreamArgsInfo = device.GetStreamArgsInfo(direction, channelNo);
          Antennas = device.ListAntennas(direction, channelNo);
          Sensors = device.ListSensors(direction, channelNo).ToDictionary(key => key, key => device.GetSensorInfo(direction, channelNo, key));
          Antenna = device.GetAntenna(direction, channelNo);
          Gain = device.GetGain(direction, channelNo);
          Gains = device.ListGains(direction, channelNo).ToDictionary(k => k, k => device.GetGain(direction, channelNo, k));
          GainRange = device.GetGainRange(direction, channelNo);
          GainRanges = device.ListGains(direction, channelNo).ToDictionary(k => k, k => device.GetGainRange(direction, channelNo, k));
          FrequencyRange = device.GetFrequencyRange(direction, channelNo);
          FrequencyRanges = device.ListFrequencies(direction, channelNo).ToDictionary(k => k, k => device.GetFrequencyRange(direction, channelNo, k));
          Frequency = device.GetFrequency(direction, channelNo);
          Frequencies = device.ListFrequencies(direction, channelNo).ToDictionary(k => k, k => device.GetFrequency(direction, channelNo, k));
          FrequencyArgsInfo = device.GetFrequencyArgsInfo(direction, channelNo);
          SampleRate = device.GetSampleRate(direction, channelNo);
          SampleRateRange = device.GetSampleRateRange(direction, channelNo);
          Bandwidth = device.GetBandwidth(direction, channelNo);
          BandwidthRange = device.GetBandwidthRange(direction, channelNo);
          SettingInfo = device.GetSettingInfo(direction, channelNo);
          Settings = SettingInfo.ToDictionary(s => s.Key, s => device.ReadSetting(direction, channelNo, s.Key));

          if (HasDCOffsetMode) DCOffsetMode = device.GetDCOffsetMode(direction, channelNo);
          if (HasDCOffset) DCOffset = device.GetDCOffset(direction, channelNo);
          if (HasIQBalanceMode) IQBalanceMode = device.GetIQBalanceMode(direction, channelNo);
          if (HasIQBalance) IQBalance = device.GetIQBalance(direction, channelNo);
          if (HasFrequencyCorrection) FrequencyCorrection = device.GetFrequencyCorrection(direction, channelNo);
          if (HasGainMode) GainMode = device.GetGainMode(direction, channelNo);

          Stream = new(device, direction, channelNo);
        }
        catch (Exception e)
        {
          Error = e.Message;
        }
      }
    }

    public class StreamInfo
    {
      public string? Error;
      public uint[] Channels;
      public string Format;
      public ulong MTU;
      public Kwargs StreamArgs;
      public StreamData[] ExampleData = new StreamData[2];


      public StreamInfo(Device device, Direction direction, uint channelNo)
      {
        try
        {
          var channels = new uint[] { channelNo };
          Stream stream = direction == Direction.Rx ? device.SetupRxStream("CF32", channels, "") : device.SetupTxStream("CF32", channels, "");

          try
          {
            Channels = stream.Channels;
            Format = stream.Format;
            MTU = stream.MTU;
            StreamArgs = stream.StreamArgs;

            if (direction == Direction.Rx)
            {
              stream.Activate();

              ExampleData[0] = new();
              ExampleData[0].ErrorCode = ((RxStream)stream).Read(ref ExampleData[0].Samples, 100000, out ExampleData[0].StreamResult);

              ExampleData[1] = new();
              ExampleData[1].ErrorCode = ((RxStream)stream).Read(ref ExampleData[1].Samples, 100000, out ExampleData[1].StreamResult);

              stream.Deactivate();
            }
          }

          finally
          {
            try { stream.Close(); } catch { }
          }
        }
        catch (Exception e)
        {
          Error = e.Message;
        }
      }
    }

    public class StreamData
    {
      public ErrorCode ErrorCode;
      public float[] Samples = new float[6];
      public StreamResult StreamResult = new();
    }

    private Dictionary<string, string>? GetStaticFields(Type classType)
    {
      return classType.GetProperties(BindingFlags.Public | BindingFlags.Static).ToDictionary(p => p.Name, p => p.GetValue(null).ToString());
    }
  }
}