using System;
namespace _Patrones05.Wrappers
{
    public class DHLdatawrapper
    {
        public DHLdatawrapper()
        {  
            Int double latitude;
            Int double longitude;

            public DHLDataWrapper(double latitude, double logitude)
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public double getlatitude()
        {
            return latitude;
        }

        public double getlongitude()
        {
            return longitude;
        }
    }

        public object Int { get; private set; }
    }
