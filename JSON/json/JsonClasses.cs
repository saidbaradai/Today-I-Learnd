using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Static.Data
{
    public class JsonClasses
    {



    }




    public class County
    {
        public int CountyID { get; set; }
        public int CityID { get; set; }
        public string CountyName { get; set; }
        public int UyapCountyCode { get; set; }
        public bool IsDeleted { get; set; }
        public int Region { get; set; }
    }
    public class City
    {
        public int CityID { get; set; }
        public string CityName { get; set; }
        public bool IsDeleted { get; set; }
    }




    public class JsonOperations
    {

        public static DataTable ReadCity()
        {


            var file = @"C:\Users\saeed\source\repos\Test-Static\City.json";

            StreamReader streamReader = new StreamReader(file);
            string jsonString = streamReader.ReadToEnd();
            DataTable cities = (DataTable)JsonConvert.DeserializeObject(jsonString, typeof(DataTable));

            
            return cities;
        }


        public static DataView ReadCounty(string cityID)
        {


            var file = @"C:\Users\saeed\source\repos\Test-Static\County.json";

            StreamReader streamReader = new StreamReader(file);
            string jsonString = streamReader.ReadToEnd();
            DataTable counties = (DataTable)JsonConvert.DeserializeObject(jsonString, typeof(DataTable));

            DataView dv = new DataView(counties);
            dv.RowFilter = $"CityID={cityID}";
            return dv;
        }










    }
















}
