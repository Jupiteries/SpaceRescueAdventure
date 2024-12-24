using System;
using System.Collections.Generic;


namespace SpaceRescueAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.Planets = new List<Planet>
            {
                 new Planet { Id = 1, Name = "Udarvis", Distance = 123, Astronauts = new List<Astronaut>
                                {
                                    new Astronaut{ Name = "Kevin Voss", Planet = "Udarvis"},
                                    new Astronaut{ Name = "Cassia Taylor", Planet = "Udarvis"},
                                    new Astronaut{ Name = "Nashira Drake", Planet = "Udarvis"},
                                    new Astronaut{ Name = "Kian Evans", Planet = "Udarvis"},
                                    new Astronaut{ Name = "Arabella Hayes", Planet = "Udarvis"},
                                } },
                new Planet { Id = 2, Name = "Imorra", Distance = 604, Astronauts = new List<Astronaut>
                                {
                                    new Astronaut{ Name = "Landon Liu", Planet = "Imorra"},
                                    new Astronaut{ Name = "Eliza Chen", Planet = "Imorra"},
                                    new Astronaut{ Name = "Jaxson Kim", Planet = "Imorra"},
                                    new Astronaut{ Name = "Emery Park", Planet = "Imorra"},
                                } },
                new Planet { Id = 3,  Name = "Gilea", Distance = 472, Astronauts = new List<Astronaut>
                                {
                                    new Astronaut{ Name = "Lena Lee", Planet = "Gilea"},
                                    new Astronaut{ Name = "Ethan Chen", Planet = "Gilea"},
                                    new Astronaut{ Name = "Avery Kim", Planet = "Gilea"},
                                    new Astronaut{ Name = "Leif Park", Planet = "Gilea"},
                                    new Astronaut{ Name = "Kiera Wong", Planet = "Gilea"},
                                } },
                new Planet { Id = 4, Name = "Thelea", Distance = 1586, Astronauts = new List<Astronaut>
                                {
                                    new Astronaut{ Name = "Carson Wu", Planet = "Thelea"},
                                    new Astronaut{ Name = "Olivia Chen", Planet = "Thelea"},
                                    new Astronaut{ Name = "Liliana Liu", Planet = "Thelea"},
                                    new Astronaut{ Name = "Samson Kim", Planet = "Thelea"},
                                    new Astronaut{ Name = "Aurora Lee", Planet = "Thelea"},
                                    new Astronaut{ Name = "Kael Park", Planet = "Thelea"},
                                } },
                new Planet { Id = 5, Name = "Sanilia", Distance = 1998, Astronauts = new List<Astronaut>
                                {
                                    new Astronaut{ Name = "Eliana Chen", Planet = "Sanilia"},
                                    new Astronaut{ Name = "Ezra Liu", Planet = "Sanilia"},
                                    new Astronaut{ Name = "Malia Kim", Planet = "Sanilia"},
                                    new Astronaut{ Name = "Niko Wong", Planet = "Sanilia"},
                                    new Astronaut{ Name = "Lysandra Lee", Planet = "Sanilia"},
                                    new Astronaut{ Name = "Milo Park", Planet = "Sanilia"},
                                    new Astronaut{ Name = "Isla Chen", Planet = "Sanilia"},
                                } },
                new Planet { Id = 6, Name = "Meruta", Distance = 4081, Astronauts = new List<Astronaut>
                                {
                                    new Astronaut{ Name = "Aurelia Kim", Planet = "Meruta"},
                                    new Astronaut{ Name = "Mason Liu", Planet = "Meruta"},
                                } },
                new Planet { Id = 7, Name = "Dricarro", Distance = 799, Astronauts = new List<Astronaut>
                                {
                                    new Astronaut{ Name = "Lilia Chen", Planet = "Dricarro"},
                                    new Astronaut{ Name = "Keenan Kim", Planet = "Dricarro"},
                                    new Astronaut{ Name = "Alessia Lee", Planet = "Dricarro"},
                                    new Astronaut{ Name = "Evelyn Park", Planet = "Dricarro"},
                                    new Astronaut{ Name = "Bodhi Liu", Planet = "Dricarro"},
                                    new Astronaut{ Name = "Gia Chen", Planet = "Dricarro"},
                                    new Astronaut{ Name = "Cillian Kim", Planet = "Dricarro"},
                                    new Astronaut{ Name = "Mira Lee", Planet = "Dricarro"},
                                    new Astronaut{ Name = "Aya Park", Planet = "Dricarro"},
                                    new Astronaut{ Name = "Mikael Liu", Planet = "Dricarro"},
                                    new Astronaut{ Name = "Anya Chen", Planet = "Dricarro"},
                                    new Astronaut{ Name = "Ronan Kim", Planet = "Dricarro"},
                                } },
                new Planet { Id = 8, Name = "Rion", Distance = 430, Astronauts = new List<Astronaut>
                                {
                                    new Astronaut{ Name = "Gwen Park", Planet = "Rion"},
                                    new Astronaut{ Name = "Silas Liu", Planet = "Rion"},
                                    new Astronaut{ Name = "Esme Chen", Planet = "Rion"},
                                    new Astronaut{ Name = "Tobin Kim", Planet = "Rion"},
                                    new Astronaut{ Name = "Felicity Lee", Planet = "Rion"},
                                    new Astronaut{ Name = "Rory Park", Planet = "Rion"},
                                } },
                new Planet { Id = 9, Name = "Uchilles", Distance = 196, Astronauts = new List<Astronaut>
                                {
                                    new Astronaut{ Name = "Hazel Liu", Planet = "Uchilles"},
                                    new Astronaut{ Name = "Flynn Chen", Planet = "Uchilles"},
                                    new Astronaut{ Name = "Coralie Kim", Planet = "Uchilles"},
                                    new Astronaut{ Name = "Kellen Lee", Planet = "Uchilles"},
                                    new Astronaut{ Name = "Elara Park", Planet = "Uchilles"},
                                } },
                new Planet { Id = 10, Name = "Lenia", Distance = 48, Astronauts = new List<Astronaut>
                                {
                                    new Astronaut{ Name = "Nova Chen", Planet = "Lenia"},
                                    new Astronaut{ Name = "Emmett Kim", Planet = "Lenia"},
                                    new Astronaut{ Name = "Aria Lee", Planet = "Lenia"},
                                    new Astronaut{ Name = "Gideon Park", Planet = "Lenia"},
                                    new Astronaut{ Name = "Maeve Liu", Planet = "Lenia"},
                                    new Astronaut{ Name = "Otto Chen", Planet = "Lenia"},
                                    new Astronaut{ Name = "Cassius Kim", Planet = "Lenia"},
                                    new Astronaut{ Name = "Lyra Lee", Planet = "Lenia"},
                                    new Astronaut{ Name = "Zephyr Park", Planet = "Lenia"},
                                    new Astronaut{ Name = "Aurelius Liu", Planet = "Lenia"},
                                    new Astronaut{ Name = "Eira Chen", Planet = "Lenia"},
                                } },
                new Planet { Id = 11, Name = "Nexor", Distance = 652, Astronauts = new List<Astronaut>
                                {
                                    new Astronaut{ Name = "Axl Kim", Planet = "Nexor"},
                                    new Astronaut{ Name = "Niamh Lee", Planet = "Nexor"},
                                    new Astronaut{ Name = "Soren Park", Planet = "Nexor"},
                                    new Astronaut{ Name = "Eliot Liu", Planet = "Nexor"},
                                    new Astronaut{ Name = "Tala Chen", Planet = "Nexor"},
                                    new Astronaut{ Name = "Cosmo Kim", Planet = "Nexor"},
                                    new Astronaut{ Name = "Maren Lee", Planet = "Nexor"},
                                    new Astronaut{ Name = "Orion Park", Planet = "Nexor"},
                                } }
            };
            Game.StartGame();
        }
    }
}
