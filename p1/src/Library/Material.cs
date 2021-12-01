namespace Ucu.Poo.Defense
{
    public class Material
    {
        public string Name { get; set; }

        public MaterialType Type { get; set; }

        public Material(string name, MaterialType type)
        {
            this.Name = name;
            this.Type = type;
        }

        public bool IsDangerous()
        {
            if(this.Type.IsDangerous)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}