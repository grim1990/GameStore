using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Store
{
    class GamesSample
    {
        public static List<Games> CreateGamesSample()
        {
            List<Games> game = new List<Games>();

            Games game0 = new Games();
            game0.id = 1;
            game0.Name = "Gothic";
            game0.Type = "RPG";
            game0.Description = "Gra o bezimiennym.";
            game0.Price = 19.99;

            Games game1 = new Games();
            game1.id = 2;
            game1.Name = "Diablo";
            game1.Type = "RPG";
            game1.Description = "Gra komputerowa z gatunku hack and slash.";
            game1.Price = 1.99;

           /* Games game2 = new Games();
            game2.id = 3;
            game2.Name = "Dead by Daylight";
            game2.Type = "Survival";
            game2.Description = "Survival horror z asymetrycznym trybem rozgrywki wieloosobowej.";
            game2.Price = 79.99;

            Games game3 = new Games();
            game3.id = 4;
            game3.Name = "Minecraft";
            game3.Type = "Survival";
            game3.Description = "gra survivalowo-eksploracyjna, w której wymagana jest kreatywność.";
            game3.Price = 99.99;
            Games game4 = new Games();
            game4.id = 5;
            game4.Name = "Raft";
            game4.Type = "Survival";
            game4.Description = "Gra survivalowa, w której walczymy o przetrwanie, dryfując po morzu na drewnianej tratwie.";
            game4.Price = 59.99;

            Games game5 = new Games();
            game5.id = 6;
            game5.Name = "CS:GO";
            game5.Type = "FPS";
            game5.Description = "Turowa gra FPS, w której przeciwko sobie grają terroryści i antyterroryści.";
            game5.Price = 29.99;

            Games game6 = new Games();
            game6.id = 7;
            game6.Name = "GTA V";
            game6.Type = "Akcja";
            game6.Description = "Kolejna odsłona serii gangsterskich gier akcji mająca miejsce w mieście Los Santos.";
            game6.Price = 39.99;*/

            game.Add(game0);
            game.Add(game1);
           /* game.Add(game2);
            game.Add(game3);
            game.Add(game4);
            game.Add(game5);
            game.Add(game6);*/

            return game;
        }
    }
}