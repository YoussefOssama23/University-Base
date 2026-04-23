namespace University.Base.Models
{
    public class BaseUser
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual string GetRole()
        {
            return "Base User";
        }
    }
}