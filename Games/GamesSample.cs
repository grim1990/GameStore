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

            Games game2 = new Games();
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
             game6.Type = "Action";
             game6.Description = "Kolejna odsłona serii gangsterskich gier akcji mająca miejsce w mieście Los Santos.";
             game6.Price = 39.99;

            Games game7 = new Games();
            game7.id = 8;
            game7.Name = "Wiedźmin 2";
            game7.Type = "RPG";
            game7.Description = "Kontynuacja przygody Geralta z Rivii.";
            game7.Price = 19.99;

            Games game8 = new Games();
            game8.id = 9;
            game8.Name = "Wiedźmin 3";
            game8.Type = "RPG";
            game8.Description = "Kolejna kontynuacja przygód Geralta z Rivii.";
            game8.Price = 49.99;

            Games game9 = new Games();
            game9.id = 10;
            game9.Name = "The Forest";
            game9.Type = "Survival";
            game9.Description = "Po katastrofie samolotu bohater musi przeżyć na tajemniczej wyspie.";
            game9.Price = 29.99;

            Games game10 = new Games();
            game10.id = 11;
            game10.Name = "Overwatch";
            game10.Type = "FPS";
            game10.Description = "Gra FPS, gdzie walczymy z przeciwnikami w czasie rzeczywistym.";
            game10.Price = 69.99;

            Games game11 = new Games();
            game11.id = 12;
            game11.Name = "Rainbow Six Siege";
            game11.Type = "FPS";
            game11.Description = "Antyterroryści próbują unicestwić swoich przeciwników, którzy barykadują się w obleganym budynku.";
            game11.Price = 79.99;

            Games game12 = new Games();
            game12.id = 13;
            game12.Name = "Call of Duty: Modern Warfare";
            game12.Type = "FPS";
            game12.Description = "Kolejna odsłona serii gier FPS osadzona w realnym świecie.";
            game12.Price = 89.99;

            Games game13 = new Games();
            game13.id = 14;
            game13.Name = "Star Wars: Battlefront 2";
            game13.Type = "Action";
            game13.Description = "Kolejna odsłona gier osadzonych w świecie Gwiezdnych Wojen.";
            game13.Price = 39.99;

            Games game14 = new Games();
            game14.id = 15;
            game14.Name = "Dying Light";
            game14.Type = "Action";
            game14.Description = "Walka w mieście objętym kwarantanną.";
            game14.Price = 49.99;

            Games game15 = new Games();
            game15.id = 16;
            game15.Name = "Left 4 Dead 2";
            game15.Type = "Action";
            game15.Description = "Kooperacyjna gra, w której mierzymy się przeciw zombie.";
            game15.Price = 39.99;

            game.Add(game0);
            game.Add(game1);
            game.Add(game2);
            game.Add(game3);
            game.Add(game4);
            game.Add(game5);
            game.Add(game6);
            game.Add(game7);
            game.Add(game8);
            game.Add(game9);
            game.Add(game10);
            game.Add(game11);
            game.Add(game12);
            game.Add(game13);
            game.Add(game14);
            game.Add(game15);

            return game;
        }
    }
}