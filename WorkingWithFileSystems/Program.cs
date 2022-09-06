using static System.Console;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;

WorkWithDrives();

static void WorkWithDrives()
{
    Console.WriteLine($"{0,-30} | {1,-10} | {2,-7} | {3,18} | {4,18}", "NAME", "TYPE", "FORMAT", "SIZE (BYTES)", 
        "FREE SPACE");

    foreach (DriveInfo drive in DriveInfo.GetDrives())
    {
        if (drive.IsReady) {
            Console.WriteLine($"{0,-30} | {1,-10} | {2,-7} | {3,18: NO} | {4,18: NO}", drive.Name, drive.DriveType, 
                drive.DriveFormat, drive.TotalSize, drive.AvailableFreeSpace);
        } else
        {
            Console.WriteLine($"{0,-30} | {1,-10}", drive.Name, drive.DriveType);
        }

    }
}





