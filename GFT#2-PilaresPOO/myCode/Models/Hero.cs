namespace GFT_2_PilaresPOO.myCode.Models
{
    public abstract class Hero
    {
        public string nome;
        public int level;
        public string tipoHeroi;
        public Hero(string nome, int level, string tipoHeroi)
        {
            this.nome = nome;
            this.level = level;
            this.tipoHeroi = tipoHeroi;
        }

        public Hero()
        {
        }

        //Arus
        public override string ToString()
        {
            return "Nome: " + this.nome + "\n" + "Level: " + this.level + "\n" + "Tipo: " + this.tipoHeroi;
        }

        public virtual string Attack()
        {
            return this.nome + " Atacou com a sua espada";
        }

    }
}