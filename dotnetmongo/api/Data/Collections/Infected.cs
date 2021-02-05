using System;
using MongoDB.Driver.GeoJsonObjectModel;


namespace api.Data.Collections
{
    public class Infected
    {
        public Infected (DateTime Birthday, string Gender, double latitude, double longitude)
        {
            this.Birthday = Birthday; 
            this.Gender = Gender; 
            this.Location = new GeoJson2DGeographicCoordinates(longitude, latitude);

        }
        public DateTime Birthday {get; set;}
        public string Gender { get; set;}
        public GeoJson2DGeographicCoordinates Location { get; set;}
        
    }
}