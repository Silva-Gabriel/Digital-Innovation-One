
namespace GFT_2_PilaresPOO.myCode.Models
{
    public class Wizard : Hero
    {
        public Wizard(string nome, int level, string tipoHeroi)
        {
            this.nome = nome;
            this.level = level;
            this.tipoHeroi = tipoHeroi;
        }
        public override string Attack()
        {
            return this.nome + "Lançou magia";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 7)
            {
                return this.nome + "Lançou magia suprema com bônus de " + Bonus + "pontos";
            }
            else
            {
                return this.nome+" Lançou magia simples com bonus de " + Bonus + " pontos"; 
            }
        }
    }
}