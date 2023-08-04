namespace MementoPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            JoystickPointerOriginator joystickPointerOriginator = new JoystickPointerOriginator(); 
            joystickPointerOriginator.X = 3;
            joystickPointerOriginator.isPressed = true;
            joystickPointerOriginator.Save();
            Console.WriteLine(joystickPointerOriginator.ToString());


        }
    }
}