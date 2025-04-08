using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars.Models;
using Microsoft.EntityFrameworkCore;

namespace DataContext.Seed
{
    public class DataSeed
    {
        private static List<Car> carList = new List<Car>
        {
            new Car 
            {
                Id=1, 
                Name = "BMW"
            },
            new Car
            {
                Id = 2,
                Name = "Audi"
            },
            new Car
            {
                Id = 3,
                Name = "Peugeot" 
            }
        };
        private static List<Fuel> fuelList = new List<Fuel>
        {
            new Fuel
            {
                Id=1,
                Name = "Gasoline",
                PricePerLeter = 1
            },
            new Fuel
            {
                Id = 2,
                Name = "Diesel",
                PricePerLeter = 1
            },
        };
        private static List<Model> modelList = new List<Model>
        {
            new Model
            {
                Id=1,
                Name = "M3",
                Year = 2014,
                Consumption=8.8,
                Height=1.5,
                Length=4.5,
                Width=2,
                CarId=carList[0].Id

            },
            new Model 
            {
                Id = 2,
                Name = "A4",
                Year = 2014,
                Consumption = 4.2,
                Height = 1.4,
                Length = 4.3,
                Width = 1.9,
                CarId = carList[1].Id
            },
            new Model 
            {
                Id =3,
                Name = "508",
                Year = 2014,
                Consumption = 4,
                Height = 1.6,
                Length = 4.7,
                Width = 2.1,
                CarId = carList[2].Id
            }
        };
        private static List<Engine> engineList = new List<Engine>
        {
            new Engine
            {
                Id=1, 
                Name = "3.0",
                Torque=850, 
                HorsePower=431,
                CylinderCount =6,
                FuelId = carList[0].Id
            },
            new Engine
            {
                Id = 2,
                Name = "2.0 TDI ultra",
                Torque = 380,
                HorsePower = 163,
                CylinderCount = 4,
                FuelId = carList[1].Id
            },
            new Engine
            {
                Id = 3,
                Name = "2.0 BlueHDi",
                Torque = 370,
                HorsePower = 150,
                CylinderCount = 4,
                FuelId = carList[1].Id
            }
        };
        private static List<ModelEngine> modelengineList = new List<ModelEngine>
        {
            new ModelEngine
            {
                Id=1,
                Name= modelList[0].Name + " " + engineList[0].Name,
                ModelId = modelList[0].Id,
                EngineId = engineList[0].Id
            },
            new ModelEngine
            {
                Id = 2,
                Name= modelList[1].Name + " " + engineList[1].Name,
                ModelId = modelList[1].Id,
                EngineId = engineList[1].Id
            },
            new ModelEngine
            {
                Id = 3,
                Name= modelList[2].Name + " " + engineList[2].Name,
                ModelId = modelList[2].Id,
                EngineId = engineList[2].Id
            }
        };
        public static void ExampleSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(carList);
            modelBuilder.Entity<Model>().HasData(modelList);
            modelBuilder.Entity<Engine>().HasData(engineList);
            modelBuilder.Entity<ModelEngine>().HasData(modelengineList);
            modelBuilder.Entity<Fuel>().HasData(fuelList);
        }
    }
}
