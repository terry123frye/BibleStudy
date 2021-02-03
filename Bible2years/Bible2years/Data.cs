using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bible2years
{
    public class Data
    {
        public List<DailyRead> Readings = new List<DailyRead>();
        public string startDate;
        public DateTime startDateDate;
        public DateTime currentDateDate = DateTime.Today;
        public int currentDayCount;
        public string ReadingIndication;

        public Data()
        {
            LoadData();
        }

        public void LoadData()
        {
            string fileName = ConfigurationManager.AppSettings["ReadingsFile"];
            string wasRead = ConfigurationManager.AppSettings["wasRead"];
            startDate = ConfigurationManager.AppSettings["startDate"];
            
            startDateDate = DateTime.Parse(startDate);

            TimeSpan ts = currentDateDate.Subtract(startDateDate);
            currentDayCount = ts.Days;

            try
            { 
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    
                    while ((line = reader.ReadLine()) != null)
                    {
                        int indexWasRead = line.IndexOf(wasRead);
                        string chaptersTeRead = indexWasRead > -1 ? line.Substring(0, indexWasRead) : line;
                        DailyRead dailyRead = new DailyRead() { chaptersToRead = line, isRead = indexWasRead > -1 };
                        Readings.Add(dailyRead);
                    }
                }
            }  
            catch (Exception exp)  
            {  
                Console.WriteLine(exp.Message);  
            }
        }

        public Image NextPictureImage()
        {
            Image result;
            Random random = new Random();
            string imagesFolder = ConfigurationManager.AppSettings["ImagesFolder"];

            string[] fileEntries = Directory.GetFiles(imagesFolder);

            int entry = random.Next(0, fileEntries.Length - 1);
            result = Image.FromFile(fileEntries[entry]);

            return result;
        }

        public bool GetIsRead()
        {
            return Readings[currentDayCount].isRead;
        }

        public void GetNextDay()
        {
            currentDayCount = currentDayCount > 1 ? currentDayCount - 1 : 0;
        }

        public void GetPreviousDay()
        {
            currentDayCount = currentDayCount < Readings.Count - 1 ? currentDayCount + 1 : Readings.Count - 1;
        }

        public string GetStartDay()
        {
            return "Start Day: " + startDateDate.ToShortDateString();
        }

        public string GetCurrentDay()
        {
            currentDateDate = startDateDate + TimeSpan.FromDays(currentDayCount);
            return ConfigurationManager.AppSettings["CurrentDayLiteral"] + " "  + currentDateDate.ToShortDateString();
        }

        public string GetCurrentReading(int dayCount)
        {
            string result = "";
            string wasRead = ConfigurationManager.AppSettings["wasRead"];

            string raw = Readings[dayCount].chaptersToRead;
            int indexWasRead = raw.IndexOf(wasRead);
            var period = raw.IndexOf('.') + 1;
            result = indexWasRead > -1 ? raw.Substring(period, indexWasRead-period) : raw.Substring(period);

            ReadingIndication = Readings[dayCount].isRead ? ConfigurationManager.AppSettings["HasBeenRead"] : ConfigurationManager.AppSettings["NotYetRead"];

            return result;
        }

        public void MarkAsRead()
        {
            string fileName = ConfigurationManager.AppSettings["ReadingsFile"];
            string wasRead = ConfigurationManager.AppSettings["wasRead"];

            if (Readings[currentDayCount].isRead) return;

            Readings[currentDayCount].isRead = true;
            Readings[currentDayCount].chaptersToRead = Readings[currentDayCount].chaptersToRead.Trim() + "     " + wasRead;

            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    // 1. Genesis 1-2  !This was Read!
                    foreach (var item in Readings)
                    {
                        writer.WriteLine(item.chaptersToRead);
                    }
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }

        public RefreshValues GetRefreshValues()
        {
            RefreshValues newValues = new RefreshValues();
            
            newValues.VersesToRead = GetCurrentReading(currentDayCount);
            newValues.Start = GetStartDay();
            newValues.Current = GetCurrentDay();
            newValues.ReadIndicator = ReadingIndication;
            newValues.IsRead = !GetIsRead();
            newValues.image = NextPictureImage();

            return newValues;
        }
    }
}
