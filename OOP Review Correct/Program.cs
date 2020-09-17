using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Review_Correct
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an instance of the window class using the default constructor
            //the system calls you class constructor, your code NEVER calls the constructor directly
            //the "new" will use indicated constructor
            //the "new" actually makes the call to the constructor and returns the instance of the class
            //call to the default constructor
            Window myInstance = new Window();

            //results of the constructor
            Console.WriteLine($"Width {myInstance.Width}; Height {myInstance.Height}; Panes {myInstance.NumberOfPanes}; Manufactor >{myInstance.Manufacturer}<");
            //to reference a property with in an instance, use the dot operator 
            //to place data within the new instance (object) of the class
            //use the properties

            myInstance.Width = 1.2m;
            myInstance.Height = 1.2m;
            myInstance.NumberOfPanes = 3;
            myInstance.Manufacturer = "Fancy Windows";

            Console.WriteLine($"Width {myInstance.Width}; Height {myInstance.Height}; Panes {myInstance.NumberOfPanes}; Manufactor >{myInstance.Manufacturer}<");


            Window myGreedyInstance = new Window(1.6m, 3.3m, 3, "All-Weather Windows");

            Console.WriteLine($"Width {myGreedyInstance.Width}; Height {myGreedyInstance.Height}; Panes {myGreedyInstance.NumberOfPanes}; Manufactor >{myGreedyInstance.Manufacturer}<");
            Door theDoor = new Door(1.2m, 1.9m, "L", "wood");
            Console.WriteLine($"Width {theDoor.Width}; Height {theDoor.Height}; R or L {theDoor.RightOrLeft}; Material >{theDoor.Material}<");
            Console.WriteLine("\n\n");

            usingClasses();
            Console.ReadKey(); //when using the debugger your console window will remain open 
        }
        static void usingClasses()
            {
            //the purpose of this method is to calculate the cost of painting a room
            //the room will have several windows and walls with a single door
            //all data for windows, walls, and doors will be collected and stored in a instance of room 

            //what does room need 
            //declare a list<T> of the componnets for the room
            List<Walls> walls = new List<Walls>();
            List<Door> Door = new List<Door>();
            List<Window> Window = new List<Window>();
            Room room = new Room(); //default constructor

            //create a reusable pointer variable to each componenet of the room
            //these pointers are created outside the loop

            Walls wall = null;
            Door door = null;
            Window window = null;
            //collect the data for all of the walls in the room 
            // loop of prompt/input/validating for each wall 
            //after validation of data, create an instance of your class
            wall = new Walls();
            //load the incoming data into the instance of your class
            wall.Width = 6.6m;
            wall.Height = 3.1m;
            //add the new instance into your collection (List<T> to save the data)
            walls.Add(wall);

            wall = new Walls();
            //load the incoming data into the instance of your class
            //pass 2
            wall.Width = 5.6m;
            wall.Height = 3.1m;
            //add the new instance into your collection (List<T> to save the data)
            walls.Add(wall);

            wall = new Walls();
            //load the incoming data into the instance of your class
            //pass 3
            wall.Width = 5.6m;
            wall.Height = 3.1m;
            //add the new instance into your collection (List<T> to save the data)
            walls.Add(wall);

            wall = new Walls();
            //load the incoming data into the instance of your class
            //pass 4
            wall.Width = 5.6m;
            wall.Height = 3.1m;
            //add the new instance into your collection (List<T> to save the data)
            walls.Add(wall);
            //end of loop

            //assume the loop collected and stored the following

            //door loop
            //prompt/input/validate
            //store
            //assume in this example that the literials were actually in variables
            //door = new Door(input width, input height, inputRL, input materail);
            door = new Door(0.85m, 2.0m, "R", "Compostie Pressed Wood");
            Door.Add(door);
        }
    }
}
