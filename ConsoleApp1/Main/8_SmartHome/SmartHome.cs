namespace KTs_CSharp
{
    public class SmartHome
    {
        List<Device> _connectedDevices = new();

        Light _light = new();
        TV _tv = new();
        AirConditioner _airConditioner = new();
        MusicStation _musicStation = new();

        public SmartHome()
        {
            _connectedDevices.Add(_light);
            _connectedDevices.Add(_tv);
            _connectedDevices.Add(_airConditioner); 
            _connectedDevices.Add(_musicStation);
        }

        public void SetUpHome(SmartHomeMode mode) 
        {
            _musicStation.Switch(false);
            _musicStation.SetMusic(string.Empty);

            switch (mode)
            {
                case SmartHomeMode.Night:
                    _light.SwitchLight(false);

                    _tv.SwitchTV(false);

                    _airConditioner.Switch(true);
                    _airConditioner.SetTemperature(20);

                    _musicStation.Switch(true);
                    _musicStation.SetMusic("Lofi Hip Hop");

                    break;
                case SmartHomeMode.Party:
                    _light.SwitchLight(true);
                    _light.ChangeColor(color: System.Drawing.Color.Azure);
                    _light.ChangeBrightness(0.7f);

                    _airConditioner.Switch(true);
                    _airConditioner.SetTemperature(23);

                    _musicStation.Switch(true);
                    _musicStation.SetMusic("HypnoDancer");

                    break;
                case SmartHomeMode.GoodMorning:
                    _tv.SwitchTV(true);
                    _tv.TurnOnProgram("СПАС");

                    _airConditioner.Switch(true);
                    _airConditioner.SetTemperature(28);

                    _musicStation.Switch(true);
                    _musicStation.SetMusic("Гимн");

                    break;
                case SmartHomeMode.GoingToLessons:
                    _light.SwitchLight(false);

                    _tv.SwitchTV(false);

                    _airConditioner.Switch(false);

                    break;
                case SmartHomeMode.GoingOut:
                    _light.SwitchLight(false);

                    _tv.SwitchTV(false);

                    _airConditioner.Switch(false);
                    break;
                case SmartHomeMode.HomeAlone:
                    _light.SwitchLight(true);
                    _light.ChangeBrightness(0.5f);
                    _light.ChangeColor(System.Drawing.Color.Red);

                    _tv.SwitchTV(true);
                    _tv.TurnOnProgram("РЕН ТВ");

                    _musicStation.Switch(false);
                    _musicStation.SetMusic(string.Empty);

                    _airConditioner.Switch(true);
                    _airConditioner.SetTemperature(22);
                    break;
                default:
                    Console.WriteLine("а мы куда?ы");
                    break;
            }

            foreach (Device device in _connectedDevices)
            {
                Console.WriteLine(device.ToString());
            }
        }

        public enum SmartHomeMode
        {
            Night,
            Party,
            GoodMorning,
            GoingToLessons,
            GoingOut,
            HomeAlone
        }
    }
}
