namespace inheritanse_practical_work
{
    public class DVD : Storage
    {
        public double Speed { get; set; }
        public double DvdType {get; set; }
        public DVD()
        {
            Speed  = 1.32;
            DvdType = 4.7 * 1024;
        }

        public DVD(double speed, double type)
        {
            Speed = speed;
            DvdType = type;
        }

        public override int GetMemery()
        {
            return (int)DvdType;
        }

        public override int CopyingData(int data)
        {
            if (data <= DvdType)
            {
                DvdType -= data;
            }
            else
            {
                DvdType = 0;
                data -= (int)DvdType;
            }

            return data;
        }
        public override void FreeMemory()
        {
            System.Console.WriteLine($"Free memory: {DvdType}");
        }
        public override void GetInfo()
        {
            System.Console.WriteLine($"Name: {GetName()}");
            System.Console.WriteLine($"Model: {GetModel()}");
            System.Console.WriteLine($"Speed: {Speed}");
            System.Console.WriteLine($"DVD type: {DvdType}");
        }

        public override double GetTime(int data)
        {
            double time;
            if (data <= DvdType)
            {
                DvdType -= data;
                time = data / Speed;
            }
            else
            {
                DvdType = 0;
                data -= (int)DvdType;
                time = DvdType / Speed;
            }

            return time;
        }
    }
}