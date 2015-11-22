using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiREST.Models;

namespace WebApiREST.Controllers
{
    public class carController : ApiController
    {
        Car[] cars = new Car[]{
            new Car{idCar=1,name="Lamborghini",model=2012},
            new Car{idCar=2,name="BMW",model=2014},
            new Car{idCar=3,name="Kia",model=2010},
            new Car{idCar=4,name="Mazda",model=2015},
            new Car{idCar=5,name="Seat",model=2007},
        };

        public IEnumerable<Car> GetAllCars()
        {
            return cars;
        }

        public IHttpActionResult GetCar(int id)
        {
            var car = cars.FirstOrDefault((c)=>c.idCar==id);
            if (car != null)
            {
                return Ok(car);
            }
            else
            {
                return NotFound();
            }

        }
    }
}
