﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoInsurance.Model;
using System.Data.Entity;

namespace AutoInsurance.Data
{
    public class CarRepository
    {
        public bool Save(Car obj)
        {
            try
            {

                Db db = new Db();
                db.Car.Add(obj);
                db.SaveChanges();


            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }

        public List<Car> FindAll()
        {
            /*Car gol = new Car();
            gol.Id = 1;
            gol.Manufacturer = "Volkswagen";
            gol.Model = "quadrado";
            gol.Photo = "http://www.freewords.com.br/wp-content/gallery/gol-quadrado-tuning/gol-quadrado-tunado-simplesmente-lindo-fotos-e-quadrado2.jpg";
            gol.Year = 1992;

            listaCar.Add(gol);
            Car corolla = new Car();
            corolla.Id = 2;
            corolla.Manufacturer = "Toyota";
            corolla.Model = "seminovo";
            corolla.Photo = "http://autodiario.files.wordpress.com/2007/05/toyota-corolla-s.jpg";
            corolla.Year = 2008;

            listaCar.Add(corolla);

            Car bmw = new Car();
            bmw.Id = 3;
            bmw.Manufacturer = "BMW";
            bmw.Model = "BMW Amarela";
            bmw.Photo = "http://memimage.cardomain.com/ride_images/3/3019/141/32545070001_large.jpg";
            bmw.Year = 1994;

            listaCar.Add(bmw);*/
            try
            {
                Db db = new Db();
                return db.Car.Where(i => i.Id > 0).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Car FindById(int Id)
        {
            return new Car();
        }

        public bool Delete(Car obj)
        {
            return true;
        }
    }
}