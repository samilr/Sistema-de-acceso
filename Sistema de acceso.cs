using System;

namespace ConsoleApp8
{
    class Program
    {

            string[,] users = new string[10, 3];


            public void InitMethods(string title)
            {
                Console.Clear();
                Console.WriteLine(title + "\n");
                Console.WriteLine("------------------------------------------------------\n");
            }

            public void Login(string[,] user)
            {
                Program pro = new Program();
                string pass = "", userName = "";
                DateTime date = new DateTime(2020, 8, 4);

                pro.InitMethods("Iniciar Sesion");

                Console.WriteLine("Ingrese su nombre de usuario");
                userName = Console.ReadLine();

                Console.WriteLine("Ingrese su contraseña");
                pass = Console.ReadLine();

          
                for (int row = 0; row < 9; row++)
                {
                    if (user[row, 0] == userName && user[row, 1] == pass)
                    {
                        Console.WriteLine("Bienvenido " + user[row, 0] + " Su roll es " + user[row, 2] + "creado el: " + date.ToString());
                        break;
                    }
                   
                }
            }

            public Boolean validForm(string value, string[,] user)
            {
                Boolean exist = false;

                for (int row = 0; row < 9; row++)
                {
                    if (user[row, 0] == value)
                    {
                        Console.WriteLine("Nombre de Usuario existente, pruebe con otro");
                        exist = true;
                        break;
                    }

                }
            return exist;
           }

            public string get(int option)
            {
                string value = "";
                switch (option)
                {
                    case 0:
                        Console.WriteLine("Introduzca su nombre de usuario");
                        value = Console.ReadLine();
                        break;

                   

                    case 1:
                        Console.WriteLine("Introduzca su contraseña");
                        value = Console.ReadLine();
                        break;

                    case 2:
                        Boolean role = false;



                        do
                        {
                            Console.WriteLine("¿Que Roll desempeña?: Administrador, Supervidor o Vendedor");
                            value = Console.ReadLine();

                            if (value == "Administrador" || value == "Supervisor" || value == "Vendedor")
                            {
                                role = true;

                            }
                            else
                            {
                                Console.WriteLine("Roll invalido, ingrese uno de estos: Administrador, Supervidor o Vendedor");
                            }

                        } while (role != true);


                        break;

                    default:
                        Console.WriteLine("Esta opcion no esta en es sistema");
                        break;

                }
                return value;
            }

            public void Register(string[,] user)
            {
                Program pro = new Program();
                int count = 0;
                int res;

                do
                {
                    count = 1;
                    pro.InitMethods("Registrar un nuevo usuario");

                    for (int row = 0; row < count; row++)
                    {
                        for (int colum = 0; colum < 3; colum++)
                        {
                            user[row, colum] = pro.get(colum);
                        }
                    }
                    Console.WriteLine("\n ¡Usuario creado correctamente! \n\n Seleccione la opcion que desea ejecutar \n 1. Si desea registrar otro usuario \n 2. Volver al menu principal ");
                    res = Convert.ToInt32(Console.ReadLine());

                    if(res == 1)
                    {
                        count++;
                    }

                } while (res == 1);
                
            
                pro.Menu(user);

            }


            public void Menu(string[,] user)
            {

                int options;
                Program pro = new Program();
                pro.InitMethods("Menu principal");
                Console.WriteLine("Seleccione la opcion que desea ejecutar:\n");
                Console.WriteLine(" 1. Registrar\n 2. Iniciar Sesion ");
                options = Convert.ToInt32(Console.ReadLine());



                switch (options)
                {
                    case 1:
                        pro.Register(user);
                        break;
                    case 2:
                        pro.Login(user);
                        break;

                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }


            }

            static void Main(string[] args)
            {
                Program pro = new Program();
                pro.InitMethods("Bienvenido a Samil's App");
                pro.Menu(pro.users);
                Console.ReadKey();
            }
     }
 }

