// See https://aka.ms/new-console-template for more information

class Program
{
    public static void Main(string[] args)
    {
        Rectangle monRect = new Rectangle();
        //Console.WriteLine(monRect.AfficherRectangle());
        Console.Read();
    }
}

class Pilote
{
    private int identifiantNumerique;
    private int prenom;
    private int nom;
    private int callsign;
    private int grade;
    private int heuresDeVol;

    public int IdentifiantNumerique
    {
        get { return identifiantNumerique; }
        set { identifiantNumerique = value; }
    }

    public int Prenom
    {
        get { return prenom; }
        set { prenom = value; }
    }

    public int Nom
    {
        get { return nom; }
        set { nom = value; }
    }

    public int Callsign
    {
        get { return callsign; }
        set { callsign = value; }
    }

    public int Grade
    {
        get { return grade; }
        set { grade = value; }
    }

    public int HeuresDeVol
    {
        get { return heuresDeVol; }
        set { heuresDeVol = value; }
    }

    public Pilote(){ }

   
}


class Avion
{
    private int callsign;
    private int type; 
    private int capacite_carburant; 
    private int geopod;
    private int pilote;
    private int trainAtterrissage;

    public int Callsign
    {
        get { return callsign; }
        set { callsign = value; }
    }

    public int Type
    {
        get { return type; }
        set { type = value; }
    }

    public int Capacite_carburant
    {
        get { return capacite_carburant; }
        set { capacite_carburant = value; }
    }

    public int Geopod
    {
        get { return geopod; }
        set { geopod = value; }
    }

    public int Pilote
    {
        get { return pilote; }
        set { pilote = value; }
    }

    public int TrainAtterrissage
    {
        get { return trainAtterrissage; }
        set { trainAtterrissage = value; }
    }
}


