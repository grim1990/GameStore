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

            Games game1 = new Games();
            game1.id = 1;
            game1.Name = "Gothic";
            game1.Type = "RPG";
            game1.Description = "Gra o bezimiennym.";
            game1.Price = 19.99;

            Games game2 = new Games();
            game2.id = 2;
            game2.Name = "Diablo";
            game2.Type = "RPG";
            game2.Description = "Gra komputerowa z gatunku hack and slash.";
            game2.Price = 1.99;

            Games game3 = new Games();
            game3.id = 3;
            game3.Name = "Dead by Daylight";
            game3.Type = "Survival";
            game3.Description = "Survival horror z asymetrycznym trybem rozgrywki wieloosobowej.";
            game3.Price = 79.99;

            Games game4 = new Games();
            game4.id = 4;
            game4.Name = "Minecraft";
            game4.Type = "Survival";
            game4.Description = "gra survivalowo-eksploracyjna, w której wymagana jest kreatywność.";
            game4.Price = 99.99;

            Games game5 = new Games();
            game5.id = 5;
            game5.Name = "CS:GO";
            game5.Type = "FPS";
            game5.Description = "Turowa gra FPS, w której przeciwko sobie grają terroryści i antyterroryści.";
            game5.Price = 29.99;
 
            Games game6 = new Games();
            game6.id = 6;
            game6.Name = "Rainbow Six Siege";
            game6.Type = "FPS";
            game6.Description = "Antyterroryści próbują unicestwić swoich przeciwników, którzy barykadują się w obleganym budynku.";
            game6.Price = 79.99;

            Games game7 = new Games();
            game7.id = 7;
            game7.Name = "Star Wars: Battlefront 2";
            game7.Type = "Action";
            game7.Description = "Kolejna odsłona gier osadzonych w świecie Gwiezdnych Wojen.";
            game7.Price = 39.99;

            Games game8 = new Games();
            game8.id = 8;
            game8.Name = "Left 4 Dead 2";
            game8.Type = "Action";
            game8.Description = "Kooperacyjna gra, w której mierzymy się przeciw zombie.";
            game8.Price = 39.99;

            game.Add(game1);
            game.Add(game2);
            game.Add(game3);
            game.Add(game4);
            game.Add(game5);
            game.Add(game6);
            game.Add(game7);
            game.Add(game8);

            return game;
        }
    }
}