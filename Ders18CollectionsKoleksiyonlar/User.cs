namespace Ders18CollectionsKoleksiyonlar
{
    public class User
    {
        private object value1;
        private object value2;
        private object value3;

        public User(object value1, object value2, object value3)
        {
            this.value1 = value1;
            this.value2 = value2;
            this.value3 = value3;
        }

        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}
