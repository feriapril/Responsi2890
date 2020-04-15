namespace Responsi
{
    public class Program
    {

        static void Main(string[] args)
        {
            Karyawan Karyawan = new Karyawan("190302123 Budi", 3000000);
            Karyawan.GetNameAndAge();

            Karyawan karyawan = new Karyawan("190302124 Budi", 2000000);
            karyawan.GetNameAndAge();
        }
    }
}