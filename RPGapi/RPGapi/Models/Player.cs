namespace RPGapi.Models
{
    public class Player
    {
        public int[]? PossuiCartas { get; set; } = [0];
        public string[]? Poderes { get; set; } = [];
        public int PontosTotais { get; set; } = 0;
        public int PlayerId { get; set; } = 0;
    }
}


/* player
 *
 * carta que ele tem
 * poder total
 * pontos totais
*/