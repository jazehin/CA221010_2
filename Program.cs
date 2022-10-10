namespace CA221010_2
{
    public abstract class Jarmu
    {
        public int TankMeret { get; set; }
        public float BenzinMennyiseg { get; set; } = 0f;
        public int SzallithatoSzemelyekSzama { get; set; }

        public abstract void Tankol(float benzin);
    }

    public class Gepkocsi : Jarmu
    {
        public Gepkocsi()
        {
            TankMeret = 80;
            SzallithatoSzemelyekSzama = 4;
        }

        public override void Tankol(float benzin)
        {
            if (BenzinMennyiseg + benzin <= TankMeret)
                BenzinMennyiseg += benzin;
            else
            {
                BenzinMennyiseg = TankMeret;
                Console.WriteLine($"Maradt {Math.Abs(TankMeret - BenzinMennyiseg - benzin)}");
            }
        }
    }

    public class Motorkerekpar : Jarmu
    {
        public Motorkerekpar()
        {
            TankMeret = 50;
            SzallithatoSzemelyekSzama = 2;
        }

        public override void Tankol(float benzin)
        {
            if (BenzinMennyiseg + benzin <= TankMeret)
                BenzinMennyiseg += benzin;
            else
            {
                BenzinMennyiseg = TankMeret;
                Console.WriteLine($"Maradt {Math.Abs(TankMeret - BenzinMennyiseg - benzin)}");
            }
        }
    }

    public class Tesla : Jarmu
    {
        public Tesla()
        {
            SzallithatoSzemelyekSzama = 4;
        }

        public override void Tankol(float benzin)
        {
            Console.WriteLine($"nem kell a {benzin} liter benzin, dugd be a konnektorba");
            BenzinMennyiseg = TankMeret;
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Jarmu g1 = new Gepkocsi();
            Jarmu m1 = new Motorkerekpar();
            Jarmu t1 = new Tesla();

            List<Jarmu> jarmuvek = new List<Jarmu>();
            jarmuvek.Add(g1);
            jarmuvek.Add(m1);
            jarmuvek.Add(t1);

            foreach (Jarmu jarmu in jarmuvek)
            {
                jarmu.Tankol(10f);
            }
        }
    }
}