using System.Security.Cryptography;



class Program
{
    static void Main ()
    {
        Person person1 = new Person ("william","afton",100,20);
        Police police1 = new Police ("baton","bob","sawyer",50,210);
        Doctor doctor1 = new Doctor ("bonesaw, medicine","susan","richards",29,175);
        Console.WriteLine (police1.GetPoliceInformation());
        Console.WriteLine (doctor1.GetDoctorInformation());
        doctor1.SetWeight(230);
        Console.WriteLine (doctor1.GetDoctorInformation());
        int i = 5;
        int currentLineCursor = Console.CursorTop;
        while (i > 0)
        {
            int time = 5;
            while (time > 0)
            {
                Console.SetCursorPosition(0, currentLineCursor);
                Console.Write ($"in:{time}");
                time--;
                Thread.Sleep (100);
            }
            time = 5;
            while (time > 0)
            {
                Console.SetCursorPosition(0, currentLineCursor);
                string outee = ($"out:{time}");
                outee.Remove(1);
                Console.Write (outee);
                time--;
                Thread.Sleep (100);
            }
            i --;
            Console.SetCursorPosition(0, currentLineCursor);
        }


    }
}

