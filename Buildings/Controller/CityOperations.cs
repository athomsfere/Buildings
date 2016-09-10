using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Buildings.Controller
{
    public class CityOperations : DbContext
    {
        public City GetCity(string CityName, string CityState)
        {
            using (var cities = new BuildingModel())
            {
                var result = cities.Cities.Where
                    (
                        x => x.CityName == CityName
                        & x.StateName == CityState
                    );

                return result.FirstOrDefault();
            }
            
        }

        public Enums.SqlResult AddCity(string CityName, string State)
        {
            using (var cities = new BuildingModel())
            {
                try 
                {
                    if (GetCity(CityName, State) == null )
                    {
                        var result = new City()
                        {
                            StateName = State,
                            CityName = CityName
                        };
                        cities.Cities.Add(result);
                        cities.SaveChanges();
                        return Enums.SqlResult.Success;
                    }
                    else
                    {
                        return Enums.SqlResult.Duplicate;
                    }
                }
                catch
                {
                    return Enums.SqlResult.GenericError;
                }
            } 
        }
    }
}
