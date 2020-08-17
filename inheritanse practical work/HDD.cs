namespace inheritanse_practical_work
{
    public class HDD : Storage
    {
        public int USB_2_Speed { get; set; }
        public int NumberOfSections { get; set; }
        public int VolumeOfSections { get; set; }
        public HDD()
        {
            USB_2_Speed = 60;
            NumberOfSections = 4;
            VolumeOfSections = 131072;
        }
        public HDD(int usbSpeed, int sections, int volume)
        {
            USB_2_Speed = usbSpeed;
            NumberOfSections = sections;
            VolumeOfSections = volume;
        }

        public override int GetMemery()
        {
            return NumberOfSections * VolumeOfSections;
        }

        public override int CopyingData(int data)
        {
            int memory = NumberOfSections * VolumeOfSections;
            if (data <= memory)
            {
                memory -= data;
            }
            else
            {
                memory = 0;
                data -= memory;
            }

            return data;
        }
        public override void FreeMemory()
        {
            System.Console.WriteLine($"Free memory: {NumberOfSections * VolumeOfSections}");
        }
        public override void GetInfo()
        {
            System.Console.WriteLine($"Name: {GetName()}");
            System.Console.WriteLine($"Model: {GetModel()}");
            System.Console.WriteLine($"USB 2.0 speed: {USB_2_Speed}");
            System.Console.WriteLine($"Number of sections: {NumberOfSections}");
            System.Console.WriteLine($"Volume of sections: {VolumeOfSections}");
        }

        public override double GetTime(int data)
        {
            double time;
            int memory = NumberOfSections * VolumeOfSections;
            if (data <= memory)
            {
                memory -= data;
                time = data / USB_2_Speed;
            }
            else
            {
                memory = 0;
                data -= memory;
                time = memory / USB_2_Speed;
            }

            return time;
        }
    }
}