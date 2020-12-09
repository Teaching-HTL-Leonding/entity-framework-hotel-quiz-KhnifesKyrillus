﻿using System.Collections.Generic;

namespace HotelExercise.Model
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Adress Adress { get; set; }
        public List<Speciality> Specialities { get; set; }
        public List<RoomType> Rooms { get; set; }
    }
}