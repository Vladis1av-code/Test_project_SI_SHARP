using System;
using System.IO;

using System.Xml.Linq;
using System.Reflection.Metadata;
using System.Data.SqlClient;


namespace Championship
{
    //_______________________________________________________________________
    public class Team
    {
        public string Name { get; set; }
        public List<Player> Players { get; set; }
    }

    public class Player
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public string Position { get; set; }
    }
    public class Match
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public int ScoreTeam1 { get; set; }
        public int ScoreTeam2 { get; set; }
        public DateTime MatchDate { get; set; }

        public override string ToString()
        {
            return $"{Team1} - {Team2}: {ScoreTeam1} - {ScoreTeam2}";
        }
    }

    //_______________________________________________________________________

    internal class Program
    {
        private static Team team1;
        private static Team team2;

        static void Main(string[] args)
        {
            Console.WriteLine("Меню");
            Console.WriteLine("____________________________________");
            Console.WriteLine("1.Вести данные про команду");
            Console.WriteLine("2.Вывести данные про команду ");
            Console.WriteLine("____________________________________");
            Console.Write("Введите цифру:");
            string choice_menu=Console.ReadLine();

             if (choice_menu == "1")
             {
                Console.WriteLine("Меню");
                Console.WriteLine("1.Вести название команды определеной страны");
                Console.WriteLine("2.Вести название города определеной команды");
                Console.WriteLine("3.Вести количество побед определеной команды");
                Console.WriteLine("4.Вести количество поражений определеной команды");
                Console.WriteLine("5.Вести количество игор в ничью определеной команды");
                Console.WriteLine("6.Вести Ф.И.О игорока с опрделеной команды");
                Console.WriteLine("7.Вести страну опреденой команды");
                Console.WriteLine("8.Вести номер определоного игрока");
                Console.WriteLine("9.Вести позицию определеного игрока");
                Console.WriteLine("10.Создать игру между 2 командами");
                string choice_menu_2=Console.ReadLine();
                if (choice_menu_2 == "1")
                {
                    string sql_print_1 = "INSERT INTO Football_Command(TeamName,Nation) VALUES (@TeamName @Nation)";
                    string Sql_connection = "Data Source=DESKTOP-M09DVFG;Initial Catalog=Spanush_Football_Championship;Integrated Security=True;";
                    Console.WriteLine("Введите название команды:");
                    string print_Name_Command = Console.ReadLine();
                    Console.WriteLine("Введите страну команды:");
                    string print_nation = Console.ReadLine();

                    using (SqlCommand command = new SqlCommand(sql_print_1, Sql_connection))
                    {
                        command.Parameters.AddWithValue("@TeamName", print_Name_Command);
                        command.Parameters.AddWithValue("@Nation", print_nation);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Вы успешно записали название команды");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Извините мы не смогли записать название команды");
                            return;
                        }
                    }
                }
                else if (choice_menu_2 == "2")
                {
                    string sql_print_2 = "INSERT INTO Football_Command(TeamName,City)VALUES (@TeamName @City)";
                    string Sql_connection = "Data Source=DESKTOP-M09DVFG;Initial Catalog=Spanush_Football_Championship;Integrated Security=True;";
                    Console.WriteLine("Введите название команды:");
                    string print_Name_Command_2 = Console.ReadLine();
                    Console.WriteLine("Введите название города:");
                    string print_city = Console.ReadLine();

                    using (SqlCommand command = new SqlCommand(sql_print_2, Sql_connection))
                    {
                        command.Parameters.AddWithValue("@TeamName", print_Name_Command_2);
                        command.Parameters.AddWithValue("@City", print_city);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Информация была успешно записана");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Извините произошла ошибка");
                            return;
                        }
                    }
                }
                else if (choice_menu_2 == "3")
                {
                    string sql_print_3 = "INSERT INTO Football_Command(TeamName,Wins) VALUES (@TeamName,@Wins)";
                    string Sql_connection = "Data Source=DESKTOP-M09DVFG;Initial Catalog=Spanush_Football_Championship;Integrated Security=True;";
                    Console.WriteLine("Введите название команды:");
                    string print_name_command = Console.ReadLine();
                    Console.WriteLine("Введите количество побед:");
                    string print_wins_command = Console.ReadLine();

                    using (SqlCommand command = new SqlCommand(sql_print_3, Sql_connection))
                    {
                        command.Parameters.AddWithValue("@TeamName", print_name_command);
                        command.Parameters.AddWithValue("@Wins", print_wins_command);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Информация была успешно записана");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Извините произошла ошибка");
                            return;
                        }
                    }
                }
                else if (choice_menu_2 == "4")
                {
                    string sql_print_4 = "INSERT INTO Football_Command(TeamName,Losses) VALUES(@TeamName,@Losses)";
                    string Sql_connection = "Data Source=DESKTOP-M09DVFG;Initial Catalog=Spanush_Football_Championship;Integrated Security=True;";
                    Console.WriteLine("Введите название команды:");
                    string print_name_command_1 = Console.ReadLine();
                    Console.WriteLine("Введите количество поражений:");
                    string print_Losses = Console.ReadLine();

                    using (SqlCommand command = new SqlCommand(sql_print_4, Sql_connection))
                    {
                        command.Parameters.AddWithValue("@TeamName", print_name_command_1);
                        command.Parameters.AddWithValue("@Losses", print_Losses);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Информация была успешно записана");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Извините произошла ошибка");
                            return;
                        }
                    }
                }
                else if (choice_menu_2 == "5")
                {
                    string sql_print_5 = "INSERT INTO Football_Command(TeamName,Draw) VALUES (@TeamName,@Draw)";
                    string Sql_connection = "Data Source=DESKTOP-M09DVFG;Initial Catalog=Spanush_Football_Championship;Integrated Security=True;";
                    Console.WriteLine("Введите название команды:");
                    string print_name_command_2 = Console.ReadLine();
                    Console.WriteLine("Введите количество игор в ничью:");
                    string print_Draw = Console.ReadLine();

                    using (SqlCommand command = new SqlCommand(sql_print_5, Sql_connection))
                    {
                        command.Parameters.AddWithValue("@TeamName", print_name_command_2);
                        command.Parameters.AddWithValue("@Draw", print_Draw);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Информация была успешно записана");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Извините произошла ошибка");
                            return;
                        }
                    }
                }
                else if (choice_menu_2 == "6")
                {
                    string sql_print_6 = "INSERT INTO Football_Command(TeamName) VALUES (@TeamName)";
                    string sql_print_6_6 = "INSERT INTO Player(number_play,full_name_play) VALUES (@number_play,@full_name_play)";
                    string Sql_connection = "Data Source=DESKTOP-M09DVFG;Initial Catalog=Spanush_Football_Championship;Integrated Security=True;";
                    Console.WriteLine("Введите команду");
                    string print_name_command_3= Console.ReadLine();
                    Console.WriteLine("Введите номер команды");
                    string print_number_play_9_9= Console.ReadLine();
                    Console.WriteLine("Введите Ф.И.О игрока:");
                    string print_full_name_9_9= Console.ReadLine();

                         using (SqlCommand command = new SqlCommand(sql_print_6, Sql_connection))
                         {
                        command.Parameters.AddWithValue("@TeamName",print_name_command_3 );
                    

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Информация была успешно записана");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Извините произошла ошибка");
                            return;
                        }
                        using(SqlCommand command1=new SqlCommand(sql_print_6_6,Sql_connection))
                        {
                            command1.Parameters.AddWithValue("@number_play",print_number_play_9_9);
                            command1.Parameters.AddWithValue("@full_name_play",print_full_name_9_9);
                            int rowsAffected_1 = command.ExecuteNonQuery();
                            if (rowsAffected_1 > 0)
                            {
                                Console.WriteLine("Информация была успешно записана");
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Извините произошла ошибка");
                                return;
                            }

                            }
                    }
                }
                else if (choice_menu_2 == "7")
                {
                    string sql_print_7 = "INSERT INTO Football_Command(Nation,TeamName) VALUES (@Nation,@TeamName)";
                    string Sql_connection = "Data Source=DESKTOP-M09DVFG;Initial Catalog=Spanush_Football_Championship;Integrated Security=True;";
                    Console.WriteLine("Введите страну команды:");
                    string print_nation_7_7= Console.ReadLine();
                    Console.WriteLine("Введите команду:");
                    string print_TeamName_1=Console.ReadLine();

                         using (SqlCommand command = new SqlCommand(sql_print_7, Sql_connection))
                    {
                        command.Parameters.AddWithValue("@Nation", print_nation_7_7);
                        command.Parameters.AddWithValue("@TeamName", print_TeamName_1);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Информация была успешно записана");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Извините произошла ошибка");
                            return;
                        }
                    }
                }
                else if (choice_menu_2 == "8")
                {
                    string sql_print_8 = "INSERT INTO Football_Command(TeamName) VALUES (@TeamName)";
                    string sql_print_8_8 = "INSERT INTO Player(number_play,full_name_play) VALUES (@number_play,@full_name_play)";
                    string Sql_connection = "Data Source=DESKTOP-M09DVFG;Initial Catalog=Spanush_Football_Championship;Integrated Security=True;";
                    Console.WriteLine("Введите команду игрока:");
                    string print_Name_command_3 = Console.ReadLine();
                    Console.WriteLine("Введите номер игорока:");
                    string print_number_player_1 = Console.ReadLine();
                    Console.WriteLine("Введите Ф.И.О игрока:");
                    string print_full_name_player = Console.ReadLine();

                    using (SqlCommand command = new SqlCommand(sql_print_8, Sql_connection))
                    {
                        command.Parameters.AddWithValue("@TeamName", print_Name_command_3);
                       

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Информация была успешно записана");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Извините произошла ошибка");
                            return;
                        }
                    }

                    using(SqlCommand command1=new SqlCommand(sql_print_8_8,Sql_connection))
                    {
                        command1.Parameters.AddWithValue("@number_play", print_number_player_1);
                        command1.Parameters.AddWithValue("@full_name_play", print_full_name_player);
                        int rowsAffected = command1.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Информация была успешно записана");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Извините произошла ошибка");
                            return;
                        }
                    }
                }
                else if (choice_menu_2 == "9")
                {
                    string sql_print_9 = "INSERT INTO Football_Command(TeamName) VALUES (@TeamName)";
                    string sql_print_9_9 = "INSERT INTO Player(number_play) VALUES(@number_play)";
                    string Sql_connection = "Data Source=DESKTOP-M09DVFG;Initial Catalog=Spanush_Football_Championship;Integrated Security=True;";
                    Console.WriteLine("Введите команду игрока:");
                    string print_Name_command_4 = Console.ReadLine();
                    Console.WriteLine("Введите номер игрока:");
                    string print_number_player1 = Console.ReadLine();

                    using (SqlCommand command = new SqlCommand(sql_print_9, Sql_connection))
                    {
                        command.Parameters.AddWithValue("@TeamName", print_Name_command_4);
                        

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Информация была успешно записана");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Извините произошла ошибка");
                            return;
                        }
                    }
                    using(SqlCommand command1= new SqlCommand(sql_print_9_9,Sql_connection))
                    {
                        command1.Parameters.AddWithValue("@number_play", print_number_player1);

                        int rowsAffected = command1.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Информация была успешно записана");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Извините произошла ошибка");
                            return;
                        }
                    }
                }
                else if (choice_menu_2 == "10")
                {
                    string play_match_sql = "INSERT INTO Play(Team_1,Team_2,Match_Team) VALUES (@Team_1,@Team_2,@Match_Team)";
                    string Sql_connection = "Data Source=DESKTOP-M09DVFG;Initial Catalog=Spanush_Football_Championship;Integrated Security=True;";

                    Console.WriteLine("Введите название первой команды:");
                    string team1Name = Console.ReadLine();
                    Console.WriteLine("Введите название второй команды:");
                    string team2Name = Console.ReadLine();
                 
                  static void SimulateMatch(Match match)
                    {
                        // Упрощенная симуляция: рандомный результат
                        Random random = new Random();
                        match.ScoreTeam1 = random.Next(0, 5);
                        match.ScoreTeam2 = random.Next(0, 5);
                    }
                    // Создание матча
                    Match match = new Match();
                    match.Team1 = team1;
                    match.Team2 = team2;

                    // Симуляция игры
                    SimulateMatch(match);
                    Console.WriteLine("Игра была успешно проведена");
                    // Вывод результата
                    Console.WriteLine($"Результат игры:");
                    Console.WriteLine(match);

                    using(SqlCommand command=new SqlCommand(play_match_sql,Sql_connection))
                    {
                        command.Parameters.AddWithValue("@Team_1",team1Name);
                        command.Parameters.AddWithValue("@Team_2",team2Name);
                        command.Parameters.AddWithValue("@Match_Team",match);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Информация была успешно записана");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Извините произошла ошибка");
                            return;
                        }
                    }
                   
                }
                else
                {
                    Console.WriteLine("Error");
                    return;
                }
            } 
             else if (choice_menu == "2")
            {
                Console.WriteLine("Меню");
                Console.WriteLine("1.Показать название команды");
                Console.WriteLine("2.Показать город команды");
                Console.WriteLine("3.Показать количество побед");
                Console.WriteLine("4.Показать количество поражение");
                Console.WriteLine("5.Показать колчество игор в ничью");
                Console.WriteLine("6.Показать Ф.И.О игроков определеной команды");
                Console.WriteLine("7.Показать страну определеной команды");
                Console.WriteLine("8.Показать номер опеределеного игрока");
                Console.WriteLine("9.Показать позицию определеного игорока");
                Console.WriteLine("10.Показать результаты поединка между 2 командами");
                Console.Write("Введите цифру:");
                string choice_user = Console.ReadLine();


                if (choice_user == "1")
                {
                    string sql = "SELECT * FROM Football_Command WHERE TeamName=@TeamName";
                    string Sql_connection = "Data Source=DESKTOP-M09DVFG;Initial Catalog=Spanush_Football_Championship;Integrated Security=True;";
                    Console.WriteLine("Введите страну команды:");
                    string choice_name_nation_1 = Console.ReadLine();
                    using (SqlConnection connection = new SqlConnection(Sql_connection))
                    {
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                           
                            command.Parameters.AddWithValue("@TeamName", choice_name_nation_1);

                            try
                            {
                                connection.Open();
                                SqlDataReader reader = command.ExecuteReader();

                              
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
              
                                        Console.WriteLine("Название команды: " + reader.GetString(1));

                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Данные о команде не найдены.");
                                }

                                reader.Close();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Ошибка: " + ex.Message);
                            }
                        }
                    }
                    }
                else if (choice_user == "2")
                {
                    string sql = "SELECT * FROM Football_Command WHERE ";
                    string Sql_connection = "Data Source=DESKTOP-M09DVFG;Initial Catalog=Spanush_Football_Championship;Integrated Security=True;";
                    Console.WriteLine("Введите название команды:");
                    string choice_command_9 = Console.ReadLine();

                }
                else if (choice_user == "3")
                {
                    string sql = "";
                    string Sql_connection = "Data Source=DESKTOP-M09DVFG;Initial Catalog=Spanush_Football_Championship;Integrated Security=True;";
                    Console.WriteLine("Введите название команды:");
                    string choice_command_8 = Console.ReadLine();
                }
                else if (choice_user == "4")
                {
                    string sql = "";
                    string Sql_connection = "Data Source=DESKTOP-M09DVFG;Initial Catalog=Spanush_Football_Championship;Integrated Security=True;";
                    Console.WriteLine("Введите название команды:");
                    string choice_command_7 = Console.ReadLine();
                }
                else if (choice_user == "5")
                {
                    string sql = "";
                    string Sql_connection = "Data Source=DESKTOP-M09DVFG;Initial Catalog=Spanush_Football_Championship;Integrated Security=True;";
                    Console.WriteLine("Введите название команды:");
                    string choice_command_6 = Console.ReadLine();
                }
                else if (choice_user == "6")
                {
                    string sql = "";
                    string Sql_connection = "Data Source=DESKTOP-M09DVFG;Initial Catalog=Spanush_Football_Championship;Integrated Security=True;";
                    Console.WriteLine("Введите название команды:");
                    string choice_command_5 = Console.ReadLine();
                }
                else if (choice_user == "7")
                {
                    string sql = "";
                    string Sql_connection = "Data Source=DESKTOP-M09DVFG;Initial Catalog=Spanush_Football_Championship;Integrated Security=True;";
                    Console.WriteLine("Введите название команды:");
                    string choice_name_command_5 = Console.ReadLine();
                }
                else if (choice_user == "8")
                {
                    string sql = "";
                    string Sql_connection = "Data Source=DESKTOP-M09DVFG;Initial Catalog=Spanush_Football_Championship;Integrated Security=True;";
                    Console.WriteLine("Введите команду игрока:");
                    string choice_command_4 = Console.ReadLine();

                    Console.WriteLine("Введите имя игрока:");
                    string numbers_play_1 = Console.ReadLine();

                }
                else if (choice_user == "9")
                {
                    string sql = "";
                    string Sql_connection = "Data Source=DESKTOP-M09DVFG;Initial Catalog=Spanush_Football_Championship;Integrated Security=True;";
                    Console.WriteLine("Введите команду игрока:");
                    string choice_command_3 = Console.ReadLine();
                    Console.WriteLine("Введите номер игрока:");
                    string numbers_play_1 = Console.ReadLine();



                }
                else if (choice_user == "10")
                {
                    string sql = "";
                    string Sql_connection = "Data Source=DESKTOP-M09DVFG;Initial Catalog=Spanush_Football_Championship;Integrated Security=True;";
                    Console.WriteLine("Введите название первой команды:");
                    string command_1 = Console.ReadLine();
                    Console.WriteLine("Введите название второй команды:");
                    string command_2 = Console.ReadLine();
                    


                }
                else
                {
                    Console.WriteLine("Error");
                    return;
                }
            }
           
        }
    }
}
