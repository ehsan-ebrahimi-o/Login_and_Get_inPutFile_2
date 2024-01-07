using Microsoft.AspNetCore.Identity;
using System;
using System.Net.Cache;

namespace Login_and_Get_inPutFile_2.Models
{
    public static class Repository
    {
        public static List<PersonViewModel> Peaple = new List<PersonViewModel>()
       {
           new PersonViewModel() {FullName="hesam",Email="hesam@gmail.com",Age="22",CityBurn="Ghochan",Aboutself="Im student",Password="1234",ImageName="ahmad.jpg"},
           new PersonViewModel() {FullName="homayon",Email="homayon@gmail.com",Age="20",CityBurn="Mashhad",Aboutself="Im Teacher",Password="131321",ImageName="erfan.jpg"}
       };
    }
}

/* public string FullName { get; set; }

public string Email { get; set; }

public string Age { get; set; }

public string CityBurn { get; set; }

public string Aboutself { get; set; }

public string Mobile { get; set; }

public string Password { get; set; }

public IFormFile File { get; set; }

public string ImageName { get; set; } */