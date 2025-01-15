using System;
using System.IO;
using Microsoft.Office.Interop.Word;
using System.Drawing;
using System.Drawing.Imaging;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;


namespace Editor
{
    internal class Program
    {
      

        static void Main(string[] args)
        {
            Console.WriteLine("Меню");         
            Console.WriteLine("1.Создать");
            Console.WriteLine("2.Открыть");
            
            string print_user=Console.ReadLine();
            if(print_user =="1")
            {
                Console.WriteLine("Меню");
                Console.WriteLine("1.Создать текстовый документ");              
                Console.WriteLine("2.Создать вордовский документ");            
                Console.WriteLine("3.Создать фото с расширением png");
                Console.WriteLine("4.Создать фото с расширением jpg");
                string print_file=Console.ReadLine();

                if(print_file =="1")
                {
                    Console.WriteLine("Введите название текстововго документа:");
                    string choice_name_file=Console.ReadLine();
                    string file = $"{choice_name_file}.txt";
                    Console.WriteLine("Текстовый документ успешно создан");
                    Console.WriteLine("Желаете редактировать текстовый документ?");
                    Console.WriteLine("да/нет");
                    string choice_user_edit=Console.ReadLine();
                    if(choice_user_edit =="да") 
                    {
                        Console.WriteLine("Меню");
                        Console.WriteLine("1.Изменить название текстового документа");
                        Console.WriteLine("2.Копировать созданый текстовый документ");
                        Console.WriteLine("3.Записать в текстовый документ информацию");
                        Console.WriteLine("4.Показать в консоль что находится в текстовом документе");
                        Console.WriteLine("5.Сохранить текстовый докумет в указаное место");
                        Console.WriteLine("6.Сохранить текстовый документ под другим расширением"); 
                        string choice_menu=Console.ReadLine();
                        if(choice_menu =="1")
                        {
                            Console.WriteLine("Введите новое название файла:");
                            string choice_new_name_file_2=Console.ReadLine();
                            string NAMEfile = file;
                            string NAMEfile_2 =$"{choice_new_name_file_2}.txt";
                            try
                            {
                                File.Move(NAMEfile, NAMEfile_2);
                                Console.WriteLine("Файл успешно переименован");
                            }
                            catch(Exception ex) 
                            {
                                Console.WriteLine("Error");
                                return;
                            }
                        }
                        else if(choice_menu =="2")
                        {
                            Console.WriteLine($"Хотите копировать текстовый документ{file}?");
                            Console.WriteLine("да/нет");
                            string copy_file=Console.ReadLine();
                            if (copy_file=="да")
                            {
                                Console.WriteLine("Введите путь копии файла:");
                                string copy_file_2=Console.ReadLine();

                            }
                            else if(copy_file=="нет")
                            {
                                Console.WriteLine("Введите путь до файда:");
                                string user_copy_file=Console.ReadLine();

                                Console.WriteLine("Введите путь копии файла:");
                                string copy_file_3 = Console.ReadLine();

                                string sourceFile=user_copy_file;
                                string new_sourceFile = copy_file_3;

                                try
                                {
                                    using(StreamReader reader=new StreamReader(sourceFile))
                                    using(StreamWriter writer=new StreamWriter(new_sourceFile))
                                    {
                                        string line;
                                        while((line = reader.ReadLine()) != null)
                                        {
                                            writer.WriteLine(line);
                                        }
                                    }
                                }
                                catch(Exception ex) 
                                {
                                    Console.WriteLine("Ошибка при копировании файла"+ex.Message);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Error");
                                return;
                            }
                        }
                        else if(choice_menu =="3")
                        {
                            Console.WriteLine($"Записать информацию в этот текстовый документ {file}?");
                            Console.WriteLine("да/нет");
                            string choice_write_file_txt=Console.ReadLine();
                            if( choice_write_file_txt =="1")
                            {
                                Console.WriteLine("Введите текст который будет хранится в текстовом документе");
                                string text_file_user=Console.ReadLine();
                                File.WriteAllText(file, text_file_user);
                                Console.WriteLine("Информация успешно была записана в текстовый документ");
                            }
                            else if( choice_write_file_txt =="2")
                            {
                                Console.WriteLine("Введите путь до текстового файла:");
                                string choice_way=Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Error");
                                return;
                            }
                        }
                        else if(choice_menu =="4")
                        {
                            string file_p = file;
                            try
                            {
                                using (StreamReader reader = new StreamReader(file_p))
                                {
                                    string line;
                                    while ((line = reader.ReadLine()) != null)
                                    {
                                        
                                        string[] words = line.Split(' '); 
                                        foreach (string word in words)
                                        {
                                            Console.WriteLine(word);
                                        }
                                    }
                                }
                            }
                            catch (IOException e)
                            {
                                Console.WriteLine("Ошибка при чтении файла: " + e.Message);
                            }
                        }
                       else if(choice_menu =="5")
                        {
                            Console.WriteLine("Введите путь куда сохраним данные:");
                            string path_file=Console.ReadLine();
                            
                            string y = path_file;
                            try
                            {                           
                                using (StreamWriter writer = new StreamWriter(y))
                                {

                                    Console.WriteLine("Файл сохранен успешно!");
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Ошибка  в файле: " + ex.Message);
                            }
                        }
                        else if(choice_menu =="6")
                        {
                            Console.WriteLine($"Оставить прошлое название{choice_name_file}?");
                            Console.WriteLine("да/нет");
                            string new_name_file=Console.ReadLine();
                            if(new_name_file =="да") 
                            {
                                Console.WriteLine("Введите свое расширение:");
                                string file_extension=Console.ReadLine();
                                string new_file = $"{choice_name_file}.{file_extension}";
                                Console.WriteLine("Файл успешно создан");
                                return;

                            }
                            else if(new_name_file =="нет")
                            {
                                Console.WriteLine("Введите название файла:");
                                string new_name_files=Console.ReadLine();
                                Console.WriteLine("Введите свое расширение файла:");
                                string new_file_extension=Console.ReadLine();
                                string new_files = $"{new_name_files}.{new_file_extension}";
                                Console.WriteLine("Файл успешно создан");
                                return;
                            }
                           else
                            {
                                Console.WriteLine("Error");
                                return;
                            }
                           
                        }
                    }
                    else if(choice_user_edit =="нет")
                    {
                        Console.WriteLine("Вы успешно вышли из предложение");
                        return;
                    }
                }
                else if(print_file =="2")
                {
                    Console.WriteLine("Введите название файла:");
                    string name_word=Console.ReadLine();
                    Console.WriteLine("Введите текст который будет внутри файла:");
                    string text_word=Console.ReadLine();
                    Application wordApp=new Application();
                    wordApp.Visible = false;
                    Document doc = wordApp.Documents.Add();

                    Paragraph para1=doc.Content.Paragraphs.Add();
                    para1.Range.Text = text_word;
                    doc.SaveAs($"{name_word}.docx");
                    wordApp.Quit();
                }
                else if(print_file =="3")
                {
                  Console.WriteLine("Введите размер фото:");
                    string size_1=Console.ReadLine();
                    Console.WriteLine("Введите размер фото:");
                   string size_2=Console.ReadLine();   
                    Console.WriteLine("Имя файла:") ;
                    string name_png=Console.ReadLine();


                    Mat img = Cv2.ImRead("input.png");

                
                    Cv2.Circle(img, new System.Drawing.Point(100, 100), 50, new MCvScalar(0, 0, 255), 2);

                    
                    Cv2.Imwrite($"{name_png}.png", img);


                }
                else if(print_file =="4")
                {
                    Console.WriteLine("Имя файла:");
                    string name_jpg = Console.ReadLine();
                    Mat img = Cv2.ImRead("file.jpg");

                 
                    Cv2.CvtColor(img, img, ColorConversion.Bgr2Gray);

                    // Инвертируем цвета
                    Cv2.BitwiseNot(img, img);

                   
                    img.Save($"{name_jpg}.jpg");
                }
                else
                {
                    Console.WriteLine("Error");
                    return;
                }
            }
            else if(print_user =="2") 
            {
                Console.WriteLine("Введите путь до файла:");
                string open_file=Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Error");
                return;
            }


        }
    }

    internal class Cv2
    {
        internal static void BitwiseNot(Mat img1, Mat img2)
        {
            throw new NotImplementedException();
        }

        internal static void Circle(Mat img, System.Drawing.Point point, int v1, MCvScalar mCvScalar, int v2)
        {
            throw new NotImplementedException();
        }

        internal static void CvtColor(Mat img1, Mat img2, ColorConversion bgr2Gray)
        {
            throw new NotImplementedException();
        }

        internal static Mat ImRead(string v)
        {
            throw new NotImplementedException();
        }

        internal static void Imwrite(string v, Mat img)
        {
            throw new NotImplementedException();
        }
    }
}
