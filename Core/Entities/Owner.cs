namespace Core.Entities
{
    public class Owner : EntityBase
    {
        public string _FullName { get; set; }
        public string _Profil { get; set; }
        public string _Avatar { get; set; }

        public Adress _Adress { get; set; }
    }
}
