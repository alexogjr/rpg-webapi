using Microsoft.AspNetCore.Mvc;
using RPGapi.Data;
using RPGapi.Models;
namespace RPGapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RPGapiController : ControllerBase
    {

        private static List<Models.Player> _players = new()
        {
            new Models.Player { PossuiCartas = [0], Poderes = [], PontosTotais = 0, PlayerId = 0 },
        };

        private static List<Models.Cartas> _cartas = CartasData._cartas; // Correção aqui

        [HttpGet("/api/cartas")]
        public IEnumerable<Models.Cartas> Get()
        {
            return _cartas;
        }

        [HttpGet("/api/players")]
        public IEnumerable<Models.Player> GetPlayers()
        {
            return _players;
        }

        [HttpGet("/api/cartas/{id}")]
        public IActionResult GetID(int id)
        {
            var carta = _cartas.FirstOrDefault(c => c.CartaId == id);

            if (carta == null)
            {
                NotFound();
            }

            return Ok(carta);
        }


        [HttpGet("/api/players/{id}")]
        public IActionResult GetPId(int id)
        {
            var player = _players.FirstOrDefault(p => p.PlayerId == id);
            if (player == null)
            {
                NotFound();
            }

            return Ok(player);
        }

        [HttpPost("/api/player/create-player/{id}")]
        public IActionResult Post(int id)
        {
            var player = _players.FirstOrDefault(p => p.PlayerId == id);

            if (player is not null)
            {
                Conflict("O jogador já existe");
            }

            player = new Player
            {
                PlayerId = id
            };

            //player.PossuiCartas = player.PossuiCartas.RemoveFromArray(0);
            _players.Add(player);

            return Ok(_players);
        }

        [HttpPut("/api/cartas/adicionar-carta/{CartaId}/players/{PlayerId}")]
        public IActionResult Post(int CartaId, int PlayerId, Models.Player newConfig)
        {
            var carta = _cartas.FirstOrDefault(c => c.CartaId == CartaId);
            var player = _players.FirstOrDefault(p => p.PlayerId == PlayerId);

            if (player == null)
            {
                return NotFound("Esse jogador não existe");
            }
            else if (carta == null)
            {
                return NotFound("Essa carta não existe");
            }

            if (player.PossuiCartas.Length >= 6)
            {
                return BadRequest("O jogador já tem cartas o suficiente");
            }

            if (player.PossuiCartas.Contains(CartaId))
            {
                return BadRequest("O jogador já possui essa carta");
            }

            int pontosAlterados = carta.PontosCarta;

            if (carta.PontosCarta < 0)
            {
                Console.WriteLine("cara com num negativos");
                player.PontosTotais += pontosAlterados;
                Console.WriteLine(pontosAlterados);
            }
            else
            {
                Console.WriteLine("cara com num positivos");
                player.PontosTotais += pontosAlterados;
                Console.WriteLine(player.PontosTotais);
            }

            player.PossuiCartas = player.PossuiCartas.Append(CartaId).Distinct().ToArray();
            player.Poderes = player.Poderes.Append(carta.PoderCarta).Distinct().ToArray();

            player.Poderes.Distinct().ToArray();
            player.PossuiCartas.Distinct().ToArray();
            _players.Add(player);

            return Ok(player);
        }
    }
}
