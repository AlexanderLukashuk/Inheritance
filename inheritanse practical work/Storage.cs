namespace inheritanse_practical_work
{
    public abstract class Storage
    {
        private string Name { get; set; }
        private string Model { get; set; }
        public string GetName()
        {
            return Name;
        }
        public string GetModel()
        {
            return Model;
        }

        public abstract int GetMemery();
        public abstract double GetTime(int data);
        public abstract int CopyingData(int data);
        public abstract void FreeMemory();
        public abstract void GetInfo();
    }
}