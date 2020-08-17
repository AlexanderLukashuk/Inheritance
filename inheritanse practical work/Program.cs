using System;

namespace inheritanse_practical_work
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage hdd = new HDD();
            Storage dvd = new DVD();
            Storage flash = new Flash();
            Storage[] storages = new Storage[100];
            storages[0] = hdd;
            storages[1] = dvd;
            storages[2] = flash;
            int countStorages = 3;
            int data = 578560;
            int i = 0;
            double elapsedTime = 0;

            while (data > 0)
            {
                if (storages[i].GetName() == "HDD" && data > storages[i].GetMemery() && storages[i].GetMemery() > 0)
                {
                    data = storages[i].CopyingData(data);
                    elapsedTime += storages[i].GetTime(data);
                }
                else if (storages[i].GetName() == "HDD" && data > storages[i].GetMemery() && storages[i].GetMemery() == 0)
                {
                    storages[countStorages] = new HDD();
                    countStorages++;
                }
                else if (storages[i].GetName() == "HDD" && data < storages[i].GetMemery() && storages[i].GetMemery() > 0)
                {
                    if (storages[i].GetName() == "Flash" && data > storages[i].GetMemery() && storages[i].GetMemery() > 0)
                    {
                        data = storages[i].CopyingData(data);
                        elapsedTime += storages[i].GetTime(data);
                    }
                    else if (storages[i].GetName() == "Flash" && data > storages[i].GetMemery() && storages[i].GetMemery() == 0)
                    {
                        storages[countStorages] = new Flash();
                        countStorages++;
                    }
                    else if (storages[i].GetName() == "Flash" && data < storages[i].GetMemery() && storages[i].GetMemery() > 0)
                    {
                        if (storages[i].GetName() == "DVD" && data > storages[i].GetMemery() && storages[i].GetMemery() > 0)
                        {
                            data = storages[i].CopyingData(data);
                            elapsedTime += storages[i].GetTime(data);
                        }
                        else if (storages[i].GetName() == "DVD" && data > storages[i].GetMemery() && storages[i].GetMemery() == 0)
                        {
                            storages[countStorages] = new DVD();
                            countStorages++;
                        }
                    }
                }
                i++;
            }

            Console.WriteLine($"To transfer the information it took: {countStorages}");
            Console.WriteLine($"The time it took to transfer information: {elapsedTime}");
        }
    }
}
