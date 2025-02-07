using RPGapi.Models;

namespace RPGapi.Data
{
    public static class CartasData
    {

        public static readonly List<Cartas> _cartas = new()
        {
            // atributos bons
            // super força
            new Cartas { NomeCarta = "Força Crônica I", PoderCarta = "Super Força", PontosCarta = 2, CartaId = 1},
            new Cartas { NomeCarta = "Força Crônica II", PoderCarta = "Super Força II", PontosCarta = 4, CartaId = 2},
            new Cartas { NomeCarta = "Força Crônica III", PoderCarta = "Super Força III", PontosCarta = 6, CartaId = 3},
            
            // velocidade
            new Cartas { NomeCarta = "Super Velocidade I", PoderCarta = "Velocidade I", PontosCarta = 2, CartaId = 4},
            new Cartas { NomeCarta = "Super Velocidade II", PoderCarta = "Velocidade II", PontosCarta = 4, CartaId = 5},
            new Cartas { NomeCarta = "Super Velocidade III", PoderCarta = "Velocidade III", PontosCarta = 6, CartaId = 6},

            // inteligencia
            new Cartas { NomeCarta = "Super Inteligência I", PoderCarta = "Inteligência I", PontosCarta = 3, CartaId = 7},
            new Cartas { NomeCarta = "Super Inteligência II", PoderCarta = "Inteligência II", PontosCarta = 6, CartaId = 8},
            new Cartas { NomeCarta = "Super Inteligência III", PoderCarta = "Inteligência III", PontosCarta = 9, CartaId = 9},
            
            // atributos ruins
            // falta de força
            new Cartas { NomeCarta = "Fracote I", PoderCarta = "Falta de força I", PontosCarta = -2, CartaId = 10},
            new Cartas { NomeCarta = "Fracote II", PoderCarta = "Falta de força II", PontosCarta = -4, CartaId = 11},
            new Cartas { NomeCarta = "Fracote III", PoderCarta = "Falta de força III", PontosCarta = -6, CartaId = 12},
        
            // lentidão
            new Cartas { NomeCarta = "Lerdeza I", PoderCarta = "Falta de velocidade I", PontosCarta = -2, CartaId = 13},
            new Cartas { NomeCarta = "Lerdeza II", PoderCarta = "Falta de velocidade II", PontosCarta = -4, CartaId = 14},
            new Cartas { NomeCarta = "Lerdeza III", PoderCarta = "Falta de velocidade III", PontosCarta = -6, CartaId = 15},

            // burrice
            new Cartas { NomeCarta = "Burrice I", PoderCarta = "Burrice I", PontosCarta = -3, CartaId = 16},
            new Cartas { NomeCarta = "Burrice II", PoderCarta = "Burrice II", PontosCarta = -6, CartaId = 17},
            new Cartas { NomeCarta = "Burrice III", PoderCarta = "Burrice III", PontosCarta = -9, CartaId = 18},

        };

    }
}
