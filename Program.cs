Siswa siswa0bj = new Siswa("hanip", "hanip@gmail.com", "11111", "Siswa", "XPG2");
Guru guru0bj = new Guru("naura", "naura@gmail.com", "22222", "Guru", "mtk");

siswa0bj.TampilkanInfo();
siswa0bj.SubmitTugas();

Console.WriteLine();

guru0bj.TampilkanInfo();
guru0bj.NilaiTugas();
class user
{
    public string Nama;

    public string Email;


    public string Password;

    public string Role;

    public user(string nama,string email, string password, string role)
    {
        Nama = nama;
        Email = email;
        Password = password;
        Role = role;


    }

    public void TampilkanInfo()
    {
        Console.WriteLine("menampilkan info user...");
        Console.WriteLine($"Nama: {Nama}");
        Console.WriteLine($"Nama: {Role}");
    }
}

class Siswa : user
{
    public string ClassName;

    public Siswa(string nama, string email, string password, string role, string classname) : base(nama,email,password,role)
    { 
        ClassName = classname;
    }

    public void SubmitTugas()
    {
        Console.WriteLine($"siswa {Nama} sudah mengumpulkan semua tugas");
    }
}

class Guru : user
{
    public string Mapel;

    public Guru(string nama, string email, string password, string role, string mapel) : base(nama, email, password, role)
    {
        Mapel = mapel;
    }

    public void NilaiTugas()
    {
        Console.WriteLine($"Guru {Nama} sudah menilai semua tugas {Mapel}");
    }
}
