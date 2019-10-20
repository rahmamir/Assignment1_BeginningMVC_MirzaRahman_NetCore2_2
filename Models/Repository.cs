using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1_BeginningMVC_MirzaRahman_NetCore2_2.Models
{
    public static class Repository
    {
        public static List<Request> _listOfRequests;
        private static int ID;

        static Repository()
        {
            ID = 0;
            _listOfRequests = new List<Request>();
        }

        public static List<Request> Requests => _listOfRequests;

        public static void AddToRepository(Request request)
        {
            request.ID = ID;
            _listOfRequests.Add(request);
            ID++;
        }
    } 
}
