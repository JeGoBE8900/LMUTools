using System.Diagnostics.Tracing;

namespace LMUTools.Classes.LMURESTAPI
{

    public class LMUReplay
    {
        public int id { get; set; }
        public string metadata { get; set; }
        public string replayDirectory { get; set; }
        public string replayName { get; set; }
        public double size { get; set; }

        public double timestamp { get; set; }

        public DateTime CreateDate {  
            get
            {
                DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                dateTime = dateTime.AddSeconds(timestamp).ToLocalTime();
                return dateTime;
            }
        }

        public override string ToString()
        {
            return this.id + " - " + replayName + " - " + CreateDate.ToString("dd/MM/yyyy HH:mm:ss");
        }



    }

 
 }