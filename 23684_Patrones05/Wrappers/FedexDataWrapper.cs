using System;
namespace _Patrones05.Wrappers
{
    public class FedexDataWrapper
    {
        public FedexDataWrapper()
        {
        private String office;

        public FedexDataWrapper(String office)
        {
            this.office = office;
        }

        public String getOffice()
        {
            return office;
        }
    }
}