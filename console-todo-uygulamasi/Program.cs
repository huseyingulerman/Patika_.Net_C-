﻿namespace console_todo_uygulamasi
{
    public class Program
    {
        static void Main(string[] args)
        {
            //TODO:
            //AddCard +
            //List +
            //DeleteCard +
            //MoveCard +
            //Tüm methodlar çalışmaktadır.
             static void Menu()
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
                Console.WriteLine("******************");
                Console.WriteLine(""
                    + "1- Board Listeleme \n"
                    + "2- Board'a Kart Ekleme \n"
                    + "3- Board'dan Kart Silme \n"
                    + "4- Kart Taşıma \n"
                    );
                Console.WriteLine("******************");
            }
            static void Main(string[] args)
            {

                Board board = new Board();
                Menu(); // Açılışta kullanıcını menuyu görüntüler
                int input;
                //Kullanıcı menu ekranında yanlış giriş yaptığı sürece menu tekrarlanır
                while ((!int.TryParse(Console.ReadLine(), out input)) || input < 0 || input > 4)
                {
                    Menu();
                }
                switch (input)
                {
                    case 1:
                        board.List();
                        break;

                    case 2:
                        board.AddCard();
                        break;

                    case 3:
                        board.DeleteCard();
                        break;

                    case 4:
                        board.MoveCard();
                        break;

                    default:
                        Console.WriteLine("Hatalı seçim yaptınız!");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}