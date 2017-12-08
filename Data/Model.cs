using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Session SessionsId { get; set; }
        public Hall HallId { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

    }

    public class Session
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public Cinema CinemaId { get; set; }
        public Movie MovieId { get; set; }

        public Hall HallId { get; set; }

    }

    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public int Length { get; set; }
        public byte[] Image { get; set; }
        public string Tecnology { get; set; }
    }
    public class Hall
    {
        public int Id { get; set; }
        public int Seats { get; set; }
        public Cinema CinemaId { get; set; }
    }


}
