using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeWorks.Confuragation
{
    public class VehicleConfuragation : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasData(
                new Vehicle
                {
                    VehicleId = 1,
                    PersonId = 1,
                    BrandName = "BMW",
                    Model = "X5",
                    ManufacturedDate = DateTime.Now.AddYears(-6),
                    Mileage = 400
                },
                new Vehicle
                {
                    VehicleId = 2,
                    PersonId = 1,
                    BrandName = "BMW",
                    Model = "X6",
                    ManufacturedDate= DateTime.Now.AddYears(-4),
                    Mileage = 300
                },
                new Vehicle
                {
                    VehicleId = 3,
                    PersonId = 2,
                    BrandName = "BMW",
                    Model = "X7",
                    ManufacturedDate = DateTime.Now.AddYears(-3),
                    Mileage = 200
                },
                new Vehicle
                {
                    VehicleId = 4,
                    PersonId = 2,
                    BrandName = "Chevralet",
                   Model = "C",
                   ManufacturedDate = DateTime.Now.AddYears(4),
                   Mileage = 350
                },
                new Vehicle
                {
                    VehicleId = 5,
                    PersonId = 3,
                    BrandName = "Cobolt",
                    Model = "Ravon",
                    ManufacturedDate = DateTime.Now.AddYears(-2),
                    Mileage = 200
                },
                new Vehicle
                {
                    VehicleId = 6,
                    PersonId = 3,
                    BrandName = "Nexia",
                    Model = "Devo",
                    ManufacturedDate = DateTime.Now.AddYears(-9),
                    Mileage = 500
                },
                new Vehicle
                {
                    VehicleId = 7,
                    PersonId = 4,
                    BrandName = "Gentra",
                    Model = "Tesla",
                    ManufacturedDate = DateTime.Now.AddYears(-2),
                    Mileage = 200
                },
                new Vehicle
                {
                    VehicleId = 8,
                    PersonId = 4,
                    BrandName = "Tiko",
                    Model = "Devo",
                    ManufacturedDate= DateTime.Now.AddYears(-17),
                    Mileage = 900
                });
        }
    }
}
