using HRManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement
{
    internal static class DbConnector
    {
        private static HRManagementDBEntities dBEntities;
        public static HRManagementDBEntities DBEntities {  get { return dBEntities; } }

        public static void Save()
        {
            dBEntities.SaveChanges();
        }
        static DbConnector() {
            dBEntities = new HRManagementDBEntities();
        }
    }
}
