namespace inheritanse_practical_work
{
    public class Flash : Storage
    {
        public int USB_3_Speed { get; set; }
        public int MemoryCapacity { get; set; }
        public Flash()
        {
            USB_3_Speed = 600;
            MemoryCapacity = 32768;
        }
        public Flash(int usbSpeed, int memory)
        {
            USB_3_Speed = usbSpeed;
            MemoryCapacity = memory;
        }

        public override int GetMemery()
        {
            return MemoryCapacity;
        }
        public override int CopyingData(int data)
        {
            if (data <= MemoryCapacity)
            {
                MemoryCapacity -= data;
            }
            else
            {
                MemoryCapacity = 0;
                data -= MemoryCapacity;
            }

            return data;
        }
        public override void FreeMemory()
        {
            System.Console.WriteLine($"Free memory: {MemoryCapacity}");
        }
        public override void GetInfo()
        {
            System.Console.WriteLine($"Name: {GetName()}");
            System.Console.WriteLine($"Model: {GetModel()}");
            System.Console.WriteLine($"USB 3.0 speed: {USB_3_Speed}");
            System.Console.WriteLine($"Memory: {MemoryCapacity}");
        }
        public override double GetTime(int data)
        {
            double time;
            if (data <= MemoryCapacity)
            {
                MemoryCapacity -= data;
                time = data / USB_3_Speed;
            }
            else
            {
                MemoryCapacity = 0;
                data -= MemoryCapacity;
                time = MemoryCapacity / USB_3_Speed;
            }

            return time;
        }
    }
}